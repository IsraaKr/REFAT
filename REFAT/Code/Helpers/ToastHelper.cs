using REFAT.GUI.ToastGui;
using System;
using System.Collections.Generic;
using System.Text;

namespace REFAT.Code.Helpers
{
  public static  class ToastHelper
    {
        public static void showAddToast()
        {
            ToastForm.Instance("إضافة بيانات", "تم إضافة البيانات بنجاح").Show(); ;
        }
        public static void showEditToast()
        {
            ToastForm.Instance("تعديل بيانات", "تم تعديل البيانات بنجاح").Show(); ;
        }
        public static void showDeleteToast()
        {
            ToastForm.Instance("حذف بيانات", "تم حذف البيانات بنجاح").Show(); ;
        }
    }

}
