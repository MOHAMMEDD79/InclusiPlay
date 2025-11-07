using System;
using System.Windows;
using test;

namespace test
{
    public partial class App : Application
    {
        private MainWindow mainWindow;
        private SecondWindow secondWindow;

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            OpenMainWindow();
        }

        public void OpenMainWindow()
        {
            mainWindow = new MainWindow(this);
            mainWindow.Show();
        }

        public void OpenSecondWindow()
        {
            secondWindow = new SecondWindow(this);
            mainWindow.Close();
            secondWindow.Show();
        }
    }
}
