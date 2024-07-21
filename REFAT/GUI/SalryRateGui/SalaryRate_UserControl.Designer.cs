namespace REFAT.GUI.SalryRateGui
{
    
    partial class SalaryRate_UserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalaryRate_UserControl));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Edit = new System.Windows.Forms.Button();
            this.button_Delet = new System.Windows.Forms.Button();
            this.button_Export_All = new System.Windows.Forms.Button();
            this.button_Export_dgv = new System.Windows.Forms.Button();
            this.textBox_Search = new System.Windows.Forms.TextBox();
            this.button_Search = new System.Windows.Forms.Button();
            this.button_next = new System.Windows.Forms.Button();
            this.button_prevew = new System.Windows.Forms.Button();
            this.comboBox_noOfPage = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.labelstateDesecreption = new System.Windows.Forms.Label();
            this.panelState = new System.Windows.Forms.FlowLayoutPanel();
            this.labelStatTitel = new System.Windows.Forms.Label();
            this.panel_Pages = new System.Windows.Forms.Panel();
            this.labelAllNo = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.panelState.SuspendLayout();
            this.panel_Pages.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRefresh.Location = new System.Drawing.Point(723, 343);
            this.buttonRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(90, 35);
            this.buttonRefresh.TabIndex = 0;
            this.buttonRefresh.Text = "تحديث";
            this.toolTip1.SetToolTip(this.buttonRefresh, "إعادة تحميل البيانات");
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // button_Add
            // 
            this.button_Add.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_Add.Image = ((System.Drawing.Image)(resources.GetObject("button_Add.Image")));
            this.button_Add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Add.Location = new System.Drawing.Point(723, 4);
            this.button_Add.Margin = new System.Windows.Forms.Padding(2);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(90, 40);
            this.button_Add.TabIndex = 0;
            this.button_Add.Text = "إضافة";
            this.button_Add.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.button_Add, "إضافة البيانات");
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_Edit
            // 
            this.button_Edit.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_Edit.Image = ((System.Drawing.Image)(resources.GetObject("button_Edit.Image")));
            this.button_Edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Edit.Location = new System.Drawing.Point(629, 4);
            this.button_Edit.Margin = new System.Windows.Forms.Padding(2);
            this.button_Edit.Name = "button_Edit";
            this.button_Edit.Size = new System.Drawing.Size(90, 40);
            this.button_Edit.TabIndex = 0;
            this.button_Edit.Text = "تعديل";
            this.button_Edit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.button_Edit, "تعديل السطر الحالي");
            this.button_Edit.UseVisualStyleBackColor = true;
            this.button_Edit.Click += new System.EventHandler(this.button_Edit_Click);
            // 
            // button_Delet
            // 
            this.button_Delet.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_Delet.Image = ((System.Drawing.Image)(resources.GetObject("button_Delet.Image")));
            this.button_Delet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Delet.Location = new System.Drawing.Point(535, 4);
            this.button_Delet.Margin = new System.Windows.Forms.Padding(2);
            this.button_Delet.Name = "button_Delet";
            this.button_Delet.Size = new System.Drawing.Size(90, 40);
            this.button_Delet.TabIndex = 0;
            this.button_Delet.Text = "حذف";
            this.button_Delet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.button_Delet, "حذف البيانات و يمكن حذف أكثر من سطر معا");
            this.button_Delet.UseVisualStyleBackColor = true;
            this.button_Delet.Click += new System.EventHandler(this.button_Delet_ClickAsync);
            // 
            // button_Export_All
            // 
            this.button_Export_All.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_Export_All.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Export_All.Location = new System.Drawing.Point(441, 4);
            this.button_Export_All.Margin = new System.Windows.Forms.Padding(2);
            this.button_Export_All.Name = "button_Export_All";
            this.button_Export_All.Size = new System.Drawing.Size(90, 40);
            this.button_Export_All.TabIndex = 0;
            this.button_Export_All.Text = "الكل";
            this.button_Export_All.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.button_Export_All, "تصدير كامل البيانات");
            this.button_Export_All.UseVisualStyleBackColor = true;
            this.button_Export_All.Click += new System.EventHandler(this.button_Export_All_Click);
            // 
            // button_Export_dgv
            // 
            this.button_Export_dgv.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_Export_dgv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Export_dgv.Location = new System.Drawing.Point(347, 4);
            this.button_Export_dgv.Margin = new System.Windows.Forms.Padding(2);
            this.button_Export_dgv.Name = "button_Export_dgv";
            this.button_Export_dgv.Size = new System.Drawing.Size(90, 40);
            this.button_Export_dgv.TabIndex = 2;
            this.button_Export_dgv.Text = "الشبكة";
            this.button_Export_dgv.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.button_Export_dgv, "تصدير بيانات الشبكة فقط ");
            this.button_Export_dgv.UseVisualStyleBackColor = true;
            this.button_Export_dgv.Click += new System.EventHandler(this.button_Export_dgv_Click);
            // 
            // textBox_Search
            // 
            this.textBox_Search.Location = new System.Drawing.Point(49, 7);
            this.textBox_Search.Margin = new System.Windows.Forms.Padding(5);
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.Size = new System.Drawing.Size(224, 32);
            this.textBox_Search.TabIndex = 1;
            this.textBox_Search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.textBox_Search, "اكتب عبارة بحث أو اضغط بحث بشكل مياشر");
            // 
            // button_Search
            // 
            this.button_Search.Image = ((System.Drawing.Image)(resources.GetObject("button_Search.Image")));
            this.button_Search.Location = new System.Drawing.Point(3, 3);
            this.button_Search.Margin = new System.Windows.Forms.Padding(2);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(45, 35);
            this.button_Search.TabIndex = 0;
            this.toolTip1.SetToolTip(this.button_Search, "اكتب عبارة بحث أو اضغط بحث بشكل مياشر");
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // button_next
            // 
            this.button_next.Location = new System.Drawing.Point(115, 0);
            this.button_next.Margin = new System.Windows.Forms.Padding(2);
            this.button_next.Name = "button_next";
            this.button_next.Size = new System.Drawing.Size(39, 32);
            this.button_next.TabIndex = 5;
            this.button_next.Text = ">";
            this.toolTip1.SetToolTip(this.button_next, "الصفحة التالية");
            this.button_next.UseVisualStyleBackColor = true;
            // 
            // button_prevew
            // 
            this.button_prevew.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_prevew.Location = new System.Drawing.Point(0, 0);
            this.button_prevew.Margin = new System.Windows.Forms.Padding(2);
            this.button_prevew.Name = "button_prevew";
            this.button_prevew.Size = new System.Drawing.Size(39, 32);
            this.button_prevew.TabIndex = 6;
            this.button_prevew.Text = "<";
            this.toolTip1.SetToolTip(this.button_prevew, "الصفحة السابقة");
            this.button_prevew.UseVisualStyleBackColor = true;
            // 
            // comboBox_noOfPage
            // 
            this.comboBox_noOfPage.Cursor = System.Windows.Forms.Cursors.Cross;
            this.comboBox_noOfPage.FormattingEnabled = true;
            this.comboBox_noOfPage.Location = new System.Drawing.Point(39, 0);
            this.comboBox_noOfPage.Name = "comboBox_noOfPage";
            this.comboBox_noOfPage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBox_noOfPage.Size = new System.Drawing.Size(81, 28);
            this.comboBox_noOfPage.TabIndex = 7;
            this.toolTip1.SetToolTip(this.comboBox_noOfPage, "عدد الصفحات الكلي");
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.button_Add);
            this.flowLayoutPanel1.Controls.Add(this.button_Edit);
            this.flowLayoutPanel1.Controls.Add(this.button_Delet);
            this.flowLayoutPanel1.Controls.Add(this.button_Export_All);
            this.flowLayoutPanel1.Controls.Add(this.button_Export_dgv);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowLayoutPanel1.Size = new System.Drawing.Size(819, 50);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox_Search);
            this.panel1.Controls.Add(this.button_Search);
            this.panel1.Location = new System.Drawing.Point(67, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 40);
            this.panel1.TabIndex = 1;
            // 
            // dgv
            // 
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv.BackgroundColor = System.Drawing.Color.White;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.EnableHeadersVisualStyles = false;
            this.dgv.Location = new System.Drawing.Point(0, 50);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.Size = new System.Drawing.Size(819, 337);
            this.dgv.TabIndex = 1;
            this.dgv.Text = "dataGridView1";
            // 
            // labelstateDesecreption
            // 
            this.labelstateDesecreption.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelstateDesecreption.BackColor = System.Drawing.Color.White;
            this.labelstateDesecreption.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelstateDesecreption.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelstateDesecreption.Location = new System.Drawing.Point(3, 36);
            this.labelstateDesecreption.Name = "labelstateDesecreption";
            this.labelstateDesecreption.Size = new System.Drawing.Size(443, 48);
            this.labelstateDesecreption.TabIndex = 2;
            this.labelstateDesecreption.Text = ".......";
            this.labelstateDesecreption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelState
            // 
            this.panelState.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelState.BackColor = System.Drawing.Color.White;
            this.panelState.Controls.Add(this.labelStatTitel);
            this.panelState.Controls.Add(this.labelstateDesecreption);
            this.panelState.Location = new System.Drawing.Point(186, 122);
            this.panelState.Name = "panelState";
            this.panelState.Size = new System.Drawing.Size(446, 142);
            this.panelState.TabIndex = 3;
            this.panelState.Visible = false;
            // 
            // labelStatTitel
            // 
            this.labelStatTitel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelStatTitel.BackColor = System.Drawing.Color.White;
            this.labelStatTitel.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelStatTitel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelStatTitel.Location = new System.Drawing.Point(3, 0);
            this.labelStatTitel.Name = "labelStatTitel";
            this.labelStatTitel.Size = new System.Drawing.Size(443, 36);
            this.labelStatTitel.TabIndex = 2;
            this.labelStatTitel.Text = "لا يوجد بيانات";
            this.labelStatTitel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_Pages
            // 
            this.panel_Pages.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel_Pages.BackColor = System.Drawing.Color.White;
            this.panel_Pages.Controls.Add(this.button_prevew);
            this.panel_Pages.Controls.Add(this.labelAllNo);
            this.panel_Pages.Controls.Add(this.comboBox_noOfPage);
            this.panel_Pages.Controls.Add(this.button_next);
            this.panel_Pages.Location = new System.Drawing.Point(12, 363);
            this.panel_Pages.Name = "panel_Pages";
            this.panel_Pages.Size = new System.Drawing.Size(235, 32);
            this.panel_Pages.TabIndex = 4;
            // 
            // labelAllNo
            // 
            this.labelAllNo.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelAllNo.ForeColor = System.Drawing.Color.IndianRed;
            this.labelAllNo.Location = new System.Drawing.Point(159, 0);
            this.labelAllNo.Name = "labelAllNo";
            this.labelAllNo.Size = new System.Drawing.Size(76, 32);
            this.labelAllNo.TabIndex = 8;
            this.labelAllNo.Text = "...";
            this.labelAllNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SalaryRate_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.panelState);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SalaryRate_UserControl";
            this.Size = new System.Drawing.Size(819, 387);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.panelState.ResumeLayout(false);
            this.panel_Pages.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion


        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_Edit;
        private System.Windows.Forms.Button button_Delet;
        private System.Windows.Forms.Button button_Export_All;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox_Search;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label labelstateDesecreption;
        private System.Windows.Forms.FlowLayoutPanel panelState;
        private System.Windows.Forms.Label labelStatTitel;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button button_Export_dgv;
        private System.Windows.Forms.Panel panel_Pages;
        private System.Windows.Forms.ComboBox comboBox_noOfPage;
        private System.Windows.Forms.Button button_prevew;
        private System.Windows.Forms.Button button_next;
        private System.Windows.Forms.Label labelAllNo;


    }
}
