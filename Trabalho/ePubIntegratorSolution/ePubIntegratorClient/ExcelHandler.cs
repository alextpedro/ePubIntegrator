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

        string user;

        public ExcelHandler(string user)
        {
            this.user = user;
        }

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

        private void writeToExcelFile(string path)
        {
            Excel.Application excelApplication = new Excel.Application();
            excelApplication.Visible = false;
            Excel.Workbook excelWorkbook = excelApplication.Workbooks.Open(path);
            Excel.Worksheet excelWorksheet = excelWorkbook.Worksheets.get_Item(1);

            //labelUser.Text = "User: " + user;
            //labelLogin.Text = "Times Logged: " + stats.getLoginCount();
            //labelBooks.Text = "Books in Library: " + stats.getBooks();
            //labelReadtime.Text = "Reading Time: " + stats.getReadtimes();
            //labelFavourites.Text = "Favourites: " + stats.getFavourites();
            //labelBookmarks.Text = "Bookmarks: " + stats.getBookmarks();

            Statistics stats = new Statistics(user);


            // cell writing
            excelWorksheet.Cells[1, 1].Value = "Statistic";
            excelWorksheet.Cells[1, 2].Value = "Value";
            excelWorksheet.Cells[2, 1].Value = "User";
            excelWorksheet.Cells[2, 2].Value = user;
            excelWorksheet.Cells[3, 1].Value = "Times Logged";
            excelWorksheet.Cells[3, 2].Value = stats.getLoginCount();
            excelWorksheet.Cells[4, 1].Value = "Books in Library";
            excelWorksheet.Cells[4, 2].Value = stats.getBooks();
            excelWorksheet.Cells[5, 1].Value = "Reading Time";
            excelWorksheet.Cells[5, 2].Value = stats.getReadtimes();
            excelWorksheet.Cells[6, 1].Value = "Favourites";
            excelWorksheet.Cells[6, 2].Value = stats.getFavourites();
            excelWorksheet.Cells[7, 1].Value = "Bookmarks";
            excelWorksheet.Cells[7, 2].Value = stats.getBookmarks();
            
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
