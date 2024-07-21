using REFAT.Code.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
//Severity	Code	Description	Project	File	Line	Suppression State
//Error NETSDK1064	Package Microsoft.EntityFrameworkCore.Analyzers, version 3.1.0 was not found. It might have been deleted since NuGet restore. Otherwise, NuGet restore might have only partially completed, which might have been due to maximum path length restrictions.	REFAT.Data	C:\Program Files\dotnet\sdk\3.1.400\Sdks\Microsoft.NET.Sdk\targets\Microsoft.PackageDependencyResolution.targets	241	

namespace REFAT
{
    public partial class Main : Form
    {
        private C_Page_Helper pageHelper;
        public Main()
        {
            InitializeComponent();
            pageHelper = new C_Page_Helper(this);
            //set home page
            pageHelper.SetPage(GUI.HomeGui.Home_UserControl.instance());

            //get and set windows state from setting
            set_secreen_state(Properties.Settings.Default.Is_Max_Secreen);

            setRole();
        }
        //test
        private void setRole()
        {
            Code.Models.LocalUser.UserId = "111234";
            Code.Models.LocalUser.Id = 1;
            Code.Models.LocalUser.Role = "Admin";
            Code.Models.LocalUser.FullName = "fullName";
            Code.Models.LocalUser.UserName = "userName";


        }
        private void set_secreen_state(bool IsMax)
        {
            if (IsMax)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }
        private void Save_Window_Satae()
        {
            //save window state
            if (WindowState == FormWindowState.Maximized)
            {
                Properties.Settings.Default.Is_Max_Secreen = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.Is_Max_Secreen = false;
                Properties.Settings.Default.Save();
            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Save_Window_Satae();
        }

        private void button_Main_Click(object sender, EventArgs e)
        {
            //ما عملنا كائن جديد بل وصلنا إلى الكائن بطريقة مباشرة هذا سينغلتون
            pageHelper.SetPage(GUI.HomeGui.Home_UserControl.instance());
        }

        private void buttonUser_Click(object sender, EventArgs e)
        {
            //ما عملنا كائن جديد بل وصلنا إلى الكائن بطريقة مباشرة هذا سينغلتون
            pageHelper.SetPage(GUI.UsersGui.Users_UserControl.instance(this));
        }

        private void button_SAlarey_Click(object sender, EventArgs e)
        {
            pageHelper.SetPage(GUI.SalryRateGui.SalaryRate_UserControl.instance(this));

        }

        private void button_Emp_Click(object sender, EventArgs e)
        {
            pageHelper.SetPage(GUI.EmployesGui.Employes_UserControl.instance(this));

        }

        private void button_report_Click(object sender, EventArgs e)
        {

        }

        private void button_Setting_Click(object sender, EventArgs e)
        {

        }
        private void buttonSystemRecord_Click(object sender, EventArgs e)
        {
            pageHelper.SetPage(GUI.SystemRecordGui.SystemRecord_UserControl.instance(this));
        }

        private void button_Help_Click(object sender, EventArgs e)
        {

        }

        private void button_About_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }
    }
}
