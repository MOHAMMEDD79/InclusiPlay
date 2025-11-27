using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows;

namespace InclusiPlay.DataBase
{
    public partial class Search : Window
    {
        public Search()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Connection.setConnection(); // تأكد الاتصال

                string searchCriteria = txtSearchCriteria.Text;

                string query = "SELECT ID, Name, Password, Gender FROM MyTabel " +
                               "WHERE CAST(ID AS CHAR) LIKE @search OR Name LIKE @search";

                using (MySqlCommand command = new MySqlCommand(query, Connection.cnn))
                {
                    command.Parameters.AddWithValue("@search", "%" + searchCriteria + "%");

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGrid.ItemsSource = dt.DefaultView;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
    }
}
