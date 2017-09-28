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

        public abstract void Start(DateTime startDate, DateTime endDate, ProcedureExceptions exceptions);
    }
}