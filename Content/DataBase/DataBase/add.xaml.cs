using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows;
using Microsoft.Data.SqlClient;
namespace DataBase
{
    public partial class add : Window
    {
        public add()
        {
            InitializeComponent();
            Connection.SetConnection();
        }

        private void btnInsert_Click(object sender, RoutedEventArgs e)
        {
              int id = int.Parse(txtID.Text);
                string name = txtName.Text;
                int age = int.Parse(txtAge.Text);
                double mark = double.Parse(txtMark.Text);

                string query = $"INSERT INTO Students (ID, Name, Age, Mark) VALUES ({id}, '{name}', {age}, {mark})";
                SqlCommand cmd = new SqlCommand(query, Connection.cnn);
                cmd.CommandType = CommandType.Text;

                Connection.cnn.Open();
                cmd.ExecuteNonQuery();
                Connection.cnn.Close();

                MessageBox.Show("Data inserted successfully");
           
        }
    }
}
