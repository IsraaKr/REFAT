using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using REFAT.Core;
using REFAT.Data.EF;
using System.Threading.Tasks;
using REFAT.Code.Models;
using REFAT.Code.Helpers;
using REFAT.GUI.LoadingGui;
using System.Linq;

namespace REFAT.GUI.UsersGui
{
    public partial class Users_UserControl : UserControl
    {
        //singelton
        private static  Users_UserControl? user_UsersControl;
        private Add_User_Form add_User_Form;//لمنع التكرار
        private static Main _main;
        private IDataHelper<Users> dataHelper;
        private List<Users> data;
        private LoadingForm loading;
        private List<int> IdDeleteList;

        public Users_UserControl()
        {
            InitializeComponent();
            dataHelper = new UsersEF();
            data = new List<Users>();
            IdDeleteList = new List<int>();
            LoadData();
        }
        public static Users_UserControl instance(Main main)//تحاشي الاستنساخ المتعدد
        {
            _main = main;//مشان تحديد الأب
            return user_UsersControl ?? ( user_UsersControl = new Users_UserControl());//اذا قيمة فارغة أرجع نيو يوسر كونترول
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            if (add_User_Form == null || add_User_Form.IsDisposed)
            {
                add_User_Form = new Add_User_Form(_main, 0,this);
                add_User_Form.Show();
            }
            else
                add_User_Form.Focus();
            
        }
        private void button_Edit_Click(object sender, EventArgs e)
        {
            Edite();
        }       
        private async void button_Delet_ClickAsync(object sender, EventArgs e)
        {
            if (!dgvHelper.IsEmpty(dgv))
            {
                //show loading 
                LoadingForm.Instance(_main).Show();
               
                    //get id
                    SetDeletedList();

                if (IdDeleteList.Count > 0)
                {
                    if (MsgHelper.ShowDeleteDialog())
                    {
                        //check connecton
                        if (await Task.Run(() => dataHelper.IsCanConnect()))
                        {
                            //loop into id list
                            foreach (int id in IdDeleteList)
                            {
                                var result = await Task.Run(() => dataHelper.Delete(id));
                                if (result == "1")
                                {
                                    ToastHelper.showDeleteToast();
                                    LoadData();
                                }
                                else
                                {
                                    LoadingForm.Instance(_main).Hide();
                                    MessageBox.Show(result);
                                }
                            }
                        }
                        else
                        {
                            LoadingForm.Instance(_main).Hide();
                            MsgHelper.ShowServerError();
                        }
                        LoadingForm.Instance(_main).Hide();
                    }
                }
                else
                {
                    MsgHelper.ShowDeleteSelectedRow();
                }
                
            }
            else
                MsgHelper.ShowEmpteyDgv();
        }

        private void SetDeletedList()
        {
            IdDeleteList.Clear();
            foreach (DataGridViewRow item in dgv.Rows)
            {

                if (item.Selected)
                IdDeleteList.Add(Convert.ToInt32( item.Cells[0].Value));
            }
        }

        private void button_Export_Click(object sender, EventArgs e)
        {

        }
        private void button_Search_Click(object sender, EventArgs e)
        {

        }
        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Edite();
        }
        //Methodes
        public async void LoadData()
        {
            //show loading
            LoadingForm.Instance(_main).Show();
            if (await Task.Run(()=>dataHelper.IsCanConnect()))
            {
                // statrt load data
                //check if admin or not
                if (LocalUser.Role=="Admin")
                {
                    //get all data
                    data = await Task.Run(() => dataHelper.GetAllData());
                }
                else
                {
                    //get data by user
                    data = await Task.Run(() => dataHelper.GetDataByUser(LocalUser.UserId));

                }
                //fill data graid view
                dgv.DataSource = data.ToList();

                // set columns titeles
                SetColumns();

                // show emptey data
                ShowEmpteyDataState();

                //clear data
                data.Clear();
            }
            else
            {
                //no conection
                LoadingForm.Instance(_main).Hide();
                ShowServerErroreState();
                MsgHelper.ShowServerError();

            }
            //hide loading
            LoadingForm.Instance(_main).Hide();

          
        }
        private void ShowEmpteyDataState()
        {
            //set titel and description
            labelStatTitel.Text = Properties.Resources.EmptyDataStateTitle;
            labelstateDesecreption.Text = Properties.Resources.EmptyDataStateDescription;
            panelState.Visible = dgvHelper.IsEmpty(dgv);

        }
        private void ShowServerErroreState()
        {
            //set titel and description
            labelStatTitel.Text = Properties.Resources.ServerErroreTitle;
            labelstateDesecreption.Text = Properties.Resources.ServerErroreDescription;
            panelState.Visible = true;

        }
        private void SetColumns()
        {
            dgv.Columns[0].HeaderCell.Value = "المعرف";
            dgv.Columns[1].HeaderCell.Value = "الاسم الكامل";
            dgv.Columns[2].HeaderCell.Value = "اسم المستخدم";
            dgv.Columns[3].HeaderCell.Value = "كلمة المرور";
            dgv.Columns[4].HeaderCell.Value = "الصلاحية";
            dgv.Columns[5].HeaderCell.Value = "هل المستخدم ثانوي";
            dgv.Columns[6].HeaderCell.Value = "المعرف الأساس";
            dgv.Columns[7].HeaderCell.Value = "الهاتف";
            dgv.Columns[8].HeaderCell.Value = "الايميل";
            dgv.Columns[9].HeaderCell.Value = "السكن";
            dgv.Columns[10].HeaderCell.Value = "تاريخ الإنشاء";
            dgv.Columns[11].HeaderCell.Value = "تاريخ التعديل";
            // visibal of columns
            dgv.Columns[3].Visible = false;
            dgv.Columns[5].Visible = false;
            dgv.Columns[6].Visible = false;
            //dgv.Columns[12].Visible = false;
            //dgv.Columns[13].Visible = false;

        }
        private void Edite()
        {
            if (!dgvHelper.IsEmpty(dgv))
            {
                int id = Convert.ToInt32(dgv.CurrentRow.Cells[0].Value);
                if (add_User_Form == null || add_User_Form.IsDisposed)
                {
                    add_User_Form = new Add_User_Form(_main, id, this);
                    add_User_Form.Show();
                }
                else
                    add_User_Form.Focus();
            }
            else
                MsgHelper.ShowEmpteyDgv();
        }

     

    }
}
