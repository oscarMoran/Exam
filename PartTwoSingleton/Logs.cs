using DataBaseManagement;
using DataBaseManagement.Models;

namespace PartTwoSingleton
{
    public class Logs
    {
        private readonly static Logs _instance = new();

        public static Logs Instance
        {
            get { return _instance; }
        }
        public Logs()
        {    
        }

        public bool InsertLog(string status, int execNumber, string user)
        {
            var objManagement = new DBManagement();
            return objManagement.InsertLog(status,execNumber,user);
        }
    }
}