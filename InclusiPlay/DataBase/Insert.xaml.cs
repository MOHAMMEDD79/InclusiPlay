// Insert.xaml.cs
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows;
using System.Windows.Controls;

namespace InclusiPlay.DataBase
{
    public partial class Insert : Window
    {
        private DataGrid dg;

        public Insert(DataGrid dg)
        {
            InitializeComponent();
            this.dg = dg;
        }

        private void InsertButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Connection.setConnection();

                string name = txtName.Text;
                string pass = txtPassword.Password;
                string gender = cmbGender.Text.Equals("Male") ? "Male" : "Female";

                string query = "INSERT INTO MyTabel (Name, Password, Gender) " +
                               "VALUES (@Name, @Password, @Gender)";

                using (MySqlCommand cmd = new MySqlCommand(query, Connection.cnn))
                {
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Password", pass);
                    cmd.Parameters.AddWithValue("@Gender", gender);

                    Connection.cnn.Open();
                    cmd.ExecuteNonQuery();
                    Connection.cnn.Close();
                }

                MessageBox.Show("Successfully Added");
                ClearFields();
                LoadData();
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

        private void LoadData()
        {
            try
            {
                Connection.setConnection();
                string query = "SELECT * FROM MyTabel";

                using (MySqlCommand cmd = new MySqlCommand(query, Connection.cnn))
                {
                    Connection.cnn.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dg.ItemsSource = dt.DefaultView;
                    Connection.cnn.Close();
                }
            }
            catch { }
        }
    }
}
