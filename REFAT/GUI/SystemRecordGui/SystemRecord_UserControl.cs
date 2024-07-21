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

namespace REFAT.GUI.SystemRecordGui
{
    public partial class SystemRecord_UserControl : UserControl
    {
        //singelton
        private static SystemRecord_UserControl? user_SystemRecordsControl;
        private static Main _main;
        private IDataHelper<SystemRecords> dataHelper;
        private List<SystemRecords> data;
        private LoadingForm loading;
        private List<int> IdDeleteList;

        public SystemRecord_UserControl()
        {
            InitializeComponent();
            dataHelper = new SystemRecordsEF();
            data = new List<SystemRecords>();
            IdDeleteList = new List<int>();
            LoadData();
        }
        public static SystemRecord_UserControl instance(Main main)//تحاشي الاستنساخ المتعدد
        {
            _main = main;//مشان تحديد الأب
            return user_SystemRecordsControl ?? (user_SystemRecordsControl = new SystemRecord_UserControl());//اذا قيمة فارغة أرجع نيو يوسر كونترول
        }

  
        private async void button_Delet_ClickAsync(object sender, EventArgs e)
        {
            try
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
                                    await Task.Run(() => dataHelper.Delete(id));
                                }
                                ToastHelper.showDeleteToast();
                                LoadData();
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
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void SetDeletedList()
        {
            IdDeleteList.Clear();
            foreach (DataGridViewRow item in dgv.Rows)
            {

                if (item.Selected)
                    IdDeleteList.Add(Convert.ToInt32(item.Cells[0].Value));
            }
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            Search();
        }
        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        private async void button_Export_All_Click(object sender, EventArgs e)
        {
            //show loading
            LoadingForm.Instance(_main).Show();
            if (await Task.Run(() => dataHelper.IsCanConnect()))
            {
                // statrt load data
                //check if admin or not
                if (LocalUser.Role == "Admin")
                {
                    //get all data
                    data = await Task.Run(() => dataHelper.GetAllData());
                }
                else
                {
                    //get data by user
                    data = await Task.Run(() => dataHelper.GetDataByUser(LocalUser.UserId));

                }
                labelAllNo.Text = data.Count.ToString();
                //fill data graid view
                dgv.DataSource = data.Take(Properties.Settings.Default.NoOfDgvItems).ToList();

                if (data.Count <= Properties.Settings.Default.NoOfDgvItems)
                {
                    comboBox_noOfPage.Items.Clear();
                    comboBox_noOfPage.Items.Add(1);
                }

                //calc no of pages
                double val = Convert.ToDouble(data.Count) / Convert.ToDouble(Properties.Settings.Default.NoOfDgvItems);
                int noofpage = Convert.ToInt32(Math.Round(val, MidpointRounding.AwayFromZero));
                comboBox_noOfPage.Items.Clear();
                int x = 0;
                for (int i = 0; i <= noofpage; i++)
                    comboBox_noOfPage.Items.Add(x + 1);

                      LoadingForm.Instance(_main).Hide();
                ExportExcel(data);

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

        private void button_Export_dgv_Click(object sender, EventArgs e)
        {
            //get data
            var data = (List<SystemRecords>)dgv.DataSource;

            ExportExcel(data);
        }

        private void ExportExcel(List<SystemRecords> data)
        {
            //define data table
            DataTable dt = new DataTable();

            //convert data to datatable
            using (var reader = FastMember.ObjectReader.Create(data))
            {
                dt.Load(reader);
            }

            //reset datatable
            dt = arrangedDataTable(dt);

            // send to export3
            ExcelHelper.ExportExcel(dt, "SystemRecords");
        }

        private DataTable arrangedDataTable(DataTable datatable)
        {
            // rerange col and rename header
            datatable.Columns["Id"].SetOrdinal(0);
            datatable.Columns["Id"].ColumnName = "تسلسل";

            datatable.Columns["FullName"].SetOrdinal(1);
            datatable.Columns["FullName"].ColumnName = "الاسم الكامل";
           
             datatable.Columns["DeviceName"].SetOrdinal(2);
            datatable.Columns["DeviceName"].ColumnName = "اسم الجهاز";
          
            datatable.Columns["MachinId"].SetOrdinal(3);
            datatable.Columns["MachinId"].ColumnName = " الماك ";
           
            datatable.Columns["Title"].SetOrdinal(4);
            datatable.Columns["Title"].ColumnName = "عنوان الحركة ";
           
            datatable.Columns["Desiccation"].SetOrdinal(5);
            datatable.Columns["Desiccation"].ColumnName = "وصف الحركة ";
            
            datatable.Columns["CreatedDate"].SetOrdinal(6);
            datatable.Columns["CreatedDate"].ColumnName = "تاريخ الحركة";


            datatable.Columns["UsersId"].SetOrdinal(7);
            datatable.Columns["UsersId"].ColumnName = "معرف المستخدم";

            //removed columns
            datatable.Columns.Remove("Roles");
            datatable.Columns.Remove("SystemRecords");


            return datatable;
        }

        //Methodes
        public async void LoadData()
        {
            //show loading
            LoadingForm.Instance(_main).Show();
            if (await Task.Run(() => dataHelper.IsCanConnect()))
            {
                // statrt load data
                //check if admin or not
                if (LocalUser.Role == "Admin")
                {
                    //get all data
                    data = await Task.Run(() => dataHelper.GetAllData());
                }
                else
                {
                    //get data by user
                    data = await Task.Run(() => dataHelper.GetDataByUser(LocalUser.UserId));

                }
                labelAllNo.Text = data.Count.ToString();
                //fill data graid view
                dgv.DataSource = data.Take(Properties.Settings.Default.NoOfDgvItems).ToList();

                if (data.Count<= Properties.Settings.Default.NoOfDgvItems)
                {
                    comboBox_noOfPage.Items.Clear();
                    comboBox_noOfPage.Items.Add(1);
                }
                
                //calc no of pages
                double val = Convert.ToDouble(data.Count) / Convert.ToDouble(Properties.Settings.Default.NoOfDgvItems);
                int noofpage =Convert.ToInt32( Math.Round(val,MidpointRounding.AwayFromZero));
                comboBox_noOfPage.Items.Clear();
                int x = 0;
                for (int i = 0; i <= noofpage; i++)
                    comboBox_noOfPage.Items.Add(x+1);
                
                // set columns titeles
                SetColumns();

                // show emptey data
                ShowEmpteyDataState();

                //clear data
                data.Clear();
                LoadingForm.Instance(_main).Hide();

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
        public async void Search()
        {
            //show loading
            LoadingForm.Instance(_main).Show();
            if (await Task.Run(() => dataHelper.IsCanConnect()))
            {
                string searchItem = textBox_Search.Text;
                // statrt load data
                //check if admin or not
                if (LocalUser.Role == "Admin")
                {
                    //get all data
                    data = await Task.Run(() => dataHelper.SearchAll(searchItem));
                }
                else
                {
                    //get data by user
                    data = await Task.Run(() => dataHelper.SearchByUser(LocalUser.UserId, searchItem));

                }
                //fill data graid view
                dgv.DataSource = data.ToList();

                // set columns titeles
                //    SetColumns();

                // show emptey data
                ShowEmpteyDataState();

                //clear data
                data.Clear();
                LoadingForm.Instance(_main).Hide();

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
            dgv.Columns[2].HeaderCell.Value = "اسم الجهاز";
            dgv.Columns[3].HeaderCell.Value = " ماك ادريس";
            dgv.Columns[4].HeaderCell.Value = "العنوان";
            dgv.Columns[5].HeaderCell.Value = "الوصف";
            dgv.Columns[6].HeaderCell.Value =  "تاريخ الحركة";
            dgv.Columns[7].HeaderCell.Value = "المستخدم";
           

        }

        private void textBox_Search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                Search();
            }
        }
        private void button_next_Click(object sender, EventArgs e)
        {
            try
            {
                comboBox_noOfPage.SelectedIndex = comboBox_noOfPage.SelectedIndex + 1;
            
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button_prevew_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox_noOfPage.SelectedIndex!=0)
                {
                    comboBox_noOfPage.SelectedIndex=comboBox_noOfPage.SelectedIndex - 1;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private async void comboBox_noOfPage_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //show loading
                LoadingForm.Instance(_main).Show();
                if (await Task.Run(() => dataHelper.IsCanConnect()))
                {
                    // statrt load data
                    //check if admin or not
                    if (LocalUser.Role == "Admin")
                    {
                        //get all data
                        data = await Task.Run(() => dataHelper.GetAllData());
                    }
                    else
                    {
                        //get data by user
                        data = await Task.Run(() => dataHelper.GetDataByUser(LocalUser.UserId));

                    }
                    // get and set param
                    var idList = data.Select(l => l.Id).ToArray();
                    int index = comboBox_noOfPage.SelectedIndex;
                    int noofitemindex = index * Properties.Settings.Default.NoOfDgvItems;
                    //fill data graid view
                    dgv.DataSource = data.Where(l=>l.Id<=idList[noofitemindex])
                        .Take(Properties.Settings.Default.NoOfDgvItems).ToList();
                  
                    // show emptey data
                    ShowEmpteyDataState();

                    //clear data
                    data.Clear();
                    LoadingForm.Instance(_main).Hide();

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

            catch (Exception)
            {

                throw;
            }
            LoadingForm.Instance(_main).Hide();

        }
    }
}
