using MySql.Data.MySqlClient;

namespace InclusiPlay
{
    public static class Connection
    {
        public static MySqlConnection cnn;
        public static MySqlConnection cnn2;

        public static void setConnection()
        {
            // غير User و Password حسب إعدادات XAMPP/MySQL عندك
            string connectionString = "Server=localhost;Database=InclusiPlayDB;Uid=root;Pwd=;";

            cnn = new MySqlConnection(connectionString);
            cnn2 = new MySqlConnection(connectionString);
        }
    }
}
