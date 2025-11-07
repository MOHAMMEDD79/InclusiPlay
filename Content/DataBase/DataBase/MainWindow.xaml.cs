using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data;

namespace DataBase
{
    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Connection.SetConnection();
              Vewidata();
        


        }
        private void Vewidata()
        {

            string qury = "SELECT ID,Name,Age,Mark FROM Students";
            SqlCommand cmd = new SqlCommand(qury, Connection.cnn);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            Connection.cnn.Open();

            adapter.Fill(dt);

            Connection.cnn.Close();
           datagrid.ItemsSource = dt.DefaultView;

        }

        private void ref_Click(object sender, RoutedEventArgs e)
        {
            Vewidata();
        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            DataRowView drv = (DataRowView)datagrid.SelectedItem;

            if (drv != null)
            {
                try
                {
                    DataRow dr = drv.Row;
                    int studentID = (int)dr.ItemArray[0];

                    string query = $"DELETE FROM Students WHERE ID = {studentID}";
                    SqlCommand cmd = new SqlCommand(query, Connection.cnn);
                    cmd.CommandType = CommandType.Text;

                    Connection.cnn.Open();
                    cmd.ExecuteNonQuery();
                    Connection.cnn.Close();

                    MessageBox.Show("Successfully Deleted");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a student to delete.");
            }
        }

        private void creat_Click(object sender, RoutedEventArgs e)
        {
            add add = new add();
            add.Show();
        }
    }
}
