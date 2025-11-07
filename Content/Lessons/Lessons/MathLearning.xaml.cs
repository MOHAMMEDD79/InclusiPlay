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

namespace Lessons
{
    /// <summary>
    /// Interaction logic for MathLearning.xaml
    /// </summary>
    public partial class MathLearning : Window
    {
        private int currentExampleIndex = 0;
        private readonly Random random = new Random();

        public MathLearning()
        {
            InitializeComponent();
            ShowExample();
        }

        private void ShowExample()
        {
            string example = GenerateExample();
            contentTextBlock.Text = $"Example: {example}";
        }

        private string GenerateExample()
        {
            int num1 = random.Next(1, 11);
            int num2 = random.Next(1, 11);

            int result;

            // Select a random operation
            switch (random.Next(1, 5))
            {
                case 1: // Addition
                    result = num1 + num2;
                    return $"{num1} + {num2} = {result}";

                case 2: // Subtraction
                    result = num1 - num2;
                    return $"{num1} - {num2} = {result}";

                case 3: // Multiplication
                    result = num1 * num2;
                    return $"{num1} * {num2} = {result}";

                case 4: // Division
                    // Ensure non-zero divisor
                    num2 = (num2 == 0) ? 1 : num2;
                    result = num1 / num2;
                    return $"{num1} / {num2} = {result}";

                default:
                    return "Unknown Operation";
            }
        }

        private void NextExample_Click(object sender, RoutedEventArgs e)
        {
            currentExampleIndex++;
            if (currentExampleIndex >= 10)
            {
                MessageBox.Show("Congratulations! You've completed the examples.", "Finished");
               
            }
            else
            {
                ShowExample();
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
