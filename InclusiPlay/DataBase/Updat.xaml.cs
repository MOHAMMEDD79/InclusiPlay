using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows;
using System.Windows.Controls;

namespace InclusiPlay.DataBase
{
    public partial class Updat : Window
    {
        private DataGrid dg;
        private Manger manger;
        int ID;
        private string Name, Pass, gender;

        public Updat(DataGrid dg)
        {
            InitializeComponent();
            this.dg = dg;

            DataRowView drv = (DataRowView)dg.SelectedItems[0];
            DataRow dr = drv.Row;
            ID = Convert.ToInt32(dr["ID"]);
            Name = dr["Name"].ToString();
            Pass = dr["Password"].ToString();
            gender = dr["Gender"].ToString();

            txtID.Text = ID.ToString();
            txtName.Text = Name;
            txtPassword.Password = Pass;
            cmbGender.SelectedIndex = (gender == "Male") ? 0 : 1;
        }

        private void Updat_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Connection.setConnection();

                string genderValue = cmbGender.Text == "Male" ? "Male" : "Female";
                string query = "UPDATE MyTabel SET Name=@Name, Password=@Password, Gender=@Gender WHERE ID=@ID";

                using (MySqlCommand cmd = new MySqlCommand(query, Connection.cnn))
                {
                    cmd.Parameters.AddWithValue("@Name", txtName.Text);
                    cmd.Parameters.AddWithValue("@Password", txtPassword.Password);
                    cmd.Parameters.AddWithValue("@Gender", genderValue);
                    cmd.Parameters.AddWithValue("@ID", ID);

                    Connection.cnn.Open();
                    cmd.ExecuteNonQuery();
                    Connection.cnn.Close();

                    MessageBox.Show("Successfully Updated");
                    fill_dataGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void fill_dataGrid()
        {
            string query = "SELECT ID, Name, Password, Gender FROM MyTabel";

            using (MySqlCommand cmd = new MySqlCommand(query, Connection.cnn))
            {
                using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dg.ItemsSource = dt.DefaultView;
                }
            }
        }
    }
}
