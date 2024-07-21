namespace REFAT.GUI.UsersGui
{
    partial class Add_User_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_Save = new System.Windows.Forms.Button();
            this.comboBox_UsersId = new System.Windows.Forms.ComboBox();
            this.checkBoxSeconderyUser = new System.Windows.Forms.CheckBox();
            this.textBox_Adress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Phone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox_Role = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_PassWord = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_UserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFull_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel_Roles = new System.Windows.Forms.FlowLayoutPanel();
            this.checkBox_Add = new System.Windows.Forms.CheckBox();
            this.checkBox_delete = new System.Windows.Forms.CheckBox();
            this.checkBox_Edite = new System.Windows.Forms.CheckBox();
            this.checkBox_Export = new System.Windows.Forms.CheckBox();
            this.checkBox_Print = new System.Windows.Forms.CheckBox();
            this.checkBox_Search = new System.Windows.Forms.CheckBox();
            this.checkBox_MainSearch = new System.Windows.Forms.CheckBox();
            this.checkBox_Main = new System.Windows.Forms.CheckBox();
            this.checkBox_Salarey = new System.Windows.Forms.CheckBox();
            this.checkBox_Emp = new System.Windows.Forms.CheckBox();
            this.checkBox_User = new System.Windows.Forms.CheckBox();
            this.checkBox_Report = new System.Windows.Forms.CheckBox();
            this.checkBox_Setting = new System.Windows.Forms.CheckBox();
            this.checkBox_About = new System.Windows.Forms.CheckBox();
            this.checkBox_Help = new System.Windows.Forms.CheckBox();
            this.checkBox_Retierment = new System.Windows.Forms.CheckBox();
            this.checkBox_SystemRecord = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.flowLayoutPanel_Roles.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_Save);
            this.groupBox1.Controls.Add(this.comboBox_UsersId);
            this.groupBox1.Controls.Add(this.checkBoxSeconderyUser);
            this.groupBox1.Controls.Add(this.textBox_Adress);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox_Email);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox_Phone);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(372, 369);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "المعلومات الإضافية";
            // 
            // button_Save
            // 
            this.button_Save.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_Save.Location = new System.Drawing.Point(7, 318);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(356, 41);
            this.button_Save.TabIndex = 10;
            this.button_Save.Text = "حفظ";
            this.button_Save.UseVisualStyleBackColor = false;
            this.button_Save.Click += new System.EventHandler(this.button_Save_ClickAsync);
            // 
            // comboBox_UsersId
            // 
            this.comboBox_UsersId.Enabled = false;
            this.comboBox_UsersId.FormattingEnabled = true;
            this.comboBox_UsersId.Location = new System.Drawing.Point(6, 62);
            this.comboBox_UsersId.Name = "comboBox_UsersId";
            this.comboBox_UsersId.Size = new System.Drawing.Size(357, 32);
            this.comboBox_UsersId.TabIndex = 6;
            // 
            // checkBoxSeconderyUser
            // 
            this.checkBoxSeconderyUser.AutoSize = true;
            this.checkBoxSeconderyUser.Location = new System.Drawing.Point(158, 24);
            this.checkBoxSeconderyUser.Name = "checkBoxSeconderyUser";
            this.checkBoxSeconderyUser.Size = new System.Drawing.Size(203, 28);
            this.checkBoxSeconderyUser.TabIndex = 5;
            this.checkBoxSeconderyUser.Text = "هل المستخدم ثانوي";
            this.checkBoxSeconderyUser.UseVisualStyleBackColor = true;
            this.checkBoxSeconderyUser.CheckedChanged += new System.EventHandler(this.checkBoxSeconderyUser_CheckedChanged);
            // 
            // textBox_Adress
            // 
            this.textBox_Adress.Location = new System.Drawing.Point(5, 280);
            this.textBox_Adress.Name = "textBox_Adress";
            this.textBox_Adress.Size = new System.Drawing.Size(359, 32);
            this.textBox_Adress.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(299, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "العنوان:";
            // 
            // textBox_Email
            // 
            this.textBox_Email.Location = new System.Drawing.Point(6, 206);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(359, 32);
            this.textBox_Email.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(291, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "الايميل:";
            // 
            // textBox_Phone
            // 
            this.textBox_Phone.Location = new System.Drawing.Point(6, 129);
            this.textBox_Phone.Name = "textBox_Phone";
            this.textBox_Phone.Size = new System.Drawing.Size(359, 32);
            this.textBox_Phone.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(296, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "الهاتف:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox_Role);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textBox_PassWord);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBox_UserName);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBoxFull_name);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(391, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(372, 369);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "معلومات الدخول";
            // 
            // comboBox_Role
            // 
            this.comboBox_Role.FormattingEnabled = true;
            this.comboBox_Role.Location = new System.Drawing.Point(9, 280);
            this.comboBox_Role.Name = "comboBox_Role";
            this.comboBox_Role.Size = new System.Drawing.Size(357, 32);
            this.comboBox_Role.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(228, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 24);
            this.label7.TabIndex = 0;
            this.label7.Text = "الصلاحية العامة:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(235, 179);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 24);
            this.label10.TabIndex = 2;
            this.label10.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(194, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 24);
            this.label9.TabIndex = 2;
            this.label9.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(221, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 24);
            this.label8.TabIndex = 2;
            this.label8.Text = "*";
            // 
            // textBox_PassWord
            // 
            this.textBox_PassWord.Location = new System.Drawing.Point(11, 206);
            this.textBox_PassWord.Name = "textBox_PassWord";
            this.textBox_PassWord.Size = new System.Drawing.Size(359, 32);
            this.textBox_PassWord.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(262, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "كلمة المرور:";
            // 
            // textBox_UserName
            // 
            this.textBox_UserName.Location = new System.Drawing.Point(12, 129);
            this.textBox_UserName.Name = "textBox_UserName";
            this.textBox_UserName.Size = new System.Drawing.Size(359, 32);
            this.textBox_UserName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "اسم المستخدم:";
            // 
            // textBoxFull_name
            // 
            this.textBoxFull_name.Location = new System.Drawing.Point(6, 56);
            this.textBoxFull_name.Name = "textBoxFull_name";
            this.textBoxFull_name.Size = new System.Drawing.Size(359, 32);
            this.textBoxFull_name.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(245, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "الاسم الكامل:";
            // 
            // flowLayoutPanel_Roles
            // 
            this.flowLayoutPanel_Roles.AutoScroll = true;
            this.flowLayoutPanel_Roles.Controls.Add(this.checkBox_Add);
            this.flowLayoutPanel_Roles.Controls.Add(this.checkBox_delete);
            this.flowLayoutPanel_Roles.Controls.Add(this.checkBox_Edite);
            this.flowLayoutPanel_Roles.Controls.Add(this.checkBox_Export);
            this.flowLayoutPanel_Roles.Controls.Add(this.checkBox_Print);
            this.flowLayoutPanel_Roles.Controls.Add(this.checkBox_Search);
            this.flowLayoutPanel_Roles.Controls.Add(this.checkBox_MainSearch);
            this.flowLayoutPanel_Roles.Controls.Add(this.checkBox_Main);
            this.flowLayoutPanel_Roles.Controls.Add(this.checkBox_Salarey);
            this.flowLayoutPanel_Roles.Controls.Add(this.checkBox_Emp);
            this.flowLayoutPanel_Roles.Controls.Add(this.checkBox_User);
            this.flowLayoutPanel_Roles.Controls.Add(this.checkBox_Report);
            this.flowLayoutPanel_Roles.Controls.Add(this.checkBox_Setting);
            this.flowLayoutPanel_Roles.Controls.Add(this.checkBox_About);
            this.flowLayoutPanel_Roles.Controls.Add(this.checkBox_Help);
            this.flowLayoutPanel_Roles.Controls.Add(this.checkBox_Retierment);
            this.flowLayoutPanel_Roles.Controls.Add(this.checkBox_SystemRecord);
            this.flowLayoutPanel_Roles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel_Roles.Location = new System.Drawing.Point(3, 28);
            this.flowLayoutPanel_Roles.Name = "flowLayoutPanel_Roles";
            this.flowLayoutPanel_Roles.Padding = new System.Windows.Forms.Padding(3);
            this.flowLayoutPanel_Roles.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowLayoutPanel_Roles.Size = new System.Drawing.Size(743, 117);
            this.flowLayoutPanel_Roles.TabIndex = 1;
            // 
            // checkBox_Add
            // 
            this.checkBox_Add.AutoSize = true;
            this.checkBox_Add.Checked = true;
            this.checkBox_Add.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_Add.Location = new System.Drawing.Point(636, 6);
            this.checkBox_Add.Name = "checkBox_Add";
            this.checkBox_Add.Size = new System.Drawing.Size(77, 28);
            this.checkBox_Add.TabIndex = 2;
            this.checkBox_Add.Text = "إضافة";
            this.checkBox_Add.UseVisualStyleBackColor = true;
            // 
            // checkBox_delete
            // 
            this.checkBox_delete.AutoSize = true;
            this.checkBox_delete.Checked = true;
            this.checkBox_delete.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_delete.Location = new System.Drawing.Point(557, 6);
            this.checkBox_delete.Name = "checkBox_delete";
            this.checkBox_delete.Size = new System.Drawing.Size(73, 28);
            this.checkBox_delete.TabIndex = 2;
            this.checkBox_delete.Text = "حذف";
            this.checkBox_delete.UseVisualStyleBackColor = true;
            // 
            // checkBox_Edite
            // 
            this.checkBox_Edite.AutoSize = true;
            this.checkBox_Edite.Checked = true;
            this.checkBox_Edite.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_Edite.Location = new System.Drawing.Point(472, 6);
            this.checkBox_Edite.Name = "checkBox_Edite";
            this.checkBox_Edite.Size = new System.Drawing.Size(79, 28);
            this.checkBox_Edite.TabIndex = 2;
            this.checkBox_Edite.Text = "تعديل";
            this.checkBox_Edite.UseVisualStyleBackColor = true;
            // 
            // checkBox_Export
            // 
            this.checkBox_Export.AutoSize = true;
            this.checkBox_Export.Checked = true;
            this.checkBox_Export.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_Export.Location = new System.Drawing.Point(388, 6);
            this.checkBox_Export.Name = "checkBox_Export";
            this.checkBox_Export.Size = new System.Drawing.Size(78, 28);
            this.checkBox_Export.TabIndex = 2;
            this.checkBox_Export.Text = "تصدير";
            this.checkBox_Export.UseVisualStyleBackColor = true;
            // 
            // checkBox_Print
            // 
            this.checkBox_Print.AutoSize = true;
            this.checkBox_Print.Checked = true;
            this.checkBox_Print.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_Print.Location = new System.Drawing.Point(301, 6);
            this.checkBox_Print.Name = "checkBox_Print";
            this.checkBox_Print.Size = new System.Drawing.Size(81, 28);
            this.checkBox_Print.TabIndex = 2;
            this.checkBox_Print.Text = "طباعة";
            this.checkBox_Print.UseVisualStyleBackColor = true;
            // 
            // checkBox_Search
            // 
            this.checkBox_Search.AutoSize = true;
            this.checkBox_Search.Checked = true;
            this.checkBox_Search.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_Search.Location = new System.Drawing.Point(224, 6);
            this.checkBox_Search.Name = "checkBox_Search";
            this.checkBox_Search.Size = new System.Drawing.Size(71, 28);
            this.checkBox_Search.TabIndex = 2;
            this.checkBox_Search.Text = "بحث";
            this.checkBox_Search.UseVisualStyleBackColor = true;
            // 
            // checkBox_MainSearch
            // 
            this.checkBox_MainSearch.AutoSize = true;
            this.checkBox_MainSearch.Checked = true;
            this.checkBox_MainSearch.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_MainSearch.Location = new System.Drawing.Point(452, 40);
            this.checkBox_MainSearch.Name = "checkBox_MainSearch";
            this.checkBox_MainSearch.Size = new System.Drawing.Size(261, 28);
            this.checkBox_MainSearch.TabIndex = 3;
            this.checkBox_MainSearch.Text = "البحث في الصفحة الرئيسية";
            this.checkBox_MainSearch.UseVisualStyleBackColor = true;
            // 
            // checkBox_Main
            // 
            this.checkBox_Main.AutoSize = true;
            this.checkBox_Main.Checked = true;
            this.checkBox_Main.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_Main.Location = new System.Drawing.Point(276, 40);
            this.checkBox_Main.Name = "checkBox_Main";
            this.checkBox_Main.Size = new System.Drawing.Size(170, 28);
            this.checkBox_Main.TabIndex = 2;
            this.checkBox_Main.Text = "الصفحة الرئيسية";
            this.checkBox_Main.UseVisualStyleBackColor = true;
            // 
            // checkBox_Salarey
            // 
            this.checkBox_Salarey.AutoSize = true;
            this.checkBox_Salarey.Checked = true;
            this.checkBox_Salarey.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_Salarey.Location = new System.Drawing.Point(134, 40);
            this.checkBox_Salarey.Name = "checkBox_Salarey";
            this.checkBox_Salarey.Size = new System.Drawing.Size(136, 28);
            this.checkBox_Salarey.TabIndex = 2;
            this.checkBox_Salarey.Text = "سلم الرواتب";
            this.checkBox_Salarey.UseVisualStyleBackColor = true;
            // 
            // checkBox_Emp
            // 
            this.checkBox_Emp.AutoSize = true;
            this.checkBox_Emp.Checked = true;
            this.checkBox_Emp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_Emp.Location = new System.Drawing.Point(19, 40);
            this.checkBox_Emp.Name = "checkBox_Emp";
            this.checkBox_Emp.Size = new System.Drawing.Size(109, 28);
            this.checkBox_Emp.TabIndex = 4;
            this.checkBox_Emp.Text = "الموظفين";
            this.checkBox_Emp.UseVisualStyleBackColor = true;
            // 
            // checkBox_User
            // 
            this.checkBox_User.AutoSize = true;
            this.checkBox_User.Checked = true;
            this.checkBox_User.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_User.Location = new System.Drawing.Point(573, 74);
            this.checkBox_User.Name = "checkBox_User";
            this.checkBox_User.Size = new System.Drawing.Size(140, 28);
            this.checkBox_User.TabIndex = 2;
            this.checkBox_User.Text = "المستخدمين";
            this.checkBox_User.UseVisualStyleBackColor = true;
            // 
            // checkBox_Report
            // 
            this.checkBox_Report.AutoSize = true;
            this.checkBox_Report.Checked = true;
            this.checkBox_Report.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_Report.Location = new System.Drawing.Point(480, 74);
            this.checkBox_Report.Name = "checkBox_Report";
            this.checkBox_Report.Size = new System.Drawing.Size(87, 28);
            this.checkBox_Report.TabIndex = 2;
            this.checkBox_Report.Text = "التقارير";
            this.checkBox_Report.UseVisualStyleBackColor = true;
            // 
            // checkBox_Setting
            // 
            this.checkBox_Setting.AutoSize = true;
            this.checkBox_Setting.Checked = true;
            this.checkBox_Setting.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_Setting.Location = new System.Drawing.Point(367, 74);
            this.checkBox_Setting.Name = "checkBox_Setting";
            this.checkBox_Setting.Size = new System.Drawing.Size(107, 28);
            this.checkBox_Setting.TabIndex = 2;
            this.checkBox_Setting.Text = "الإعدادات";
            this.checkBox_Setting.UseVisualStyleBackColor = true;
            // 
            // checkBox_About
            // 
            this.checkBox_About.AutoSize = true;
            this.checkBox_About.Checked = true;
            this.checkBox_About.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_About.Location = new System.Drawing.Point(238, 74);
            this.checkBox_About.Name = "checkBox_About";
            this.checkBox_About.Size = new System.Drawing.Size(123, 28);
            this.checkBox_About.TabIndex = 2;
            this.checkBox_About.Text = "حول النظام";
            this.checkBox_About.UseVisualStyleBackColor = true;
            // 
            // checkBox_Help
            // 
            this.checkBox_Help.AutoSize = true;
            this.checkBox_Help.Checked = true;
            this.checkBox_Help.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_Help.Location = new System.Drawing.Point(118, 74);
            this.checkBox_Help.Name = "checkBox_Help";
            this.checkBox_Help.Size = new System.Drawing.Size(114, 28);
            this.checkBox_Help.TabIndex = 2;
            this.checkBox_Help.Text = "المساعدة";
            this.checkBox_Help.UseVisualStyleBackColor = true;
            // 
            // checkBox_Retierment
            // 
            this.checkBox_Retierment.AutoSize = true;
            this.checkBox_Retierment.Checked = true;
            this.checkBox_Retierment.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_Retierment.Location = new System.Drawing.Point(591, 108);
            this.checkBox_Retierment.Name = "checkBox_Retierment";
            this.checkBox_Retierment.Size = new System.Drawing.Size(122, 28);
            this.checkBox_Retierment.TabIndex = 5;
            this.checkBox_Retierment.Text = "المتقاعدين";
            this.checkBox_Retierment.UseVisualStyleBackColor = true;
            // 
            // checkBox_SystemRecord
            // 
            this.checkBox_SystemRecord.AutoSize = true;
            this.checkBox_SystemRecord.Checked = true;
            this.checkBox_SystemRecord.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_SystemRecord.Location = new System.Drawing.Point(449, 108);
            this.checkBox_SystemRecord.Name = "checkBox_SystemRecord";
            this.checkBox_SystemRecord.Size = new System.Drawing.Size(136, 28);
            this.checkBox_SystemRecord.TabIndex = 6;
            this.checkBox_SystemRecord.Text = "سجل النظام";
            this.checkBox_SystemRecord.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.flowLayoutPanel_Roles);
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(13, 388);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox3.Size = new System.Drawing.Size(749, 148);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "الصلاحيات:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label12.Location = new System.Drawing.Point(75, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(137, 19);
            this.label12.TabIndex = 5;
            this.label12.Text = "أقل ادخال 3 محارف";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label11.Location = new System.Drawing.Point(51, 101);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(137, 19);
            this.label11.TabIndex = 6;
            this.label11.Text = "أقل ادخال 3 محارف";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label13.Location = new System.Drawing.Point(92, 178);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(137, 19);
            this.label13.TabIndex = 7;
            this.label13.Text = "أقل ادخال 3 محارف";
            // 
            // Add_User_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 540);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Add_User_Form";
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إضافة \\ تعديل المستخدمين";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.flowLayoutPanel_Roles.ResumeLayout(false);
            this.flowLayoutPanel_Roles.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_Roles;
        private System.Windows.Forms.TextBox textBox_Adress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_Phone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_PassWord;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_UserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxFull_name;
        private System.Windows.Forms.ComboBox comboBox_UsersId;
        private System.Windows.Forms.CheckBox checkBoxSeconderyUser;
        private System.Windows.Forms.CheckBox checkBox_Add;
        private System.Windows.Forms.CheckBox checkBox_Edite;
        private System.Windows.Forms.CheckBox checkBox_delete;
        private System.Windows.Forms.CheckBox checkBox_Search;
        private System.Windows.Forms.CheckBox checkBox_Report;
        private System.Windows.Forms.CheckBox checkBox_Print;
        private System.Windows.Forms.CheckBox checkBox_Export;
        private System.Windows.Forms.CheckBox checkBox_Main;
        private System.Windows.Forms.CheckBox checkBox_Salarey;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBox_Role;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBox_User;
        private System.Windows.Forms.CheckBox checkBox_Help;
        private System.Windows.Forms.CheckBox checkBox_Setting;
        private System.Windows.Forms.CheckBox checkBox_About;
        private System.Windows.Forms.CheckBox checkBox_MainSearch;
        private System.Windows.Forms.CheckBox checkBox_Emp;
        private System.Windows.Forms.CheckBox checkBox_Retierment;
        private System.Windows.Forms.CheckBox checkBox_SystemRecord;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }


}

