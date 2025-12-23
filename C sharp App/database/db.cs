using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_App.database
{
    public static class db
    {
        private static readonly string ConnectionString = "Provider=MSOLEDBSQL.1;Integrated Security=SSPI;Persist Security Info=False;User ID=\"\";Initial Catalog=datasetDB;Data Source=.\\SQLEXPRESS;Initial File Name=\"\";Server SPN=\"\";Authentication=\"\";Access Token=\"\"\r\n";
    
         public static SqlConnection GetConnection()
            {
                return new SqlConnection(ConnectionString);
            }
    }
}
