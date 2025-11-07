using System.Collections.ObjectModel;
using System.Windows;

namespace Lessons
{
    public partial class Numbers : Window
    {
        private int currentIndex = 0;
        private readonly string[] numbers = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };

        public Numbers()
        {
            InitializeComponent();
            ShowContent();
        }

        private void ShowContent()
        {
            contentTextBlock.Text = $"{numbers[currentIndex]} {NumberToWord(numbers[currentIndex])}";
            ShowPoints(int.Parse(numbers[currentIndex]));
           
        }

        private string NumberToWord(string number)
        {
            switch (number)
            {
                case "1": return "One";
                case "2": return "Two";
                case "3": return "Three";
                case "4": return "Four";
                case "5": return "Five";
                case "6": return "Six";
                case "7": return "Seven";
                case "8": return "Eight";
                case "9": return "Nine";
                case "10": return "Ten";
                // Add more cases for other numbers as needed
                default: return "Unknown";
            }

        }

        private void ShowPoints(int numberOfPoints)
        {
            ObservableCollection<object> points = new ObservableCollection<object>();
            for (int i = 0; i < numberOfPoints; i++)
            {
                points.Add(new object());
            }
            pointsItemsControl.ItemsSource = points;
        }

        private void NextContent_Click(object sender, RoutedEventArgs e)
        {
            currentIndex++;
            if (currentIndex >= numbers.Length)
            {
                MessageBox.Show("Congratulations! You've learned the numbers.", "Finished");
              
            }
            else
            {
                ShowContent();
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
