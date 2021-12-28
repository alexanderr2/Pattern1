using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Repository
{
    class DataRepository
    {
        public string GetAllDataFromDB(string v)
        {
            return SimulatedDatabase.Load(v);
        }

        public void SaveTheData(string data)
        {
            SimulatedDatabase.Save(data);
        }
    }
}
