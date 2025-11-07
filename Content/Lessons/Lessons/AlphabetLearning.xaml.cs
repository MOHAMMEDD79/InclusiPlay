using System.Windows;

namespace Lessons
{
    public partial class AlphabetLearning : Window
    {
        private int currentLetterIndex = 0;
        private readonly string[] alphabet = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M",
                                             "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"};

        private readonly string[] lessons = {"A is for Apple", "B is for Ball", "C is for Cat", "D is for Dog",
                                             "E is for Elephant", "F is for Fish", "G is for Giraffe", "H is for Hat",
                                             "I is for Ice Cream", "J is for Jellyfish", "K is for Kite", "L is for Lion",
                                             "M is for Moon", "N is for Nest", "O is for Owl", "P is for Penguin",
                                             "Q is for Queen", "R is for Rainbow", "S is for Sun", "T is for Turtle",
                                             "U is for Umbrella", "V is for Violin", "W is for Watermelon",
                                             "X is for Xylophone", "Y is for Yo-yo", "Z is for Zebra"};

        public AlphabetLearning()
        {
            InitializeComponent();
            ShowLetterAndLesson();
        }

        private void ShowLetterAndLesson()
        {
            letterTextBlock.Text = alphabet[currentLetterIndex];
            MessageBox.Show(lessons[currentLetterIndex], "Lesson");
        }

        private void NextLetter_Click(object sender, RoutedEventArgs e)
        {
            currentLetterIndex++;
            if (currentLetterIndex >= alphabet.Length)
            {
                MessageBox.Show("Congratulations! You've learned the entire alphabet.", "Finished");
                Close();
            }
            else
            {
                ShowLetterAndLesson();
            }
        }

        private void pre_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Visibility = Visibility.Visible;
            this.Close();
        }
    }
}
