using System.Collections;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Controls;
using NPOI.HSSF.UserModel;
using NPOI.HSSF.Util;
using NPOI.SS.UserModel;

namespace StatToExcel
{
    public class ExcelWorker
    {
        private HSSFWorkbook _book;
        private string[] _arr;
        //private 
        public ExcelWorker()
        {
            _book = new HSSFWorkbook();
        }
        public void MakeExcelReport(ExcelParametrs parametrs)
        {
            var sheetName = string.Empty;

            switch (parametrs.TableName)
            {
                case "STAT_LISH_NS42":
                    sheetName = "Отсутсвие мер (этап 42)";
                    break;

                case "STAT_LISH_NS32":
                    sheetName = "Нар. ср. напр. в суд (этап 32)";
                    break;
                case "STAT_LISH_1207":
                    sheetName = "Несост-ие по ст. 12.7 ч.2";
                    break;
                case "STAT_LISH_264":
                    sheetName = "Невозб-ие ст. 264 прим. 1";
                    break;
                case "STAT_LISH_2025":
                    sheetName = "Несост-ие по ст. 20.25";
                    break;
                case "STAT_LISH_NOTPAY":
                    sheetName = "Выдача ВУ без оплаты";
                    break;
                case "STAT_LISH_FSSP":
                    sheetName = "Ненапр-ие в ФССП";
                    break;
                case "STAT_LISH_povt":
                    sheetName = "Неприм-ие повторности";
                    break;
            }

            var sheet = _book.CreateSheet(sheetName);
            var style = _book.CreateCellStyle();
            style.BorderLeft = BorderStyle.Thin;
            style.BorderBottom = BorderStyle.Thin;
            style.BorderRight = BorderStyle.Thin;
            style.BorderTop = BorderStyle.Thin;

            style.Alignment = HorizontalAlignment.Center;
            style.VerticalAlignment = VerticalAlignment.Center;
            
            var font = _book.CreateFont();
            font.Color = HSSFColor.COLOR_NORMAL;
            font.FontHeightInPoints = 10;
            font.FontName = "Courier New";
            style.SetFont(font);

            if (parametrs.Data != null)
            {
                for (var i = 0; i <= parametrs.Data.Count - 1; i++)
                {
                    var row = sheet.CreateRow(i);

                    _arr = ((IEnumerable) parametrs.Data[i]).Cast<object>().Select(x => x.ToString()).ToArray();
                    for (var j = 0; j <= _arr.Length - 1; j++)
                    {
                        var cell = row.CreateCell(j);
                        cell.SetCellType(CellType.String);
                        cell.CellStyle = style;
                        cell.SetCellValue(_arr[j]);
                    }
                }

                for (var j = 0; j <= _arr.Length - 1; j++)
                {
                    sheet.AutoSizeColumn(j);
                }
            }
            else
            {
                var row = sheet.CreateRow(0);
                var cell = row.CreateCell(0);
                cell.SetCellType(CellType.String);
                cell.SetCellValue("Нет данных для отображения");
                sheet.AutoSizeColumn(0);
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