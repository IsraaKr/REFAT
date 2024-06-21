using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace REFAT.Code.Helpers
{
    internal class C_Page_Helper
    {
        private readonly Main Main;
        public C_Page_Helper(Main main)
        {
            this.Main = main;
        }
        //set new page
        public void SetPage(UserControl PageuserControl)
        {
            //get the current page
            var old_page = Main.panelContainer.Controls.OfType<UserControl>().FirstOrDefault();
            //remove the old page
            if (old_page !=null && old_page!= PageuserControl)
            {
                Main.panelContainer.Controls.Remove(old_page);
            }
            //add new page
            if ( old_page != PageuserControl)
            {
                PageuserControl.Dock = DockStyle.Fill;
                Main.panelContainer.Controls.Add(PageuserControl);
            }
        }
    }
}
