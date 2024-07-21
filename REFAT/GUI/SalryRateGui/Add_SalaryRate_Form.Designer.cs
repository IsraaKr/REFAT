namespace REFAT.GUI.SalryRateGui
{
    partial class Add_SalaryRate_Form
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
            this.button_Save = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_BonasYear = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Salary = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.numericUpDown_Degree = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Promption = new System.Windows.Forms.NumericUpDown();
            this.labelSalary = new System.Windows.Forms.Label();
            this.labelBonas = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Degree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Promption)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Save
            // 
            this.button_Save.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_Save.Location = new System.Drawing.Point(12, 340);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(344, 41);
            this.button_Save.TabIndex = 5;
            this.button_Save.Text = "حفظ";
            this.button_Save.UseVisualStyleBackColor = false;
            this.button_Save.Click += new System.EventHandler(this.button_Save_ClickAsync);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelBonas);
            this.groupBox2.Controls.Add(this.labelSalary);
            this.groupBox2.Controls.Add(this.numericUpDown_Promption);
            this.groupBox2.Controls.Add(this.numericUpDown_Degree);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textBox_BonasYear);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBox_Salary);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(7, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(360, 322);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "معلومات الدخول";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(209, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "عدد سنوات الترفيع :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(215, 173);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 19);
            this.label10.TabIndex = 2;
            this.label10.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(215, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 19);
            this.label9.TabIndex = 2;
            this.label9.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(266, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 19);
            this.label8.TabIndex = 2;
            this.label8.Text = "*";
            // 
            // textBox_BonasYear
            // 
            this.textBox_BonasYear.Location = new System.Drawing.Point(23, 206);
            this.textBox_BonasYear.Name = "textBox_BonasYear";
            this.textBox_BonasYear.Size = new System.Drawing.Size(321, 27);
            this.textBox_BonasYear.TabIndex = 3;
            this.textBox_BonasYear.Text = "0";
            this.textBox_BonasYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_BonasYear.MouseLeave += new System.EventHandler(this.textBox_BonasYear_MouseLeave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(239, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "العلاوة السنوية:";
            // 
            // textBox_Salary
            // 
            this.textBox_Salary.Location = new System.Drawing.Point(24, 129);
            this.textBox_Salary.Name = "textBox_Salary";
            this.textBox_Salary.Size = new System.Drawing.Size(320, 27);
            this.textBox_Salary.TabIndex = 2;
            this.textBox_Salary.Text = "0";
            this.textBox_Salary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_Salary.MouseLeave += new System.EventHandler(this.textBox_Salary_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "الراتب الأسمي:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(290, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "الدرجة :";
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
            // numericUpDown_Degree
            // 
            this.numericUpDown_Degree.Location = new System.Drawing.Point(23, 56);
            this.numericUpDown_Degree.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_Degree.Name = "numericUpDown_Degree";
            this.numericUpDown_Degree.Size = new System.Drawing.Size(321, 27);
            this.numericUpDown_Degree.TabIndex = 1;
            this.numericUpDown_Degree.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown_Degree.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown_Promption
            // 
            this.numericUpDown_Promption.Location = new System.Drawing.Point(24, 278);
            this.numericUpDown_Promption.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_Promption.Name = "numericUpDown_Promption";
            this.numericUpDown_Promption.Size = new System.Drawing.Size(321, 27);
            this.numericUpDown_Promption.TabIndex = 4;
            this.numericUpDown_Promption.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown_Promption.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelSalary
            // 
            this.labelSalary.AutoSize = true;
            this.labelSalary.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.labelSalary.Location = new System.Drawing.Point(24, 96);
            this.labelSalary.Name = "labelSalary";
            this.labelSalary.Size = new System.Drawing.Size(31, 19);
            this.labelSalary.TabIndex = 7;
            this.labelSalary.Text = "د.ع";
            // 
            // labelBonas
            // 
            this.labelBonas.AutoSize = true;
            this.labelBonas.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.labelBonas.Location = new System.Drawing.Point(24, 173);
            this.labelBonas.Name = "labelBonas";
            this.labelBonas.Size = new System.Drawing.Size(31, 19);
            this.labelBonas.TabIndex = 8;
            this.labelBonas.Text = "د.ع";
            // 
            // Add_SalaryRate_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 405);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Tahoma", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Add_SalaryRate_Form";
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إضافة \\ تعديل درجات";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Degree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Promption)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_BonasYear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Salary;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown numericUpDown_Promption;
        private System.Windows.Forms.NumericUpDown numericUpDown_Degree;
        private System.Windows.Forms.Label labelBonas;
        private System.Windows.Forms.Label labelSalary;
    }


}