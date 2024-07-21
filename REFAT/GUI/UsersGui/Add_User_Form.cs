using REFAT.Code.Helpers;
using REFAT.Code.Models;
using REFAT.Core;
using REFAT.Data.EF;
using REFAT.GUI.LoadingGui;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REFAT.GUI.UsersGui
{
    public partial class Add_User_Form : Form
    {
        private readonly IDataHelper<Users> dataHelperUser;
        private readonly IDataHelper<Roles> dataHelperRoles;
        private readonly IDataHelper<SystemRecords> dataHelperSystemRecord;
        private readonly Main main;
        private int Id;
        private DateTime UserCreatedDate;
        private readonly Users_UserControl Page;

        public Add_User_Form(Main main, int id, Users_UserControl page)
        {
            InitializeComponent();

            dataHelperRoles = new RolesEF();
            dataHelperSystemRecord = new SystemRecordsEF();
            dataHelperUser = new UsersEF();
            this.Owner = main;
            SetRoles();
            AddSeconderyUser();
            this.main = main;
            this.Id = id;
            this.Page = page;

            if (id > 0)
                SetDataForEdite();

        }


    
        private async void Add()
        {//set user
            Users users = new Users
            {
                FullName = textBoxFull_name.Text,
                PassWord = textBox_PassWord.Text,
                UserName = textBox_UserName.Text,
                Email = textBox_Email.Text,
                Phone = textBox_Phone.Text,
                Address = textBox_Adress.Text,
                CreatedDate = DateTime.Now.Date,
                EditedDate = DateTime.Now.Date,
                Role = comboBox_Role.SelectedItem.ToString() ?? "User",//اذا فاضي اختار يوزر
                IsSecondaryUser = checkBoxSeconderyUser.Checked,
                UserId = SetUserId(),

            };
            // send data to db
            var result = await Task.Run(() => dataHelperUser.Add(users));
            if (result == "1")
            {
                //done and add user  roles
                foreach (var item in flowLayoutPanel_Roles.Controls)
                {
                    CheckBox checkBox = item as CheckBox;
                    //set role
                    Roles roles = new Roles
                    {
                        Key = checkBox.Name,
                        Value = checkBox.Checked,
                        UsersId = users.Id
                    };
                    //send role
                    await Task.Run(() => dataHelperRoles.Add(roles));
                }

                //success
                SystemRecordHelper.Add("إضافة مستخدم",$" تم إضافة مستخدم  برقم تعريفي{users.Id} ");
                Page.LoadData();//تحديث البيانات 
                ToastHelper.showAddToast();
                this.Close();
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
            Users users = new Users
            {
                Id = Id,
                FullName = textBoxFull_name.Text,
                PassWord = textBox_PassWord.Text,
                UserName = textBox_UserName.Text,
                Email = textBox_Email.Text,
                Phone = textBox_Phone.Text,
                Address = textBox_Adress.Text,
               CreatedDate = UserCreatedDate,
                EditedDate = DateTime.Now.Date,
                Role = comboBox_Role.SelectedItem.ToString() ?? "User",//اذا فاضي اختار يوزر
                IsSecondaryUser = checkBoxSeconderyUser.Checked,
                UserId = SetUserId(),
            };
            // send data to db
            var result = await Task.Run(() => dataHelperUser.Edit(users));
            if (result == "1")
            {
                //remove role
                var oldRoles = await Task.Run(() => dataHelperRoles.GetAllData()
                .Where(l => l.Id == Id).ToList() ?? new List<Roles>());
                foreach (var item in oldRoles)
                {
                    await Task.Run(() => dataHelperRoles.Delete(item.Id));
                }

                //done and add user  roles
                foreach (var item in flowLayoutPanel_Roles.Controls)
                {
                    CheckBox checkBox = item as CheckBox;
                    //set role
                    Roles roles = new Roles
                    {
                        Key = checkBox.Name,
                        Value = checkBox.Checked,
                        UsersId = users.Id
                    };
                    //send role
                    await Task.Run(() => dataHelperRoles.Add(roles));
                }
                //success
                SystemRecordHelper.Add("تعديل مستخدم", $" تم تعديل مستخدم  برقم تعريفي{users.Id} ");

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
            var _user = await Task.Run(() => dataHelperUser.Find(Id));
            if (_user != null)
            {

                textBoxFull_name.Text = _user.FullName;
                textBox_PassWord.Text = _user.PassWord;
                textBox_UserName.Text = _user.UserName;
                textBox_Email.Text = _user.Email;
                textBox_Phone.Text = _user.Phone;
                textBox_Adress.Text = _user.Address;
                comboBox_Role.SelectedItem = _user.Role;
                checkBoxSeconderyUser.Checked = _user.IsSecondaryUser;
                UserCreatedDate = _user.CreatedDate;
            }
            
            //set roles
            foreach (var item in flowLayoutPanel_Roles.Controls)
            {
                CheckBox checkBox = item as CheckBox;
                checkBox.Checked = await Task.Run(() => dataHelperRoles
                  .GetAllData()
                  .Where(l => l.UsersId == Id && l.Key == checkBox.Name)
                  .Select(l => l.Value).FirstOrDefault());

            }
        }

        private string SetUserId()
        {
            if (checkBoxSeconderyUser.Checked)
            {
                return comboBox_UsersId.SelectedItem.ToString() ?? LocalUser.UserId;
            }
            else
            {
                return Guid.NewGuid().ToString();//جينيريت قيمة جديدة
            }
        }

        private void SetRoles()
        {
            if (LocalUser.Role == "Admin")
            {
                //add roles admin
                comboBox_Role.Items.Clear();
                comboBox_Role.Items.Add("Admin");
                comboBox_Role.Items.Add("User");
                comboBox_Role.Items.Add("Read");


                checkBoxSeconderyUser.Enabled = true;
                comboBox_UsersId.Enabled = false;
                comboBox_Role.SelectedIndex = 1;

            }
            else
            {
                //add roles user
                comboBox_Role.Items.Clear();
                comboBox_Role.Items.Add("User");
                comboBox_Role.Items.Add("Read");
                comboBox_UsersId.Enabled = false;
                comboBox_Role.SelectedIndex = 0;

                checkBoxSeconderyUser.Enabled = false;
                checkBoxSeconderyUser.Checked = true;
            }
        }
        private void AddSeconderyUser()
        {//hالسيكندوري يوزر مثل مجموعة مستخدمين تابعين للقسم المالي لذلك عند انشاء 
            comboBox_UsersId.Items.Clear();
            comboBox_UsersId.Items.Add(LocalUser.UserId);
            comboBox_UsersId.SelectedIndex = 0;
        }
        private void SetRolesByMainRole()//تسندعى في كومبو الرول تيكست تشينج
        {
            if (comboBox_Role.SelectedItem.ToString() == "Admin")
            {

            }
            else if (comboBox_Role.SelectedItem.ToString() == "User")
            {

            }
            else if (comboBox_Role.SelectedItem.ToString() == "Read")
            {
                checkBox_Add.Checked = false;
                checkBox_Edite.Checked = false;
                checkBox_delete.Checked = false;
            }
        }

        private bool IsValid()
        {
            if (textBoxFull_name.Text.Length < 4 ||
                textBox_PassWord.Text.Length < 4 ||
                textBox_UserName.Text.Length < 4)
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
                if (await Task.Run(() => dataHelperUser.IsCanConnect()))
                {
                    //check duplicated item♥
                    string fullName = textBoxFull_name.Text;
                    string userName = textBox_UserName.Text;
                    var result = await Task.Run(() => dataHelperUser.GetAllData()
                      .Where(l => l.Id != Id)
                      .Where(l => l.FullName == fullName || l.UserName == userName)
                      .FirstOrDefault() ?? new Users());
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


        private void checkBoxSeconderyUser_CheckedChanged(object sender, EventArgs e)
        {
            if (LocalUser.Role == "Admin")
                comboBox_UsersId.Enabled = checkBoxSeconderyUser.Checked;
            else
            {
                comboBox_UsersId.Enabled = false;
            }
        }
    }
}
