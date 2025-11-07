using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
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


namespace InclusiPlay.DataBase
{
    /// <summary>
    /// Interaction logic for Updat.xaml
    /// </summary>
    public partial class Updat : Window
    {
        private DataGrid dg;
        private Manger manger;
        int ID;
       private string Name, Pass, gender;

        private void Updat_Click(object sender, RoutedEventArgs e)
        {
            string gender = cmbGender.Text.Equals("Male") ? "Male" : "Female";

            string query = $"UPDATE MyTabel " +
                 $"SET Name = '{txtName.Text}', Password = '{txtPassword.Password}', " +
                 $"Gender = '{gender}' " +
                 $"WHERE ID = {ID}";

            SqlCommand cmd = new SqlCommand(query, Connection.cnn);
            cmd.CommandType = CommandType.Text;

            Connection.cnn.Open();
            cmd.ExecuteNonQuery();
            Connection.cnn.Close();
            MessageBox.Show("Successfully Updated");
            fill_dataGrid();
        }

        private void fill_dataGrid()
        {
            string query = $"SELECT ID, Name, Password, Gender " + // Added spaces after each column name
                           $"FROM MyTabel;"; // Corrected the table name
            SqlCommand cmd = new SqlCommand(query, Connection.cnn);

            SqlDataAdapter sda = new SqlDataAdapter(cmd);

            Connection.cnn.Open();
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dg.ItemsSource = dt.DefaultView;
            Connection.cnn.Close();
        }


        public Updat(DataGrid dg)
        {
            InitializeComponent();
            this.dg = dg;
            DataRowView drv = (DataRowView)dg.SelectedItems[0];
            DataRow dr = drv.Row;
            ID = (int)dr.ItemArray[1];
            Name = (string)dr.ItemArray[0];
           Pass = (string)dr.ItemArray[2];
            gender = (string)dr.ItemArray[3];
         

           txtID.Text = ID.ToString();
           txtName.Text = Name;
            txtPassword.Password =Pass;
            if (gender.Equals("Male"))
            {
                cmbGender.SelectedIndex = 0;
            }
            else
            {
                cmbGender.SelectedIndex = 1;
            }
           
            ;
        }
    }
}
