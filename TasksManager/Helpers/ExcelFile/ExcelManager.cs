using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
namespace TasksManager.Helpers.ExcelFile
{
    public class ExcelManager
    {
        private string DB_PATH = @"";

        public Microsoft.Office.Interop.Excel.Workbook MyBook = null;
        private Excel.Application MyApp = null;
        public Excel.Worksheet MySheet = null;
        /// <summary>
        /// Excel Row
        /// </summary>
        public int lastRow = 0;

        /// <summary>
        /// Row Number of Sheet
        /// </summary>
        /// <returns></returns>
        public int RowNumber()
        {
            return lastRow;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="DB_PATH">Pathe of File Data</param>
        public ExcelManager(string DB_PATH)
        {
            this.DB_PATH = DB_PATH;
            this.InitializeExcel();
        }
        public  void InitializeExcel()
        {
           
              


            bool failed = false;
            int i = 0;
            do
            {
                try
                {
                    i++;
                    MyApp = new Excel.Application();
                    MyApp.Visible = false;
                    MyBook = MyApp.Workbooks.Open(DB_PATH);
                    MySheet = (Excel.Worksheet)MyBook.Sheets[1]; // Explict cast is not required here
                    lastRow = MySheet.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell).Row;
                    
                    // Call goes here
                    failed = false;
                }
                catch (System.Runtime.InteropServices.COMException e)
                {
                    failed = true;
                }
                System.Threading.Thread.Sleep(10);
            } while (failed && i< 10);



        }
 
        public void CloseExcel()
        {
            MyBook.Saved = true;
            MyApp.Quit();
        }
    }
}
