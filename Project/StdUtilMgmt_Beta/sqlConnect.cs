using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;

namespace StdUtilMgmt_Beta
{
    class sqlConnect
    {
        public static SqlConnection con = null;

        public static SqlConnection GetSqlConnect()
        {
            if (con == null)
            {
                con = new System.Data.SqlClient.SqlConnection("Data Source=LAPTOP-AABJS16T\\MSSQLSERVER01;Initial Catalog=StudentUtilMgmt;Integrated Security=True");
            }
            return con;
        }
        
    }
}
