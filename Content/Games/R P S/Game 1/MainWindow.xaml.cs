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
    public partial class MainWindow : Window
    {
        private readonly Random random = new Random();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string userChoice = ((Button)sender).Content.ToString();
            string computerChoice = GetComputerChoice();

            string result = DetermineWinner(userChoice, computerChoice);

            resultText.Text = $"You chose {userChoice}. Computer chose {computerChoice}. {result}";
        }

        private string GetComputerChoice()
        {
            string[] choices = { "Rock", "Paper", "Scissors" };
            int index = random.Next(choices.Length);
            return choices[index];
        }

        private string DetermineWinner(string userChoice, string computerChoice)
        {
            if (userChoice == computerChoice)
            {
                return "It's a tie!";
            }
            else if ((userChoice == "Rock" && computerChoice == "Scissors") ||
                     (userChoice == "Paper" && computerChoice == "Rock") ||
                     (userChoice == "Scissors" && computerChoice == "Paper"))
            {
                return "You win!";
            }
            else
            {
                return "Computer wins!";
            }
        }
    }
}
