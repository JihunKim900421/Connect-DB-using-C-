using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_jay
{
    class Global
    {
        public class DatabasePath
        {
            public static string DB = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = testdb; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
        }
        public class Login  //Global Variable
        {
            public static bool Root = false;
            public static bool Gen = false;
            public static string Current_user = "";

        }
    }
}
