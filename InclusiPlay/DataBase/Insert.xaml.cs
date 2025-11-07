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
using System.Data.SqlClient;
using System.Data;


namespace InclusiPlay.DataBase
{
    /// <summary>
    /// Interaction logic for Insert.xaml
    /// </summary>
    public partial class Insert : Window
    {
        private DataGrid dg;
        private Manger manger;
       
        public Insert(DataGrid dg)
        {
            InitializeComponent();
            this.dg = dg;
        }

        private void InsertButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
             
                string name = txtName.Text;
                string pass = txtPassword.Password;
                string gender = cmbGender.Text.Equals("Male") ? "Male" : "Female";
                string query = "INSERT INTO MyTabel (Name, Password, Gender) " +
                               "VALUES (@Name, @Password, @Gender)";


                using (SqlCommand cmd = new SqlCommand(query, Connection.cnn))
                {
                    cmd.CommandType = CommandType.Text;
                
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Password", pass);
                    cmd.Parameters.AddWithValue("@Gender", gender);

                    Connection.cnn.Open();
                    cmd.ExecuteNonQuery();
                    Connection.cnn.Close();

                    MessageBox.Show("Successfully Added");
                    ClearFields();

                    manger = new Manger();
                    manger.data_grid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void ClearFields()
        {
            txtName.Clear();
           
            txtPassword.Clear();
            cmbGender.SelectedIndex = -1;
        }
    }
}
