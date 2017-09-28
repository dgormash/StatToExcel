using System.Collections.Generic;

namespace StatToExcel
{
    public class ProcedureExceptions
    {
        public List<int> Exceptions { get; set; }

        public ProcedureExceptions()
        {
            Exceptions = new List<int>();
        }
        public void SetException(int id)
        {
            if (!Exceptions.Contains(id))
            {
                Exceptions.Add(id);
            }
        }

        public void RemoveException(int id)
        {
            if (Exceptions.Contains(id))
            {
                Exceptions.Remove(id);
            }
        }
    }
}