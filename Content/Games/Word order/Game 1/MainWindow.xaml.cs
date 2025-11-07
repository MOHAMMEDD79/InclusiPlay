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
        private readonly string[] words = { "programming", "developer", "csharp", "coding", "software", "algorithm", "debugging" };
        private string currentWord;

        public MainWindow()
        {
            InitializeComponent();
            InitializeGame();
        }

        private void InitializeGame()
        {
            currentWord = GetRandomWord();
            DisplayScrambledWord();
        }

        private string GetRandomWord()
        {
            return words[new Random().Next(words.Length)];
        }

        private void DisplayScrambledWord()
        {
            char[] scrambledChars = currentWord.ToCharArray();
            scrambledChars = scrambledChars.OrderBy(c => Guid.NewGuid()).ToArray();
            string scrambledWord = new string(scrambledChars);
            scrambledWordText.Text = scrambledWord;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string userGuess = userInput.Text.ToLower();

            if (userGuess == currentWord)
            {
                MessageBox.Show("Correct! You guessed the word!");
                InitializeGame();
                userInput.Clear();
            }
            else
            {
                MessageBox.Show("Incorrect! Try again.");
            }
        }
    }
}
