using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;
using ClosedXML;
using ClosedXML.Excel;

namespace REFAT.Code.Helpers
{
  public static  class ExcelHelper
    {
        public static void ExportExcel(DataTable datatable , string sheetName )
        {
            //define save dialog
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.AddExtension = true;
            saveFileDialog.DefaultExt = "xlsx";
            saveFileDialog.Filter = "Excel File (xlsx)| *.xlsx";
            saveFileDialog.Title="Export Excel File";

            var res = saveFileDialog.ShowDialog();
            if (res==DialogResult.OK)
            {
                try
                {
                    using (XLWorkbook xLWorkbook = new XLWorkbook())
                    {
                        xLWorkbook.AddWorksheet(datatable, sheetName);
                        using (MemoryStream ma = new MemoryStream())
                        {
                            xLWorkbook.SaveAs(ma);
                            File.WriteAllBytes(saveFileDialog.FileName, ma.ToArray());
                        }
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
              
            }
                     //export
        }
    }
}
