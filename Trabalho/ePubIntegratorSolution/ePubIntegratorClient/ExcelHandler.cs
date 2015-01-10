using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace ePubIntegratorClient
{
    class ExcelHandler
    {

        //tks cheila :D

        public void saveExcelAs(string path, string name)
        {
            string fullpath = path + "\\" + name;
            createNewExcelFile(fullpath);
            writeToExcelFile(fullpath);
        }

        public static void createNewExcelFile(string path)
        {
            var excelApplication = new Excel.Application();
            excelApplication.Visible = false;
            var excelWorkbook = excelApplication.Workbooks.Add();
            excelWorkbook.SaveAs(path, AccessMode: Excel.XlSaveAsAccessMode.xlNoChange);
            excelWorkbook.Close();
            excelApplication.Quit();
            ReleaseComObject(excelWorkbook);
            ReleaseComObject(excelApplication);
        }

        public static void writeToExcelFile(string path)
        {
            Excel.Application excelApplication = new Excel.Application();
            excelApplication.Visible = false;
            Excel.Workbook excelWorkbook = excelApplication.Workbooks.Open(path);
            Excel.Worksheet excelWorksheet = excelWorkbook.Worksheets.get_Item(1);
            
            // cell writing
            excelWorksheet.Cells[1, 1].Value = "Statistic";
            excelWorksheet.Cells[1, 2].Value = "Value";
            excelWorksheet.Cells[2, 1].Value = "none";
            excelWorksheet.Cells[2, 2].Value = "none";
            
            // finishing operations
            excelWorkbook.Save();
            excelWorkbook.Close();
            excelApplication.Quit();

            // freeing excel objects memory
            ReleaseComObject(excelWorkbook);
            ReleaseComObject(excelApplication);
            ReleaseComObject(excelWorksheet);
        }

        public static void ReleaseComObject(Object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }
    }
}
