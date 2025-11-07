using System.Diagnostics;
using System.Text;
using System.Windows;

namespace Gaming
{
    public partial class MainWindow : Window
    {


        public MainWindow()
        {
            InitializeComponent();
            // Set the reference to the current MainWindow instance

        }

       

        private void pre_Click2(object sender, RoutedEventArgs e)
        {
            string secondProjectPath = @"D:\Study\ريادة وابداع\InclusiPlay\InclusiPlay\bin\Debug\net7.0-windows\InclusiPlay.exe";

            Process.Start(secondProjectPath);

            Close();
        }

        private void Mole_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
           WhackAMoleGame mole = new WhackAMoleGame();
            mole.ShowDialog();
            Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            string secondProjectPath = @"D:\Study\ريادة وابداع\InclusiPlay\Content\Games\Guss Number\Game 1\bin\Debug\net7.0-windows\Game 1.exe";

            Process.Start(secondProjectPath);
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
                this.Visibility = Visibility.Hidden;
            string secondProjectPath = @"D:\Study\ريادة وابداع\InclusiPlay\Content\Games\X O\Game 1\bin\Debug\net7.0-windows\Game 1.exe";

            Process.Start(secondProjectPath);
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            string secondProjectPath = @"D:\Study\ريادة وابداع\InclusiPlay\Content\Games\R P S\Game 1\bin\Debug\net7.0-windows\Game 1.exe";

            Process.Start(secondProjectPath);
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            string secondProjectPath = @"D:\Study\ريادة وابداع\InclusiPlay\Content\Games\Word Order\Game 1\bin\Debug\net7.0-windows\Game 1.exe";

            Process.Start(secondProjectPath);
            this.Close();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            string secondProjectPath = @"D:\Study\ريادة وابداع\InclusiPlay\Content\Games\Color\Game 1\bin\Debug\net7.0-windows\Game 1.exe";

            Process.Start(secondProjectPath);
            this.Close();
        }
    }
}
