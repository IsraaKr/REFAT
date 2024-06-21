using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace REFAT.Code.Helpers
{
    public static class dgvHelper
    {
        public static bool IsEmpty(DataGridView dgv)
        {
            if (dgv.Rows.Count > 0) return false;

            return true;
        }
    }
}
