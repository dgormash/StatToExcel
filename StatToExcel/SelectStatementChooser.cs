using System.Collections.Generic;


namespace StatToExcel
{
    public class SelectStatementChooser:ISelectCommand
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
                    "FROM GAIDEV.STAT_LISH_NS42 " +
                    "WHERE  " +
                            "(CASE " +
                            "WHEN :DetenID = 21 " +
                            "AND detention IN (21, 23, 25, 26, 55) " +
                            "THEN  " +
                            "1 " +
                            "WHEN :DetenID = 52 " +
                            "AND detention IN " +
                            "(44, 45, 46, 47, 48, 49, 50, 51, 52) " +
                            "THEN " +
                            "1 " +
                            "WHEN :DetenID = 7 AND detention IN (7, 57) " +
                            "THEN " +
                            "1 " +
                            "WHEN :DetenID = 36 AND detention IN (35, 36) " +
                            "THEN " +
                            "1 " +
                            "WHEN detention = :DetenID " +
                            "THEN " +
                            "1 " +
                            "ELSE " +
                            "0 " +
                            "END) = 1"},

                {1, "SELECT "+
                            "PROTOCOL_NUMBER \"№ протокола \", " +
                            "VIOLATION_DATE \"Дата нарушения \", " +
                            "VIOLATION_TYPE \"код нарушения \", " +
                            "P32_DATE \"Дата направления в суд\" " +
                    "FROM GAIDEV.STAT_LISH_NS32 "+
                    "WHERE  " +
                            "(CASE " +
                            "WHEN :DetenID = 21 " +
                            "AND detention IN (21, 23, 25, 26, 55) " +
                            "THEN  " +
                            "1 " +
                            "WHEN :DetenID = 52 " +
                            "AND detention IN " +
                            "(44, 45, 46, 47, 48, 49, 50, 51, 52) " +
                            "THEN " +
                            "1 " +
                            "WHEN :DetenID = 7 AND detention IN (7, 57) " +
                            "THEN " +
                            "1 " +
                            "WHEN :DetenID = 36 AND detention IN (35, 36) " +
                            "THEN " +
                            "1 " +
                            "WHEN detention = :DetenID " +
                            "THEN " +
                            "1 " +
                            "ELSE " +
                            "0 " +
                            "END) = 1" },

                {2, "SELECT "+
                            "PROT \"№ протокола н/с\", " +
                            "VIOLATION_DATE_O \"Дата нарушения н/с\", " +
                            "VIOLATION_TYPE_O \"Нарушение н/с\", " +
                            "EXECUTION_TYPE \"Меры по н/с\", " +
                            "DESISION \"Дата ВЗС по н/с\", " +
                            "PROTOCOL_NUMBER \"№ протокола не 12.7\", " +
                            "VIOLATION_DATE_N \"Дата нарушения не 12.7\", " +
                            "VIOLATION_TYPE_N \"Нарушение не 12.7\" " +
                    "FROM STAT_LISH_1207 "+
                            "WHERE  " +
                            "(CASE " +
                            "WHEN :DetenID = 21 " +
                            "AND detention IN (21, 23, 25, 26, 55) " +
                            "THEN  " +
                            "1 " +
                            "WHEN :DetenID = 52 " +
                            "AND detention IN " +
                            "(44, 45, 46, 47, 48, 49, 50, 51, 52) " +
                            "THEN " +
                            "1 " +
                            "WHEN :DetenID = 7 AND detention IN (7, 57) " +
                            "THEN " +
                            "1 " +
                            "WHEN :DetenID = 36 AND detention IN (35, 36) " +
                            "THEN " +
                            "1 " +
                            "WHEN detention = :DetenID " +
                            "THEN " +
                            "1 " +
                            "ELSE " +
                            "0 " +
                            "END) = 1"},

                {3, "SELECT "+
                            "PROT \"№ протокола н/с\", " +
                            "VIOLATION_DATE_O \"Дата нарушения н/с\",  " +
                            "VIOLATION_TYPE_O \"Нарушение н/с\", " +
                            "EXECUTION_TYPE \"Меры по н/с\", " +
                            "DESISION \"Дата ВЗС по н/с\", " +
                            "PROTOCOL_NUMBER \"№ протокола не 264.1\", " +
                            "VIOLATION_DATE_N \"Дата нарушения не 264.1\", " +
                            "VIOLATION_TYPE_N \"Нарушение не 264.1\" " +
                     "FROM GAIDEV.STAT_LISH_264 "+
                            "WHERE  " +
                            "(CASE " +
                            "WHEN :DetenID = 21 " +
                            "AND detention IN (21, 23, 25, 26, 55) " +
                            "THEN  " +
                            "1 " +
                            "WHEN :DetenID = 52 " +
                            "AND detention IN " +
                            "(44, 45, 46, 47, 48, 49, 50, 51, 52) " +
                            "THEN " +
                            "1 " +
                            "WHEN :DetenID = 7 AND detention IN (7, 57) " +
                            "THEN " +
                            "1 " +
                            "WHEN :DetenID = 36 AND detention IN (35, 36) " +
                            "THEN " +
                            "1 " +
                            "WHEN detention = :DetenID " +
                            "THEN " +
                            "1 " +
                            "ELSE " +
                            "0 " +
                            "END) = 1" },

                {4, "SELECT "+
                            "PROT \"№ протокола под 20.25\", " +
                            "VIOLATION_DATE_O \"Дата нарушения под 20.25\", " +
                            "VIOLATION_TYPE_O \"Нарушение под 20.25\", " +
                            "EXECUTION_TYPE \"Меры под 20.25\", " +
                            "DESISION \"Дата ВЗС под 20.25\", " +
                            "PROTOCOL_NUMBER \"№ протокола не 20.25\", " +
                            "VIOLATION_DATE_N \"Дата нарушения не 20.25\", " +
                            "VIOLATION_TYPE_N \"Нарушение не 20.25\" " +
                    "FROM GAIDEV.STAT_LISH_2025 "+
                            "WHERE  " +
                            "(CASE " +
                            "WHEN :DetenID = 21 " +
                            "AND detention IN (21, 23, 25, 26, 55) " +
                            "THEN  " +
                            "1 " +
                            "WHEN :DetenID = 52 " +
                            "AND detention IN " +
                            "(44, 45, 46, 47, 48, 49, 50, 51, 52) " +
                            "THEN " +
                            "1 " +
                            "WHEN :DetenID = 7 AND detention IN (7, 57) " +
                            "THEN " +
                            "1 " +
                            "WHEN :DetenID = 36 AND detention IN (35, 36) " +
                            "THEN " +
                            "1 " +
                            "WHEN detention = :DetenID " +
                            "THEN " +
                            "1 " +
                            "ELSE " +
                            "0 " +
                            "END) = 1"},

                {5, "SELECT " +
                            "PROTOCOL_NUMBER \"№ протокола\", " +
                            "VIOLATION_DATE_N \"Дата нарушения\", " +
                            "VIOLATION_TYPE_N \"код нарушения\", " +
                            "EXECUTION_TYPE \"Меры\", " +
                            "DESISION \"Дата ВЗС\" " +
                    "FROM GAIDEV.STAT_LISH_NOTPAY "+
                            "WHERE  " +
                            "(CASE " +
                            "WHEN :DetenID = 21 " +
                            "AND detention IN (21, 23, 25, 26, 55) " +
                            "THEN  " +
                            "1 " +
                            "WHEN :DetenID = 52 " +
                            "AND detention IN " +
                            "(44, 45, 46, 47, 48, 49, 50, 51, 52) " +
                            "THEN " +
                            "1 " +
                            "WHEN :DetenID = 7 AND detention IN (7, 57) " +
                            "THEN " +
                            "1 " +
                            "WHEN :DetenID = 36 AND detention IN (35, 36) " +
                            "THEN " +
                            "1 " +
                            "WHEN detention = :DetenID " +
                            "THEN " +
                            "1 " +
                            "ELSE " +
                            "0 " +
                            "END) = 1" },

                {6, "SELECT " +
                            "PROTOCOL_NUMBER \"№ протокола\", " +
                            "VIOLATION_DATE_N \"Дата нарушения\", " +
                            "VIOLATION_TYPE_N \"код нарушения\", " +
                            "EXECUTION_TYPE \"Меры\", " +
                            "DESISION \"Дата ВЗС\" " +
                    "FROM GAIDEV.STAT_LISH_FSSP "+
                            "WHERE  " +
                            "(CASE " +
                            "WHEN :DetenID = 21 " +
                            "AND detention IN (21, 23, 25, 26, 55) " +
                            "THEN  " +
                            "1 " +
                            "WHEN :DetenID = 52 " +
                            "AND detention IN " +
                            "(44, 45, 46, 47, 48, 49, 50, 51, 52) " +
                            "THEN " +
                            "1 " +
                            "WHEN :DetenID = 7 AND detention IN (7, 57) " +
                            "THEN " +
                            "1 " +
                            "WHEN :DetenID = 36 AND detention IN (35, 36) " +
                            "THEN " +
                            "1 " +
                            "WHEN detention = :DetenID " +
                            "THEN " +
                            "1 " +
                            "ELSE " +
                            "0 " +
                            "END) = 1" },

                {7, "SELECT " +
                            "PROT \"№ протокола первич\", " +
                            "VIOLATION_DATE_O \"Дата нарушения первич\", " +
                            "VIOLATION_TYPE_O \"Нарушение первич\", " +
                            "EXECUTION_TYPE \"Меры первич\", " +
                            "DESISION \"Дата ВЗС первич\", " +
                            "PROTOCOL_NUMBER \"№ протокола не повтор\", " +
                            "VIOLATION_DATE_N \"Дата нарушения не повтор\", " +
                            "VIOLATION_TYPE_N \"Нарушение не повтор\" " +
                    "FROM GAIDEV.STAT_LISH_POVT "+
                    "WHERE  " +
                            "(CASE " +
                            "WHEN :DetenID = 21 " +
                            "AND detention IN (21, 23, 25, 26, 55) " +
                            "THEN  " +
                            "1 " +
                            "WHEN :DetenID = 52 " +
                            "AND detention IN " +
                            "(44, 45, 46, 47, 48, 49, 50, 51, 52) " +
                            "THEN " +
                            "1 " +
                            "WHEN :DetenID = 7 AND detention IN (7, 57) " +
                            "THEN " +
                            "1 " +
                            "WHEN :DetenID = 36 AND detention IN (35, 36) " +
                            "THEN " +
                            "1 " +
                            "WHEN detention = :DetenID " +
                            "THEN " +
                            "1 " +
                            "ELSE " +
                            "0 " +
                            "END) = 1" },

                {8, "SELECT PROTOCOL_NUMBER \"№ протокола \", " +
                            "VIOLATION_DATE_N \"Дата нарушения \", " +
                            "FIO              \"Фамилия, имя, отчество\", " +
                            "BIRTHDAY         \"Дата рождения\", " +
                            "BEGINN            \"Дата наложения ограничений\", " +
                            "VU_NUMBER        \"№ Водительского удостоверения\" " +
                    "FROM GAIDEV.STAT_LISH_1717 WHERE " +
                            "(CASE " +
                            "WHEN :DetenID = 21 " +
                                "AND detention IN (21, 23, 25, 26, 55) " +
                            "THEN " +
                                "1 " +
                            "WHEN :DetenID = 52 " +
                                "AND detention IN " +
                                        "(44, 45, 46, 47, 48, 49, 50, 51, 52) " +
                            "THEN " +
                                "1 " +
                            "WHEN :DetenID = 7 AND detention IN (7, 57) " +
                            "THEN " +
                                "1 " +
                            "WHEN :DetenID = 36 AND detention IN (35, 36) " +
                            "THEN " +
                                "1 " +
                            "WHEN detention = :DetenID " +
                            "THEN " +
                                "1 " +
                            "ELSE " +
                                "0  " +
                        "END) = 1"},

                {9, "SELECT " +
                            "PROTOCOL_NUMBER \"№ протокола \", " +
                                "VIOLATION_DATE_N \"Дата нарушения \", " +
                            "FIO  \"Фамилия, имя, отчество АП\", " +
                            "BIRTHDAY \"Дата рождения АП\", " +
                            "FIO_R \"Фамилия, имя, отчество роз\",  " +
                            "BIRTHDAY_R \"Дата рождения роз\",  " +
                            "IROZ \"Инициатор розыска\" " +
                    "FROM GAIDEV.STAT_LISH_ROZ " +
                    "WHERE  " +
                            "(CASE " +
                            "WHEN :DetenID = 21 " +
                            "AND detention IN (21, 23, 25, 26, 55) " +
                            "THEN  " +
                            "1 " +
                            "WHEN :DetenID = 52 " +
                            "AND detention IN " +
                            "(44, 45, 46, 47, 48, 49, 50, 51, 52) " +
                            "THEN " +
                            "1 " +
                            "WHEN :DetenID = 7 AND detention IN (7, 57) " +
                            "THEN " +
                            "1 " +
                            "WHEN :DetenID = 36 AND detention IN (35, 36) " +
                            "THEN " +
                            "1 " +
                            "WHEN detention = :DetenID " +
                            "THEN " +
                            "1 " +
                            "ELSE " +
                            "0 " +
                            "END) = 1"}
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
