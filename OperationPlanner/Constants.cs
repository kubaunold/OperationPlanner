using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationPlanner
{
    class Constants
    {
        public const string db_host = "localhost";
        public const int db_port = 3306;
        public const string db_login = "root";
        public const string db_pass = "";
        public const string db_dbname = "patient";
        public static string connString = "datasource=" + db_host + ";" +
                                    "port=" + db_port.ToString() + ";" +
                                    "username=" + db_login + ";" +
                                    "database=" + db_dbname;// +
                                    //"password=" + db_host;
    }
}
