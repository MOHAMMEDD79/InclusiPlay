using System.Diagnostics;
using System.Windows;

namespace Lessons
{
    public partial class MainWindow : Window
    {
        

        public MainWindow()
        {
            InitializeComponent();
            // Set the reference to the current MainWindow instance
          
        }

        private void Letters_Click(object sender, RoutedEventArgs e)
        {
          this.Visibility = Visibility.Hidden;
            AlphabetLearning alphabetLearning = new AlphabetLearning();
            alphabetLearning.ShowDialog();
            Close();

        }

        private void pre_Click2(object sender, RoutedEventArgs e)
        {
            string secondProjectPath = @"D:\Study\ريادة وابداع\InclusiPlay\InclusiPlay\bin\Debug\net7.0-windows\InclusiPlay.exe";

            Process.Start(secondProjectPath);
            
         Close();
        }

        

        private void Physics_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            Physics p = new Physics();
           p.ShowDialog();
            Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            MathLearning m = new MathLearning();
            m.ShowDialog();
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            Numbers n = new Numbers();
            n.ShowDialog();
            Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            Coding n = new Coding();
            n.ShowDialog();
            Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
           Speak n = new Speak();
            n.ShowDialog();
            Close();
        }
    }
}
