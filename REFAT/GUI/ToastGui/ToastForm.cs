using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace REFAT.GUI.ToastGui
{
    public partial class ToastForm : Form
    {
        private static ToastForm? toastForm;
        public static string     Title;
        public static string Description;
        public ToastForm()
        {
            //لانو في هايد ماعاد يستدعي المسيد مرة تانية بس اول تشغيل
            InitializeComponent();
           
        }

        public static ToastForm Instance( string tiltle , string desecription)
        {

            Title = tiltle;
            Description = desecription;
            return toastForm ?? (new ToastForm());
        }

        private void timerToaste_Tick(object sender, EventArgs e)
        {
            this.Hide();//حتى ما ينشئ اشعار جديد كل مرة
            timerToaste.Enabled = false;
        }
        private void ToastForm_Activated(object sender, EventArgs e)
        {
            timerToaste.Interval = Properties.Settings.Default.ToastDuration;
            labelTitle.Text = Title;
            labelDescription.Text = Title;
            timerToaste.Enabled = true;

        }
    }
}
