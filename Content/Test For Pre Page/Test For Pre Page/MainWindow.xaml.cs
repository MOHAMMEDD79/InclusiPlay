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

namespace Test_For_Pre_Page
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // Set the initial page
            mainFrame.Navigate(new FirstPage());
        }

        private void NavigateToFirstPage(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new FirstPage());
        }

        private void NavigateToSecondPage(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new SecondPage());
        }

        private void NavigateToThirdPage(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new ThirdPage());
        }
    }
}
