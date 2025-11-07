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

namespace WpfApp3
{
    public partial class MainWindow : Window
    {
        private void Test_Click(object sender, RoutedEventArgs e)
        {
            Test test = new Test();
            test.Show();
        }
        private void btnLogin3_Click(object sender, RoutedEventArgs e)
        {
           loogin loogin = new loogin();
            loogin.Show();
        }
    }
}