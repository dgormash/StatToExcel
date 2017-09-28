using System.Collections.Generic;

namespace StatToExcel
{
    public class Procedures
    {
        public List<int> Exceptions { get; set; }

        public string[] ProcedureName { get;  set; }

        public Procedures()
        {
            ProcedureName = new string[10];

            ProcedureName[0] = "GAIDEV.LISH_STAT_NS42";
            ProcedureName[1] = "GAIDEV.LISH_STAT_NS32";
            ProcedureName[2] = "GAIDEV.LISH_STAT_1207";
            ProcedureName[3] = "GAIDEV.LISH_STAT_264";
            ProcedureName[4] = "GAIDEV.LISH_STAT_2025";
            ProcedureName[5] = "GAIDEV.LISH_STAT_NOTPAY";
            ProcedureName[6] = "GAIDEV.LISH_STAT_FSSP";
            ProcedureName[7] = "GAIDEV.LISH_STAT_povt";
            ProcedureName[8] = "GAIDEV.LISH_STAT_1717";
            ProcedureName[9] = "GAIDEV.LISH_STAT_ROZ";
        }

        public void SetExcepion()
        {
            
        }
    }
}
