using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace REFAT.GUI.HomeGui
{
    public partial class Home_UserControl : UserControl
    {
        //singelton
        private static  Home_UserControl? home_UserControl;
        public Home_UserControl()
        {
            InitializeComponent();
        }
        public static Home_UserControl instance ()//تحاشي الاستنساخ المتعدد
        {
            return home_UserControl??( home_UserControl = new Home_UserControl());//اذا قيمة فارغة أرجع نيو يوسر كونترول

        }
    }
}
