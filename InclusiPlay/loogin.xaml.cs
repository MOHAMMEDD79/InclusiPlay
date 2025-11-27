using MySql.Data.MySqlClient;
using System;
using System.Windows;

namespace InclusiPlay
{
    public partial class loogin : Window
    {
        public loogin()
        {
            InitializeComponent();
            Connection.setConnection(); // تأكد إن Connection.cnn2 من نوع MySqlConnection
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

            string query = "SELECT COUNT(*) FROM Managers WHERE Username = @Username AND Password = @Password";

            try
            {
                using (MySqlCommand command = new MySqlCommand(query, Connection.cnn2))
                {
                    command.Parameters.AddWithValue("@Username", enteredUsername);
                    command.Parameters.AddWithValue("@Password", enteredPassword);

                    Connection.cnn2.Open();
                    int userCount = Convert.ToInt32(command.ExecuteScalar());
                    Connection.cnn2.Close();

                    if (userCount > 0)
                    {
                        this.Visibility = Visibility.Hidden;
                        Manger n = new Manger();
                        n.ShowDialog();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Wrong Username or Password");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error connecting to database: {ex.Message}");
            }
        }

        private void btnClose_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click_1(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }
    }
}
