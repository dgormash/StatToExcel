namespace StatToExcel
{
    public class Tables
    {
        private string[] _tableNames;

        public string[] TableNames
        {
            get
            {
                return _tableNames;
            }
        }

        public Tables()
        {
            _tableNames = new string[10];

            _tableNames[0] = "STAT_LISH_NS42";
            _tableNames[1] = "STAT_LISH_NS32";
            _tableNames[2] = "STAT_LISH_1207";
            _tableNames[3] = "STAT_LISH_264";
            _tableNames[4] = "STAT_LISH_2025";
            _tableNames[5] = "STAT_LISH_NOTPAY";
            _tableNames[6] = "STAT_LISH_FSSP";
            _tableNames[7] = "STAT_LISH_povt";
            _tableNames[8] = "STAT_LISH_1717";
            _tableNames[9] = "STAT_LISH_ROZ";
        }
    }
}