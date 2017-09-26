namespace StatToExcel
{
    public class Procedures
    {
        public string[] ProcedureName { get;  set; }

        public Procedures()
        {
            ProcedureName = new string[8];

            ProcedureName[0] = "GAIDEV.LISH_STAT_NS42";
            ProcedureName[1] = "GAIDEV.LISH_STAT_NS32";
            ProcedureName[2] = "GAIDEV.LISH_STAT_1207";
            ProcedureName[3] = "GAIDEV.LISH_STAT_264";
            ProcedureName[4] = "GAIDEV.LISH_STAT_2025";
            ProcedureName[5] = "GAIDEV.LISH_STAT_NOTPAY";
            ProcedureName[6] = "GAIDEV.LISH_STAT_FSSP";
            ProcedureName[7] = "GAIDEV.LISH_STAT_povt";
        }
    }
}
