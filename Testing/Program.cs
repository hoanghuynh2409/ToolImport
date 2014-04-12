using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    class Program
    {
        public static int countColumn(ExcelWorksheet worksheet)
        {
            int totalcell = 0;
            do
            {
                totalcell++;
            } while (worksheet.Cell(1, totalcell + 1).Value != "");
            return totalcell;
        }

        public static string strNaneColumn(int totalColumn, ExcelWorksheet worksheet)
        {
            int iRow = 1;
            string para = null;
            for (int iCol = 0; iCol < totalColumn; iCol++)
            {
                if (worksheet.Cell(iRow, iCol + 1).Value != "")
                {
                    string value = worksheet.Cell(iRow, iCol + 1).Value;
                    para += (iCol == totalColumn - 1) ? value : value + ',';
                }
            }
            return para.Trim();
        }
        static void Main(string[] args)
        {
            FileInfo file = new FileInfo("C:\\Users\\hoang_000\\Desktop\\Project MU Upload for Website.xlsx");
            using (ExcelPackage xlPackage = new ExcelPackage(file))
            {               
                // get the first worksheet in the workbook
                ExcelWorksheet worksheet = xlPackage.Workbook.Worksheets[1];
               // int iCol = 2;  // the column to read
                int totalcell = countColumn(worksheet);

                Console.WriteLine(totalcell);
                Console.WriteLine("start! " + DateTime.Now);

                string para = strNaneColumn(totalcell,worksheet);
                para = "RowNum," + para;
                Console.WriteLine(para);
                using (SqlConnection connection = new SqlConnection("Data Source=HuynhTH;user id=sa;pwd=24092409;database=Dev_Test_Fix"))
                {
                    connection.Open();
                    //insert
                    int totalRows = 0;
                    do
                    {
                        totalRows++;
                        string value = null;
                        for (int i = 0; i < totalcell; i++)
                        {
                                string vcolumn = (worksheet.Cell(totalRows + 1, i + 1).Value == "") ? "NULL" : "'"+worksheet.Cell(totalRows +1, i + 1).Value+"'";
                                value += (i == totalcell - 1) ? vcolumn : vcolumn + ',';
                        }
                       //Console.WriteLine(value);
                       value = totalRows + "," + value;
                       string queryString = "insert into AllRowImport(" + para + ") values(" + value + ")";
                       SqlCommand command = new SqlCommand(queryString, connection);
                       command.ExecuteNonQuery();
                       Console.WriteLine("insert: " + totalRows);
                    } while (worksheet.Cell(totalRows + 1, 1).Value != "");
                }
                Console.WriteLine("success! "+DateTime.Now);
                Console.ReadLine();
            } 
        }

    }
}
