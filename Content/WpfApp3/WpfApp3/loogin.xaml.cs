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

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for loogin.xaml
    /// </summary>
    public partial class loogin : Window
    {
        public loogin()
        {
            InitializeComponent();
        }
        
      
       

        private void btnLogin_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Welcom");
        }

        private void btnClose_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click_1(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized; // Minimize the window.

        }
    }
}
