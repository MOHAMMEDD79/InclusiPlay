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

namespace InclusiPlay
{
    /// <summary>
    /// Interaction logic for loogin.xaml
    /// </summary>
    public partial class loogin : Window
    {
        public loogin()
        {
            InitializeComponent();
            Connection.setConnection();
        }

        private void pre_Click2(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Visibility = Visibility.Visible;
            this.Close();
        }
        private void btnLogin_Click_1(object sender, RoutedEventArgs e)

        {
            string enteredUsername = txtUser.Text;
            string enteredPassword = txtPass.Password;

            // Query the database to check if the entered credentials are valid
            string query = $"SELECT COUNT(*) FROM Manger WHERE UserName = @Username AND Password = @Password";

            using (SqlCommand command = new SqlCommand(query, Connection.cnn2))
            {
                command.Parameters.AddWithValue("@Username", enteredUsername);
                command.Parameters.AddWithValue("@Password", enteredPassword);

                Connection.cnn2.Open();
                int userCount = (int)command.ExecuteScalar();
                Connection.cnn2.Close();

                if (userCount > 0)
                {
                    // Valid username and password
                    this.Visibility = Visibility.Hidden;
                    Manger n = new Manger();
                    n.ShowDialog();
                    Close();
                }
                else
                {
                    // Invalid username or password
                    MessageBox.Show("Wrong Username or Password");
                }
            }

        }

        private void btnClose_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click_1(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized; // Minimize the window.

        }

       
    }
}
