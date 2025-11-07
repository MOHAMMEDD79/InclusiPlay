using System.Speech.Synthesis;
using System.Windows;

namespace Voice_Test
{
    public partial class MainWindow : Window
    {
        private SpeechSynthesizer synthesizer;

        public MainWindow()
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
    }
}
