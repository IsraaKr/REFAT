using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace REFAT.Code.Helpers
{
    public static class MsgHelper
    {
        public static void ShowServerError()
        {
            MessageBox.Show("يبدو أن هناك مشكلة في الاتصال . يرجى المحاولة مرة أخرى "
                   , "عدم توفر الاتصال"
                   , MessageBoxButtons.OK
                   , MessageBoxIcon.Information);
        }
        public static void ShowRequierdfileds()
        {
            MessageBox.Show("كل الحقول المعلمة بالنجمة مطلوبة ... يرجى التاكد منها و المحاولة مرة أخرى "
                   , "حقول مطلوبة"
                   , MessageBoxButtons.OK
                   , MessageBoxIcon.Information);
        }
        public static void ShowDuplicatedItems()
        {
            MessageBox.Show(" تم إضافة هذه البيانات بالفعل تأكد من تغير بيانات بعض الحقول "
                   , "بيانات مكررة"
                   , MessageBoxButtons.OK
                   , MessageBoxIcon.Information);
        }
        public static void ShowEmpteyDgv()
        {
            MessageBox.Show(" لإجراء هذه العملية يجدب اختيار بيانات "
                   , "لا يوجد بيانات"
                   , MessageBoxButtons.OK
                   , MessageBoxIcon.Information);
        }
        public static void ShowDeleteSelectedRow()
        {
            MessageBox.Show("يجب عليك ان تختار كامل السطر "
                   , "إجراء الحذف"
                   , MessageBoxButtons.OK
                   , MessageBoxIcon.Information);
        }
        public static bool ShowDeleteDialog()
        {
          var result=   MessageBox.Show("هل انت متأكد من هذا الإجراء "
                   , "إجراء الحذف"
                   , MessageBoxButtons.YesNo
                   , MessageBoxIcon.Question);
            if (result ==DialogResult.Yes)
            {
                return true;
            }
           else 
                return false;
        }
    }
}
