using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace LinQTraining.config
{
    public class ConnectionSQLDATA
    {
        public SqlConnection GetSqlConnection()
        {
            string query = "Server = DESKTOP-72U9R1B\\SQLEXPESS;" +
                "Initial Catalog =dbTest; Integrated Security= SSPI";
            SqlConnection conn = new SqlConnection(query);

            return conn;
        }

    }
}
