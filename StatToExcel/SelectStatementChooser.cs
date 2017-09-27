using System.Collections.Generic;


namespace StatToExcel
{
    class SelectStatementChooser:ISelectCommand
    {
        private Dictionary<int, string> _selectStatements;

        public SelectStatementChooser()
        {
            _selectStatements = new Dictionary<int, string>
            {
                

                {0, "SELECT "+
                            "PROTOCOL_NUMBER \"№ протокола \", " +
                            "VIOLATION_DATE \"Дата нарушения \", " +
                            "VIOLATION_TYPE \"код нарушения \" " +
                    "FROM GAIDEV.STAT_LISH_NS42"},

                {1, "SELECT "+
                            "PROTOCOL_NUMBER \"№ протокола \", " +
                            "VIOLATION_DATE \"Дата нарушения \", " +
                            "VIOLATION_TYPE \"код нарушения \", " +
                            "P32_DATE \"Дата направления в суд\" " +
                    "FROM GAIDEV.STAT_LISH_NS32" },

                {2, "SELECT "+
                            "PROT \"№ протокола н/с\", " +
                            "VIOLATION_DATE_O \"Дата нарушения н/с\", " +
                            "VIOLATION_TYPE_O \"Нарушение н/с\", " +
                            "EXECUTION_TYPE \"Меры по н/с\", " +
                            "DESISION \"Дата ВЗС по н/с\", " +
                            "PROTOCOL_NUMBER \"№ протокола не 12.7\", " +
                            "VIOLATION_DATE_N \"Дата нарушения не 12.7\", " +
                            "VIOLATION_TYPE_N \"Нарушение не 12.7\" " +
                    "FROM STAT_LISH_1207"},

                {3, "SELECT "+
                            "PROT \"№ протокола н/с\", " +
                            "VIOLATION_DATE_O \"Дата нарушения н/с\",  " +
                            "VIOLATION_TYPE_O \"Нарушение н/с\", " +
                            "EXECUTION_TYPE \"Меры по н/с\", " +
                            "DESISION \"Дата ВЗС по н/с\", " +
                            "PROTOCOL_NUMBER \"№ протокола не 264.1\", " +
                            "VIOLATION_DATE_N \"Дата нарушения не 264.1\", " +
                            "VIOLATION_TYPE_N \"Нарушение не 264.1\" " +
                     "FROM GAIDEV.STAT_LISH_264" },

                {4, "SELECT "+
                            "PROT \"№ протокола под 20.25\", " +
                            "VIOLATION_DATE_O \"Дата нарушения под 20.25\", " +
                            "VIOLATION_TYPE_O \"Нарушение под 20.25\", " +
                            "EXECUTION_TYPE \"Меры под 20.25\", " +
                            "DESISION \"Дата ВЗС под 20.25\", " +
                            "PROTOCOL_NUMBER \"№ протокола не 20.25\", " +
                            "VIOLATION_DATE_N \"Дата нарушения не 20.25\", " +
                            "VIOLATION_TYPE_N \"Нарушение не 20.25\" " +
                    "FROM GAIDEV.STAT_LISH_2025"},

                {5, "SELECT " +
                            "PROTOCOL_NUMBER \"№ протокола\", " +
                            "VIOLATION_DATE_N \"Дата нарушения\", " +
                            "VIOLATION_TYPE_N \"код нарушения\", " +
                            "EXECUTION_TYPE \"Меры\", " +
                            "DESISION \"Дата ВЗС\" " +
                    "FROM GAIDEV.STAT_LISH_NOTPAY" },

                {6, "SELECT " +
                            "PROTOCOL_NUMBER \"№ протокола\", " +
                            "VIOLATION_DATE_N \"Дата нарушения\", " +
                            "VIOLATION_TYPE_N \"код нарушения\", " +
                            "EXECUTION_TYPE \"Меры\", " +
                            "DESISION \"Дата ВЗС\" " +
                    "FROM GAIDEV.STAT_LISH_FSSP" },

                {7, "SELECT " +
                            "PROT \"№ протокола первич\", " +
                            "VIOLATION_DATE_O \"Дата нарушения первич\", " +
                            "VIOLATION_TYPE_O \"Нарушение первич\", " +
                            "EXECUTION_TYPE \"Меры первич\", " +
                            "DESISION \"Дата ВЗС первич\", " +
                            "PROTOCOL_NUMBER \"№ протокола не повтор\", " +
                            "VIOLATION_DATE_N \"Дата нарушения не повтор\", " +
                            "VIOLATION_TYPE_N \"Нарушение не повтор\" " +
                    "FROM GAIDEV.STAT_LISH_POVT" }
            };
        }

        public string GetCommand(int id)
        {
            if (_selectStatements.ContainsKey(id))
            {
                return _selectStatements[id];
            }

            return null;
        }
    }




}
