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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Diagnostics;
using System.IO;
using System.Text;
namespace InclusiPlay
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Test_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            string secondProjectPath = @"D:\Study\ريادة وابداع\InclusiPlay\Content\WpfApp3\WpfApp3\bin\Debug\net7.0-windows\WpfApp3.exe";

            Process.Start(secondProjectPath);
            this.Close();
        }

       

        private void Lessons_Click(object sender, RoutedEventArgs e)

        {
            this.Visibility = Visibility.Hidden;
            string secondProjectPath = @"D:\Study\ريادة وابداع\InclusiPlay\Content\Lessons\Lessons\bin\Debug\net7.0-windows\Lessons.exe" ;

            Process.Start(secondProjectPath);
            this.Close();
        }

        private void btnLogin2_Click(object sender, RoutedEventArgs e)
        {
            loogin loogin = new loogin();
            loogin.Show();
           
            Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            string secondProjectPath = @"D:\Study\ريادة وابداع\InclusiPlay\Content\Gaming\Gaming\bin\Debug\net7.0-windows\Gaming.exe";

            Process.Start(secondProjectPath);
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Visibility= Visibility.Hidden;
            Mix mix = new Mix();
            mix.Show();
        
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            
            string youtubeUrl = "https://www.youtube.com/watch?v=uzyiCpsS0qQ&list=PLnb0FwCbM-50UuNjpeIrdEnlSbbMK891Q";

        
            try
            {
                Process.Start(new ProcessStartInfo(youtubeUrl) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening URL: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
         
            About about = new About();
            about.Show();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            string FaceBookUrl = "https://www.facebook.com/profile.php?id=61555123087439";


            try
            {
                Process.Start(new ProcessStartInfo(FaceBookUrl) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening URL: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Sug sug = new Sug();
            sug.Show();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            string htmlFilePath = @"D:\Study\ريادة وابداع\InclusiPlay\kids\html.rometheme.pro\kids\index.html";

            if (File.Exists(htmlFilePath))
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = htmlFilePath,
                    UseShellExecute = true,
                    Verb = "open",
                    CreateNoWindow = true,
                    WindowStyle = ProcessWindowStyle.Hidden,
                    ErrorDialog = false
                });

               
            }
            else
            {
                MessageBox.Show("File not found: " + htmlFilePath);
            }
        }
    }
}
