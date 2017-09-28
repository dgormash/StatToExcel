using System.Collections;
using System.Collections.Generic;

namespace StatToExcel
{
    public interface IDbWorker
    {
        void ExecuteProcedure(string procedureName, Parametrs parametrs);

        ArrayList SelectData(string commandText);

        ArrayList SelectData(string commandText, int id);
    }
}