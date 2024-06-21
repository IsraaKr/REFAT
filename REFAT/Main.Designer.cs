
namespace REFAT
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button_Main = new System.Windows.Forms.Button();
            this.button_SAlarey = new System.Windows.Forms.Button();
            this.button_Emp = new System.Windows.Forms.Button();
            this.buttonUser = new System.Windows.Forms.Button();
            this.button_report = new System.Windows.Forms.Button();
            this.button_Setting = new System.Windows.Forms.Button();
            this.button_Help = new System.Windows.Forms.Button();
            this.button_About = new System.Windows.Forms.Button();
            this.buttonRetirment = new System.Windows.Forms.Button();
            this.buttonSystemRecord = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.button_Main);
            this.flowLayoutPanel1.Controls.Add(this.button_SAlarey);
            this.flowLayoutPanel1.Controls.Add(this.button_Emp);
            this.flowLayoutPanel1.Controls.Add(this.buttonUser);
            this.flowLayoutPanel1.Controls.Add(this.button_report);
            this.flowLayoutPanel1.Controls.Add(this.button_Setting);
            this.flowLayoutPanel1.Controls.Add(this.button_Help);
            this.flowLayoutPanel1.Controls.Add(this.button_About);
            this.flowLayoutPanel1.Controls.Add(this.buttonRetirment);
            this.flowLayoutPanel1.Controls.Add(this.buttonSystemRecord);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 636);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1370, 85);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // button_Main
            // 
            this.button_Main.Image = ((System.Drawing.Image)(resources.GetObject("button_Main.Image")));
            this.button_Main.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Main.Location = new System.Drawing.Point(1153, 10);
            this.button_Main.Margin = new System.Windows.Forms.Padding(5);
            this.button_Main.Name = "button_Main";
            this.button_Main.Size = new System.Drawing.Size(181, 40);
            this.button_Main.TabIndex = 0;
            this.button_Main.Text = "الرئيسة";
            this.toolTip1.SetToolTip(this.button_Main, "الصفحة الرئيسة");
            this.button_Main.UseVisualStyleBackColor = true;
            this.button_Main.Click += new System.EventHandler(this.button_Main_Click);
            // 
            // button_SAlarey
            // 
            this.button_SAlarey.Image = ((System.Drawing.Image)(resources.GetObject("button_SAlarey.Image")));
            this.button_SAlarey.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_SAlarey.Location = new System.Drawing.Point(962, 10);
            this.button_SAlarey.Margin = new System.Windows.Forms.Padding(5);
            this.button_SAlarey.Name = "button_SAlarey";
            this.button_SAlarey.Size = new System.Drawing.Size(181, 40);
            this.button_SAlarey.TabIndex = 1;
            this.button_SAlarey.Text = "سلم الرواتب";
            this.button_SAlarey.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.button_SAlarey, "إدارة الرواتب");
            this.button_SAlarey.UseVisualStyleBackColor = true;
            this.button_SAlarey.Click += new System.EventHandler(this.button_SAlarey_Click);
            // 
            // button_Emp
            // 
            this.button_Emp.Location = new System.Drawing.Point(771, 10);
            this.button_Emp.Margin = new System.Windows.Forms.Padding(5);
            this.button_Emp.Name = "button_Emp";
            this.button_Emp.Size = new System.Drawing.Size(181, 40);
            this.button_Emp.TabIndex = 2;
            this.button_Emp.Text = "الموظفين";
            this.toolTip1.SetToolTip(this.button_Emp, "إدارة الموظفين");
            this.button_Emp.UseVisualStyleBackColor = true;
            this.button_Emp.Click += new System.EventHandler(this.button_Emp_Click);
            // 
            // buttonUser
            // 
            this.buttonUser.Location = new System.Drawing.Point(580, 10);
            this.buttonUser.Margin = new System.Windows.Forms.Padding(5);
            this.buttonUser.Name = "buttonUser";
            this.buttonUser.Size = new System.Drawing.Size(181, 40);
            this.buttonUser.TabIndex = 3;
            this.buttonUser.Text = "المستخدمين";
            this.toolTip1.SetToolTip(this.buttonUser, "إدارة المستخدمين");
            this.buttonUser.UseVisualStyleBackColor = true;
            this.buttonUser.Click += new System.EventHandler(this.buttonUser_Click);
            // 
            // button_report
            // 
            this.button_report.Location = new System.Drawing.Point(389, 10);
            this.button_report.Margin = new System.Windows.Forms.Padding(5);
            this.button_report.Name = "button_report";
            this.button_report.Size = new System.Drawing.Size(181, 40);
            this.button_report.TabIndex = 4;
            this.button_report.Text = "التقارير";
            this.toolTip1.SetToolTip(this.button_report, "توليد تقارير البرنامج");
            this.button_report.UseVisualStyleBackColor = true;
            this.button_report.Click += new System.EventHandler(this.button_report_Click);
            // 
            // button_Setting
            // 
            this.button_Setting.Location = new System.Drawing.Point(198, 10);
            this.button_Setting.Margin = new System.Windows.Forms.Padding(5);
            this.button_Setting.Name = "button_Setting";
            this.button_Setting.Size = new System.Drawing.Size(181, 40);
            this.button_Setting.TabIndex = 5;
            this.button_Setting.Text = "الإعدادات";
            this.toolTip1.SetToolTip(this.button_Setting, "إعدادت البرنامج");
            this.button_Setting.UseVisualStyleBackColor = true;
            this.button_Setting.Click += new System.EventHandler(this.button_Setting_Click);
            // 
            // button_Help
            // 
            this.button_Help.Location = new System.Drawing.Point(7, 10);
            this.button_Help.Margin = new System.Windows.Forms.Padding(5);
            this.button_Help.Name = "button_Help";
            this.button_Help.Size = new System.Drawing.Size(181, 40);
            this.button_Help.TabIndex = 6;
            this.button_Help.Text = "المساعدة";
            this.toolTip1.SetToolTip(this.button_Help, "فيديوهات تعليمية");
            this.button_Help.UseVisualStyleBackColor = true;
            this.button_Help.Click += new System.EventHandler(this.button_Help_Click);
            // 
            // button_About
            // 
            this.button_About.Location = new System.Drawing.Point(1153, 60);
            this.button_About.Margin = new System.Windows.Forms.Padding(5);
            this.button_About.Name = "button_About";
            this.button_About.Size = new System.Drawing.Size(181, 40);
            this.button_About.TabIndex = 7;
            this.button_About.Text = "حول";
            this.toolTip1.SetToolTip(this.button_About, "حول البرنامج و التحديثات");
            this.button_About.UseVisualStyleBackColor = true;
            this.button_About.Click += new System.EventHandler(this.button_About_Click);
            // 
            // buttonRetirment
            // 
            this.buttonRetirment.Location = new System.Drawing.Point(966, 60);
            this.buttonRetirment.Margin = new System.Windows.Forms.Padding(5);
            this.buttonRetirment.Name = "buttonRetirment";
            this.buttonRetirment.Size = new System.Drawing.Size(181, 40);
            this.buttonRetirment.TabIndex = 8;
            this.buttonRetirment.Text = "المتقاعدين";
            this.buttonRetirment.UseVisualStyleBackColor = true;
            // 
            // buttonSystemRecord
            // 
            this.buttonSystemRecord.Location = new System.Drawing.Point(775, 60);
            this.buttonSystemRecord.Margin = new System.Windows.Forms.Padding(5);
            this.buttonSystemRecord.Name = "buttonSystemRecord";
            this.buttonSystemRecord.Size = new System.Drawing.Size(181, 40);
            this.buttonSystemRecord.TabIndex = 9;
            this.buttonSystemRecord.Text = "سجل النظام";
            this.buttonSystemRecord.UseVisualStyleBackColor = true;
            // 

            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.BackColor = System.Drawing.Color.White;
            this.panelContainer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panelContainer.Size = new System.Drawing.Size(1370, 636);
            this.panelContainer.TabIndex = 1;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 721);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REFAT";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button_Main;
        private System.Windows.Forms.Button button_SAlarey;
        private System.Windows.Forms.Button button_Emp;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button buttonUser;
        private System.Windows.Forms.Button button_report;
        private System.Windows.Forms.Button button_Setting;
        private System.Windows.Forms.Button button_Help;
        private System.Windows.Forms.Button button_About;
        private System.Windows.Forms.Button buttonRetirment;
        private System.Windows.Forms.Button buttonSystemRecord;
        public System.Windows.Forms.Panel panelContainer;
    }
}