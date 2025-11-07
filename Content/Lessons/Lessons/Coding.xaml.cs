using System.Windows;

namespace Lessons
{
    public partial class Coding : Window
    {
        public Coding()
        {
            InitializeComponent();
        }
        private void pre_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Visibility = Visibility.Visible;
            this.Close();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Variables
            int number = 10;            // integer variable
            double pi = 3.14;           // real number variable
            string name = "John";       // text variable

            // Display variables in MessageBox
            MessageBox.Show($"A variable is like a labeled box that can hold different types of information.\n\n" +
                            $"Number: {number}\nPi: {pi}\nName: {name}", "Variables");

            // Arrays
            int[] intArray = { 1, 2, 3, 4, 5 };

            // Display array in MessageBox
            string arrayInfo = "An array is like a shelf with slots, each holding a similar type of item.\n\n" +
                               "Array elements: ";
            foreach (int item in intArray)
            {
                arrayInfo += $"{item} ";
            }

            MessageBox.Show(arrayInfo, "Arrays");

            // Strings
            string greeting = "Hello, World!";

            // Display string in MessageBox
            MessageBox.Show($"A string is like a chain of characters, used for storing and working with text.\n\n" +
                            $"String: {greeting}", "Strings");

            // Loop
            string loopInfo = "A loop is like doing something repeatedly. It repeats a block of code until a certain condition is met.\n\n" +
                              "For example, this loop will print 'Hello' five times:\n\n";
            for (int i = 0; i < 5; i++)
            {
                loopInfo += "Hello\n";
            }

            MessageBox.Show(loopInfo, "Loops");

            // If Statement
            int x = 10;

            // Display message based on condition
            if (x > 5)
            {
                MessageBox.Show($"An if statement is like making a decision in your code. If a certain condition is true, it executes a block of code.\n\n" +
                                $"For example, since x is greater than 5, this message is displayed.", "If Statement");
            }
            else
            {
                MessageBox.Show($"This message won't be displayed because x is not greater than 5.", "If Statement");
            }
        }
    }
}
