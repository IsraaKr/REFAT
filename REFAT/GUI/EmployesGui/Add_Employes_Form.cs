using REFAT.Code.Helpers;
using REFAT.Code.Models;
using REFAT.Core;
using REFAT.Data.EF;
using REFAT.GUI.LoadingGui;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REFAT.GUI.EmployesGui
{
    public partial class Add_Employes_Form : Form
    {
        private readonly IDataHelper<Employes> dataHelperEmp;
        private readonly IDataHelper<SystemRecords> dataHelperSystemRecord;
        private readonly Main main;
        private int Id;
        private DateTime UserCreatedDate;
        private readonly Employes_UserControl Page;
        public Add_Employes_Form(Main main, int id, Employes_UserControl page )
        {
            InitializeComponent();

            dataHelperSystemRecord = new SystemRecordsEF();
            dataHelperEmp = new EmployesEF();
            this.Owner = main;
            this.main = main;
            this.Id = id;
            this.Page = page;

            if (id > 0)
                SetDataForEdite();

            // set Gui
            labelSalary.Text = Properties.Settings.Default.Currency;
            labelSalarey2.Text = Properties.Settings.Default.Currency;

        }

        private async void Add()
        {
            //set user
            Employes Employes = new Employes
            {
                Name = textBoxFull_name.Text,
                JobTittle = comboBox_job_title.Text,
                EmpSate = comboBox_EmpState.Text,
                LastPromotionDate = dateTimePicker_last_Promotion.Value.Date,

                CurrentDegree = (int)numericUpDown_CurentDegree.Value,
                CurrentStage = (int)numericUpDown_curent_stste.Value,
                CurrentSalary = (float)Convert.ToDecimal(textBox_next_salarey.Text),
                CurrentDate = dateTimePicker_CurentDate.Value.Date,

                NextDegree = (int)numericUpDown_CurentDegree.Value,
                NextStage = (int)numericUpDown_curent_stste.Value,
                NextSalary = (float)Convert.ToDecimal(textBox_next_salarey.Text),
                NextDate = dateTimePicker_CurentDate.Value.Date,

                UserId = LocalUser.UserId,

                AddedDate = DateTime.Now.Date,
            };
            // send data to db
            var result = await Task.Run(() => dataHelperEmp.Add(Employes));
            if (result == "1")
            {
               

                //success
                SystemRecordHelper.Add("إضافة درجة", $" تم إضافة درجة  برقم تعريفي{Employes.Id} ");
                Page.LoadData();//تحديث البيانات 
                ToastHelper.showAddToast();
             
            }
            else
            {
                MessageBox.Show(result);
                //msg with erore
            }
        }
        private async void Edit()
        {

            SetDataForEdite();
            //set user
            Employes Employes = new Employes
            {
                
            };
            // send data to db
            var result = await Task.Run(() => dataHelperEmp.Edit(Employes));
            if (result == "1")
            {
               
                //success
                SystemRecordHelper.Add("تعديل درجة", $" تم تعديل درجة  برقم تعريفي{Employes.Id} ");

                Page.LoadData();//تحديث البيانات 
                ToastHelper.showEditToast();
                this.Close();
            }
            else
            {
                MessageBox.Show(result);
                //msg with erore
            }
        }

        private async void SetDataForEdite()
        {
            //get edited user data
            var _salary = await Task.Run(() => dataHelperEmp.Find(Id));
            if (_salary != null)
            {

               
            }

          
        }

     
   
            private bool IsValid()
        {
            if (textBoxFull_name.Text.Length <3 
                || comboBox_job_title.Text.Length<3
                || comboBox_EmpState.Text.Length < 3)
                
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //Methodes

        private async void button_Save_ClickAsync(object sender, EventArgs e)
        {
            //cheack fields
            if (!IsValid())
            {
                MsgHelper.ShowRequierdfileds();
            }
            else
            {
                //show loading 
                LoadingForm.Instance(main).Show();

                //check connecton
                if (await Task.Run(() => dataHelperEmp.IsCanConnect()))
                {
                    //check duplicated item♥
                    string fullName = textBoxFull_name.Text;

                    var result = await Task.Run(() => dataHelperEmp.GetDataByUser(LocalUser.UserId)
                      .Where(l => l.Id != Id)
                      .Where(l => l.Name == fullName)
                      .FirstOrDefault() ?? new Employes());
                    if (result.Id > 0)
                    {
                        LoadingForm.Instance(main).Hide();
                        MsgHelper.ShowDuplicatedItems();
                    }
                    else
                    {
                        //add or edite
                        if (Id == 0)
                            Add();
                        else
                        {
                            Edit();
                        }
                    }
                }
                else
                {
                    LoadingForm.Instance(main).Hide();

                    MsgHelper.ShowServerError();

                }
                LoadingForm.Instance(main).Hide();

            }

        }
  

        private void textBox_curent_Sallarey_MouseLeave(object sender, EventArgs e)
        {
            if (!float.TryParse(textBox_curent_Sallarey.Text, out float Employes))
            {
                textBox_curent_Sallarey.Text = "0";

                MsgHelper.ShowNumberValid();
            }
        }

        private void textBox_next_salarey_MouseLeave(object sender, EventArgs e)
        {
            if (!float.TryParse(textBox_next_salarey.Text, out float Employes))
            {
                textBox_next_salarey.Text = "0";

                MsgHelper.ShowNumberValid();
            }
        }
    }
}
