using System.Speech.Synthesis;
using System.Windows;

namespace Lessons
{
    public partial class Speak : Window
    {
        private SpeechSynthesizer synthesizer;

        public Speak()
        {
            InitializeComponent();
            synthesizer = new SpeechSynthesizer();
        }

        private void SpeakButton_Click(object sender, RoutedEventArgs e)
        {
            string textToSpeak = txtInput.Text;
            if (!string.IsNullOrWhiteSpace(textToSpeak))
            {
                synthesizer.SpeakAsync(textToSpeak);
            }
        }
        private void pre_Click6(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Visibility = Visibility.Visible;
            this.Close();
        }
    }
}
