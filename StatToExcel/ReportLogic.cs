using System;
using System.Windows;

namespace StatToExcel
{
    public class ReportLogic:AbstractReportsLogic
    {
        public override void Start(DateTime startDate, DateTime endDate)
        {
            var parameters = new Parametrs
            {
                BeginDate = startDate,
                EndDate = endDate,
                DepartmentId = 0
            };

            //1. Прогоняем список процедур
            for (var i = 0; i <= _procedures.ProcedureName.Length - 1; i++)
            {
                _dbWorker.ExecuteProcedure(_procedures.ProcedureName[i], parameters);
            }

            //2. Для каждого подразделения выполняем селект по списку, передаём результат в excelworker
            for (var i = 0; i <= _departmentList.Departments.Length - 1; i++)
            {
                var excelWorker = new ExcelWorker();
                for (var j = 0; j <= _tables.TableNames.Length - 1; j++)
                {
                    var result = _dbWorker.SelectData(_statementSelector.GetCommand(j), _departmentList.Departments[i].Id);

                    var excelParameters = new ExcelParametrs
                    {
                        Data = result,
                        TableName = _tables.TableNames[j]
                    };
                    excelWorker.MakeExcelReport(excelParameters);
                }

                excelWorker.SaveDocument(_departmentList.Departments[i].Name);
            }

            MessageBox.Show("Работа программы завершена", "Нате вам!!!");
        }
    }
}