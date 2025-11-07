using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
namespace DataBase
{
    internal class Connection
    {
        static public SqlConnection cnn;
        static public void SetConnection()
        {
            string connectionString = "Data Source=DESKTOP-11GTCR8;Initial Catalog=Test;Integrated Security=True;TrustServerCertificate=True;";

            cnn = new SqlConnection(connectionString);  
        }
    }
}
