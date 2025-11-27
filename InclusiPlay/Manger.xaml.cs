using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows;
using System.Windows.Controls;
using InclusiPlay.DataBase;

namespace InclusiPlay
{
    public partial class Manger : Window
    {
        public Manger()
        {
            InitializeComponent();
            Connection.setConnection(); // تأكد إن Connection.cnn من نوع MySqlConnection
            data_grid();
        }

        public void data_grid()
        {
            try
            {
                string query = "SELECT Name, ID, Password, Gender FROM MyTabel";
                using (MySqlCommand cmd = new MySqlCommand(query, Connection.cnn))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        Connection.cnn.Open();
                        adapter.Fill(dt);
                        Connection.cnn.Close();
                        data_gg.ItemsSource = dt.DefaultView;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}");
            }
        }

        private void ref_Click(object sender, RoutedEventArgs e)
        {
            data_grid();
        }

        private void creat_Click(object sender, RoutedEventArgs e)
        {
            Insert insert = new Insert(data_gg);
            insert.Show();
        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DataRowView drv = (DataRowView)data_gg.SelectedItems[0];
                int ID = Convert.ToInt32(drv["ID"]);

                string query = "DELETE FROM MyTabel WHERE ID=@ID";
                using (MySqlCommand cmd = new MySqlCommand(query, Connection.cnn))
                {
                    cmd.Parameters.AddWithValue("@ID", ID);
                    Connection.cnn.Open();
                    cmd.ExecuteNonQuery();
                    Connection.cnn.Close();
                    MessageBox.Show("Successfully Deleted");
                    data_grid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void search_Click(object sender, RoutedEventArgs e)
        {
            Search s = new Search();
            s.Show();
        }

        private void updat_Click(object sender, RoutedEventArgs e)
        {
            Updat d = new Updat(data_gg);
            d.Show();
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
