using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace REFAT.GUI.LoadingGui
{// لأن اللودينغ نفسها على مستوى البروجكت نستخدم سينغلتون
    public partial class LoadingForm : Form
    {
        private static LoadingForm? loadinForm;
        private static Main _main;
        public LoadingForm()
        {
            InitializeComponent();
            this.Owner = _main;
        }
        public static LoadingForm Instance(Main main)
        {
            _main = main;
            return loadinForm ?? (loadinForm = new LoadingForm());
        }
    }
}
