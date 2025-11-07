using System;
using System.Data.SqlClient;
using System.Windows;
using Microsoft.Data.SqlClient;

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
                using (SqlConnection connection = Connection.cnn)
                {
                    connection.Open();

                    string username = txtUsername.Text;
                    string message = txtMessage.Text;

                    // Assuming your table is named "Messages" with columns "Username" and "Message"
                    string query = "INSERT INTO Messages (Username, Message) VALUES (@Username, @Message)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Message", message);

                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Message sent successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
    }
}
