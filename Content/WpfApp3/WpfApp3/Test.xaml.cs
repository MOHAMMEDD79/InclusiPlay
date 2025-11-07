using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for Test.xaml
    /// </summary>
    public partial class Test : Window
    {
        private void Math_Click(object sender, RoutedEventArgs e)
        {
            Math math = new Math();
            math.Show();

        }

        private void Islam_Click(object sender, RoutedEventArgs e)
        {
            Islam islam = new Islam();
            islam.Show();
        }

        private void Chemistry_Click(object sender, RoutedEventArgs e)
        {
            Chemistry ischemistry = new Chemistry();
            ischemistry.Show();
        }

        private void Engineering_Click(object sender, RoutedEventArgs e)
        {
            Engineering isengineering = new Engineering();
            isengineering.Show();
        }

        private void History_Click(object sender, RoutedEventArgs e)
        {
            History history = new History();
            history.Show();
        }

        private void Geography_Click(object sender, RoutedEventArgs e)
        {
            Geography geography = new Geography();
            geography.Show();
        }

        private void Biology_Click(object sender, RoutedEventArgs e)
        {
            Biology biology = new Biology();
            biology.Show();
        }

        private void Physics_Click(object sender, RoutedEventArgs e)
        {
            Physics physics = new Physics();
            physics.Show();
        }
        private void Galaxies_Click(object sender, RoutedEventArgs e)
        {
            Galaxies_science galaxies_Science = new Galaxies_science();
            galaxies_Science.Show();
        }

       

        private void pre_Click2(object sender, RoutedEventArgs e)
        {
            string secondProjectPath = @"D:\Study\ريادة وابداع\InclusiPlay\InclusiPlay\bin\Debug\net7.0-windows\InclusiPlay.exe";

            Process.Start(secondProjectPath);

            Close();
        }
    }
}
