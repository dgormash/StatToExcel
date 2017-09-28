using System;
using System.Windows;

namespace StatToExcel
{
    public abstract class AbstractReportsLogic
    {
        protected static DepartmentList _departmentList;
        protected static Procedures _procedures;
        protected static Tables _tables;
        protected static SelectStatementChooser _statementSelector;
        protected static IDbWorker _dbWorker = new OracleWorker("192.168.192.1", "gaidev", "mainowner");
        protected static ExcelWorker _excelWorker;
        protected AbstractReportsLogic()
        {
            _departmentList = new DepartmentList();
            _procedures = new Procedures();
            _tables = new Tables();
            _statementSelector = new SelectStatementChooser();
            _excelWorker = new ExcelWorker();
        }

        public abstract void Start(DateTime startDate, DateTime endDate);

        //public void Start(DateTime startDate, DateTime endDate)
        //{
        //    var dbWorker = new OracleWorker("192.168.192.1", "gaidev", "mainowner");
        //    var statementSelector = new SelectStatementChooser();
        //    //Прогоняем весь список отделов
        //    for (var i = 0; i <= _departmentList.Departments.Length - 1; i++)
        //    {
        //        //MainWindow.UpdateLabels(, _departmentList.Departments[i].Name);

        //        var parametrs = new Parametrs
        //        {
        //            BeginDate = startDate,
        //            EndDate = endDate,
        //            DepartmentId = _departmentList.Departments[i].Id
        //        };

        //        var excelWorker = new ExcelWorker();
        //        //Прогоняем список процедур
        //        for (var j = 0; j <= _procedures.ProcedureName.Length - 1; j++)
        //        {
        //            dbWorker.ExecuteProcedure(_procedures.ProcedureName[j], parametrs);
        //            //var result = dbWorker.SelectData(_tables.TableNames[j]);
        //            var result = dbWorker.SelectData(statementSelector.GetCommand(j));

        //            var excelParameters = new ExcelParametrs
        //            {
        //                Data = result,
        //                Department = _departmentList.Departments[i].Name,
        //                TableName = _tables.TableNames[j]
        //            };



        //            excelWorker.MakeExcelReport(excelParameters);

        //        }
        //        excelWorker.SaveDocument(_departmentList.Departments[i].Name);
        //    }

        //    MessageBox.Show("Работа программы завершена", "Нате вам!!!");
        //}
    }
}