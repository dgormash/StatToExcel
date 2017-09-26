using System.Collections;
using System.IO;
using System.Linq;
using System.Windows.Media.TextFormatting;
using NPOI.HSSF.Record;
using NPOI.HSSF.UserModel;
using NPOI.HSSF.Util;
using NPOI.SS.UserModel;

namespace StatToExcel
{
    public class ExcelWorker
    {
        private HSSFWorkbook _book;
        //private 
        public ExcelWorker()
        {
            _book = new HSSFWorkbook();
        }
        public void MakeExcelReport(ExcelParametrs parametrs)
        {
            var sheet = _book.CreateSheet(parametrs.TableName);
            var style = _book.CreateCellStyle();
            style.BorderLeft = BorderStyle.Thin;
            style.BorderBottom = BorderStyle.Thin;
            style.BorderRight = BorderStyle.Thin;
            style.BorderTop = BorderStyle.Thin;

            style.Alignment = HorizontalAlignment.Center;
            style.VerticalAlignment = VerticalAlignment.Center;

            style.ShrinkToFit = true;
            var font = _book.CreateFont();
            font.Color = HSSFColor.COLOR_NORMAL;
            font.FontHeightInPoints = 14;
            font.FontName = "Courier New";
            style.SetFont(font);

            if(parametrs.Data != null)
            {
                for (var i = 0; i <= parametrs.Data.Count - 1; i++)
                {
                    var row = sheet.CreateRow(i);

                    var arr = ((IEnumerable)parametrs.Data[i]).Cast<object>().Select(x => x.ToString()).ToArray();
                    for (var j = 0; j <= arr.Length - 1; j++)
                    {
                        var cell = row.CreateCell(j);
                        cell.SetCellValue(arr[j]);
                    }
                }
            }
        }

        public void SaveDocument(string departmentName)
        {
            using (var fileStream = new FileStream($"{departmentName}.xls", FileMode.Create))
            {
                _book.Write(fileStream);
            }
        }
    }
}