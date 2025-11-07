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
        private readonly List<string> colorNames = new List<string>
        {
            "Red", "Blue", "Green", "Yellow", "Orange"
        };

        private int targetColorIndex;

        public MainWindow()
        {
            InitializeComponent();
            InitializeGame();
        }

        private void InitializeGame()
        {
            // Choose a random color index
            targetColorIndex = new Random().Next(colorNames.Count);

            // Set the color of the rectangle
            colorRectangle.Fill = new SolidColorBrush(GetColorByName(colorNames[targetColorIndex]));

            // Populate the combo box with color names
            colorOptions.ItemsSource = colorNames;

            // Select the first color in the combo box
            colorOptions.SelectedIndex = -1;

            // Clear the result text
            resultText.Text = "";
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            // Get the selected color name from the combo box
            string selectedColorName = colorOptions.SelectedItem.ToString();

            // Check if the selected color name matches the target color name
            if (selectedColorName.Equals(colorNames[targetColorIndex], StringComparison.OrdinalIgnoreCase))
            {
                ShowResult("Correct! You guessed the color.");
            }
            else
            {
                ShowResult($"Incorrect! The correct color was {colorNames[targetColorIndex]}. Try again!");
            }

            // Start a new round after a short delay
            await Task.Delay(1000);
            InitializeGame();
        }

        private void ShowResult(string message)
        {
            Dispatcher.Invoke(() => resultText.Text = message);
        }

        private Color GetColorByName(string colorName)
        {
            return (Color)ColorConverter.ConvertFromString(colorName);
        }
    }
}