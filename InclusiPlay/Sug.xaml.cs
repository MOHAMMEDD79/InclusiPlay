using Microsoft.Data.SqlClient;
using MySql.Data.MySqlClient;
using System;
using System.Data.SqlClient;
using System.Windows;

namespace InclusiPlay
{
    public partial class Sug : Window
    {
        public Sug()
        {
            InitializeComponent();
            Connection.setConnection();
        }
        private void SendMessage_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Connection.setConnection();
                Connection.cnn.Open();

                string username = txtUsername.Text;
                string message = txtMessage.Text;

                string query = "INSERT INTO Messages (Username, Message) VALUES (@Username, @Message)";
                using (MySqlCommand cmd = new MySqlCommand(query, Connection.cnn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Message", message);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Message sent successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                Connection.cnn.Close();
            }
        }

    }
}
