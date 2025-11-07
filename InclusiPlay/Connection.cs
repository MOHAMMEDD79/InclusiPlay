using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InclusiPlay
{

    public class Connection
    {
        static public SqlConnection cnn,cnn2;
        static public void setConnection()
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Test;Integrated Security=True;TrustServerCertificate=True;";

            cnn = new SqlConnection(connectionString);
            cnn2= new SqlConnection(connectionString);
        }
    }
}
