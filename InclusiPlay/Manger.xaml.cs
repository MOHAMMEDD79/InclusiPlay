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
using InclusiPlay.DataBase;
using InclusiPlay;

namespace InclusiPlay
{
    /// <summary>
    /// Interaction logic for Manger.xaml
    /// </summary>
    public partial class Manger : Window
    {
        public Manger()
        {
            InitializeComponent();
            Connection.setConnection();
            data_grid();
            
        }
        public void data_grid()
        {
            
            string qury = "SELECT NAME,ID,Password,Gender FROM MyTabel";
            SqlCommand cmd = new SqlCommand(qury,Connection.cnn);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
           
            Connection.cnn.Open();

            adapter.Fill(dt);

            Connection.cnn.Close();
            data_gg.ItemsSource = dt.DefaultView;

        }

        private void ref_Click(object sender, RoutedEventArgs e)
        {
            data_grid();
        }

        private void creat_Click(object sender, RoutedEventArgs e)
        {
            DataBase.Insert insert =new DataBase.Insert(data_gg);
            insert.Show();
        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DataRowView drv = (DataRowView)data_gg.SelectedItems[0];
                DataRow dr = drv.Row;
                int ID = Convert.ToInt32(dr.ItemArray[1].ToString());

                string query = $"DELETE FROM MyTabel WHERE ID = {ID}";
                SqlCommand cmd = new SqlCommand(query, Connection.cnn);
                cmd.CommandType = CommandType.Text;

                Connection.cnn.Open();
                cmd.ExecuteNonQuery();
                Connection.cnn.Close();
                MessageBox.Show("Successfully Deleted");
                data_grid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }

        }

        private void search_Click(object sender, RoutedEventArgs e)
        {
            DataBase.Search s = new DataBase.Search();
            s.Show();
        }

        private void updat_Click(object sender, RoutedEventArgs e)
        {
            DataBase.Updat  d = new DataBase.Updat(data_gg) ;
            d.Show();
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
