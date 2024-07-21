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

namespace REFAT.GUI.SalryRateGui
{
    public partial class Add_SalaryRate_Form : Form
    {
        private readonly IDataHelper<SalaryRate> dataHelperSalaryRate;
        private readonly IDataHelper<SystemRecords> dataHelperSystemRecord;
        private readonly Main main;
        private int Id;
        private DateTime UserCreatedDate;
        private readonly SalaryRate_UserControl Page;
        public Add_SalaryRate_Form (Main main, int id, SalaryRate_UserControl page )
        {
            InitializeComponent();

            dataHelperSystemRecord = new SystemRecordsEF();
            dataHelperSalaryRate = new SalaryRateEF();
            this.Owner = main;
            this.main = main;
            this.Id = id;
            this.Page = page;

            if (id > 0)
                SetDataForEdite();

            // set Gui
            labelSalary.Text = Properties.Settings.Default.Currency;
            labelBonas.Text = Properties.Settings.Default.Currency;

        }

        private async void Add()
        {
            //set user
            SalaryRate salaryRate = new SalaryRate
            {
                Degree = (int)numericUpDown_Degree.Value,
                PromotionYear = (int)numericUpDown_Promption.Value,
                Salary =(float)Convert.ToDecimal( textBox_Salary.Text),
                BonusYearRate = (float)Convert.ToDecimal(textBox_BonasYear.Text),
                UsersId = LocalUser.UserId,

            };
            // send data to db
            var result = await Task.Run(() => dataHelperSalaryRate.Add(salaryRate));
            if (result == "1")
            {
               

                //success
                SystemRecordHelper.Add("إضافة درجة", $" تم إضافة درجة  برقم تعريفي{salaryRate.Id} ");
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
            SalaryRate SalaryRate = new SalaryRate
            {
                Id = Id,
                Degree = (int)numericUpDown_Degree.Value,
                PromotionYear = (int)numericUpDown_Promption.Value,
                Salary = (float)Convert.ToDecimal(textBox_Salary.Text),
                BonusYearRate = (float)Convert.ToDecimal(textBox_BonasYear.Text),
                UsersId = LocalUser.UserId,
            };
            // send data to db
            var result = await Task.Run(() => dataHelperSalaryRate.Edit(SalaryRate));
            if (result == "1")
            {
               
                //success
                SystemRecordHelper.Add("تعديل درجة", $" تم تعديل درجة  برقم تعريفي{SalaryRate.Id} ");

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
            var _salary = await Task.Run(() => dataHelperSalaryRate.Find(Id));
            if (_salary != null)
            {

                numericUpDown_Degree.Value = _salary.Degree;
                numericUpDown_Promption.Value = _salary.PromotionYear;
                textBox_Salary.Text = _salary.Salary.ToString();
                textBox_BonasYear.Text = _salary.BonusYearRate.ToString();
            }

          
        }

     
   
            private bool IsValid()
        {
            if (numericUpDown_Degree.Value>=0 )
                
            {
                return true;
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
                if (await Task.Run(() => dataHelperSalaryRate.IsCanConnect()))
                {
                    //check duplicated item♥
                    int degree = (int)numericUpDown_Degree.Value;

                    var result = await Task.Run(() => dataHelperSalaryRate.GetDataByUser(LocalUser.UserId)
                      .Where(l => l.Id != Id)
                      .Where(l => l.Degree == degree )
                      .FirstOrDefault() ?? new SalaryRate());
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


    
        private void textBox_Salary_MouseLeave(object sender, EventArgs e)
        {
            if (!float.TryParse(textBox_Salary.Text, out float salaryRate))
            {
                textBox_Salary.Text = "0";

                MsgHelper.ShowNumberValid();
            }
        }
        private void textBox_BonasYear_MouseLeave(object sender, EventArgs e)
        {
            if (!float.TryParse(textBox_BonasYear.Text, out float salaryRate))
            {
                textBox_BonasYear.Text = "0";

                MsgHelper.ShowNumberValid();
            }
        }
    }
}
