using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laptop_Database.Database
{
    abstract class IDBConnector
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

        public abstract Dictionary<Hardware.Laptop, bool[]> get();
        public abstract Dictionary<Hardware.Laptop, bool[]> get(string condition);
        public abstract void insert(Hardware.Laptop laptop, string hash);
        public abstract void insert(List<Hardware.Laptop> laptops, string hash);
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
