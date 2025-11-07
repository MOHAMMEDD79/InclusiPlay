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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Game_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int secretNumber;
        private int attempts = 0;

        public MainWindow()
        {
            InitializeComponent();
            StartNewGame();
        }

        private void StartNewGame()
        {
            // Generate a random number between 1 and 100
            Random random = new Random();
            secretNumber = random.Next(1, 101);

            // Reset attempts
            attempts = 0;

            // Update attempts label
            lblAttempts.Content = $"Attempts: {attempts}";

            // Clear previous results
            lblResult.Content = "";
        }

        private void BtnSubmit_Click(object sender, RoutedEventArgs e)
        {
            // Increment attempts
            attempts++;

            // Update attempts label
            lblAttempts.Content = $"Attempts: {attempts}";

            try
            {
                // Get the user's guess
                int userGuess = int.Parse(txtGuess.Text);

                // Check the guess
                if (userGuess == secretNumber)
                {
                    lblResult.Content = $"Congratulations! You guessed the number {secretNumber} in {attempts} attempts.";
                    StartNewGame();
                }
                else if (userGuess < secretNumber)
                {
                    lblResult.Content = "Too low! Try again.";
                }
                else
                {
                    lblResult.Content = "Too high! Try again.";
                }
            }
            catch (FormatException)
            {
                lblResult.Content = "Please enter a valid number.";
            }
        }
    }
}
