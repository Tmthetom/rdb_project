using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laptop_Database.Database
{
    public abstract class IDBConnector
    {
        protected string server = "", database = "";
        protected SqlConnection connection;
        
        protected bool success = false;
        public void setServer(string server)
        {
            this.server = server;
        }
        public void setDatabase(string database)
        {
            this.database = database;
        }

        public abstract void createConnection();
        public abstract void createConnection(string username, string password);

        public abstract List<Hardware.Laptop> get();
        public abstract List<Hardware.Laptop> get(string condition);
        public abstract List<bool> insert(Hardware.Laptop laptop, string hash);
        public abstract List<bool> insert(List<Hardware.Laptop> laptops, string hash);
        public abstract Dictionary<string, int> getMaxValues();
        public abstract Dictionary<string, List<string>> getDistinctValues();
        public abstract void insertPattern(string pattern);
        public abstract bool wasImported(string hash);

        public abstract List<string> getTopPattern(int numberOfPatterns);
        public static IDBConnector factory(string name)
        {
            switch(name)
            {
                case "MSSQLConnector":
                    return new MSSQLConnector();
                default:
                    return null;
            }
        }
    }
}
