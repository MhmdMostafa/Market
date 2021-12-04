using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;
namespace Market
{
    class ExCRUD
    {
        [DllImport("user32.dll")]
        static extern int GetWindowThreadProcessId(int hWnd, out int lpdwProcessId);

        public static string FilePath = "";
        public static string DirPath = "";
        public static int StartRow = 1;
        public static Excel.Application XlApp;
        public static Excel.Workbook XlWorkBook;
        public static Excel.Worksheet XlWorkSheet;
        public static int column = 22;
        public static int XlAppProcessID;

        public void RunExCRUD()
        {
            CreateXl();
        }


        public void CreateXl()
        {
            string execPath = Assembly.GetEntryAssembly().Location;
            StartRow = 1;
            Excel.Application XlApp = new Excel.Application { Visible = true, EnableAnimations = true, ScreenUpdating = true };
            Excel.Workbook XlWorkBook = XlApp.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);
            Excel.Worksheet XlWorkSheet = (Excel.Worksheet)XlWorkBook.Worksheets.get_Item(1);
            XlWorkSheet.Name = "Invoice";
            XlWorkSheet.Cells.NumberFormat = "@";

            XlWorkSheet.Cells[3, 1].RowHeight = 45;
            XlWorkSheet.Cells[4, 1].RowHeight = 45;
            XlWorkSheet.Columns[1].ColumnWidth = 25;
            XlWorkSheet.Columns[2].ColumnWidth = 5;
            XlWorkSheet.Columns[3].ColumnWidth = 10;
            XlWorkSheet.Columns[4].ColumnWidth = 15;

            XlWorkSheet.Range[XlWorkSheet.Cells[3, 2], XlWorkSheet.Cells[3, 3]].Merge();
            XlWorkSheet.Range[XlWorkSheet.Cells[4, 2], XlWorkSheet.Cells[4, 3]].Merge();
            XlWorkSheet.Range[XlWorkSheet.Cells[3, 2], XlWorkSheet.Cells[4, 2]].Merge();

            XlWorkSheet.Range[XlWorkSheet.Cells[1, 1], XlWorkSheet.Cells[1, 4]].Merge();
            XlWorkSheet.Range[XlWorkSheet.Cells[2, 1], XlWorkSheet.Cells[2, 4]].Merge();

            XlWorkSheet.Cells[1, 1].HorizontalAlignment = XlHAlign.xlHAlignCenter;
            XlWorkSheet.Cells[2, 1].HorizontalAlignment = XlHAlign.xlHAlignCenter;

            XlWorkSheet.Cells[3, 1].RowHeight = 40;
            XlWorkSheet.Cells[1, 1] = "صيدلية يوسف عبدالله الفويز البيطرية";

            XlWorkSheet.Cells[2, 1] = "Youssef Abdullah Al-Fawaz Veterinary Pharmacy";


            XlWorkSheet.Cells[3, 1] = "Tax No:\n300576277800003";
            XlWorkSheet.Cells[3, 4] = "الرقم الضريبي:\n300576277800003";

            XlWorkSheet.Cells[4, 1] = "Commercial Register:\n1131293352";
            XlWorkSheet.Cells[4, 4] = "السجل التجاري:\n1131293352";


            XlWorkSheet.Cells[5, 1] = "Product";
            XlWorkSheet.Cells[5, 2] = "Qu";
            XlWorkSheet.Cells[5, 3] = "Price";
            XlWorkSheet.Cells[5, 4] = "Total";

            XlWorkSheet.Shapes.AddPicture($"{execPath.Replace("Market.exe", "")}test.jpeg", Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoCTrue, 140, 35, 80, 80);
            StartRow = 7;
            XlWorkSheet.Cells.WrapText = true;

        }
        public void OpenXl()
        {
            XlWorkBook = XlApp.Workbooks.Open(@FilePath);

            XlWorkSheet = (Excel.Worksheet)XlWorkBook.Worksheets.get_Item(1);
            XlWorkSheet.Cells.NumberFormat = "@";
        }

        public string ReadCell(int row, int column)
        {
            return XlWorkSheet.Cells[StartRow, column].Text;
        }

        public void UpdateCell(int row, int column, string STR)
        {
            XlWorkSheet.Cells[row, column] = Globals.RmSpace(STR);
        }

        public bool DeleteCell(int row, int column)
        {
            XlWorkSheet.Cells[row, column] = "";
            XlApp.ActiveWorkbook.Save();
            return true;
        }

        public bool LastRow()
        {
            StartRow = 1;
            try
            {
                while (XlWorkSheet.Cells[StartRow, column].Text != "" || XlWorkSheet.Cells[StartRow + 1, column].Text != "")
                    StartRow++;
                StartRow++;
                return true;
            }
            catch (System.Runtime.InteropServices.COMException error)
            {
                MessageBox.Show($"You have closed the Excel File Please open your project again and do not close it again please\nError: {error}");
                XlApp.Quit();
                _ = System.Runtime.InteropServices.Marshal.ReleaseComObject(XlWorkBook);
                _ = System.Runtime.InteropServices.Marshal.ReleaseComObject(XlWorkSheet);
                GetExcelProcess().Kill();
                _ = System.Runtime.InteropServices.Marshal.ReleaseComObject(XlApp);
                XlApp = null;

                return false;
            }

        }

        public Process GetExcelProcess()
        {
            GetWindowThreadProcessId(XlApp.Hwnd, out XlAppProcessID);
            return Process.GetProcessById(XlAppProcessID);
        }


    }
}
