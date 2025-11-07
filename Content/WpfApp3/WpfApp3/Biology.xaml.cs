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
    public class BiologyQuestion
    {
        public string Question { get; set; }
        public List<string> Options { get; set; }
        public char CorrectOption { get; set; }
    }

    public class BiologyQuestionManager
    {
        private List<BiologyQuestion> questions;
        private List<BiologyQuestion> selectedQuestions;
        private Random rand;

        public BiologyQuestionManager()
        {
            rand = new Random();

            InitializeQuestions();
            SelectRandomQuestions();
        }

        private void InitializeQuestions()
        {
            questions = new List<BiologyQuestion>
            {
                // Biology Question 1
                new BiologyQuestion
                {
                    Question = "What is the powerhouse of the cell?",
                    Options = new List<string> { "A. Nucleus", "B. Ribosome", "C. Mitochondria", "D. Endoplasmic Reticulum" },
                    CorrectOption = 'C'
                },

                // Biology Question 2
                new BiologyQuestion
                {
                    Question = "Which gas do plants absorb during photosynthesis?",
                    Options = new List<string> { "A. Oxygen", "B. Nitrogen", "C. Carbon Dioxide", "D. Hydrogen" },
                    CorrectOption = 'C'
                },

// Biology Question 3
new BiologyQuestion
{
    Question = "What is the main function of red blood cells?",
    Options = new List<string> { "A. Transporting oxygen", "B. Fighting infections", "C. Producing antibodies", "D. Digesting food" },
    CorrectOption = 'A'
},

// Biology Question 4
new BiologyQuestion
{
    Question = "What is the largest organ in the human body?",
    Options = new List<string> { "A. Liver", "B. Brain", "C. Heart", "D. Skin" },
    CorrectOption = 'D'
},

// Biology Question 5
new BiologyQuestion
{
    Question = "Which part of the human brain is responsible for regulating basic bodily functions like breathing and heartbeat?",
    Options = new List<string> { "A. Cerebrum", "B. Cerebellum", "C. Medulla Oblongata", "D. Thalamus" },
    CorrectOption = 'C'
},

// Biology Question 6
new BiologyQuestion
{
    Question = "What is the process by which plants make their own food using sunlight?",
    Options = new List<string> { "A. Respiration", "B. Photosynthesis", "C. Fermentation", "D. Transpiration" },
    CorrectOption = 'B'
},

// Biology Question 7
new BiologyQuestion
{
    Question = "Which of the following is not a type of blood vessel?",
    Options = new List<string> { "A. Vein", "B. Artery", "C. Capillary", "D. Tendon" },
    CorrectOption = 'D'
},

// Biology Question 8
new BiologyQuestion
{
    Question = "What is the function of the pancreas in the human body?",
    Options = new List<string> { "A. Producing insulin", "B. Filtering blood", "C. Digesting food", "D. Storing bile" },
    CorrectOption = 'A'
},

// Biology Question 9
new BiologyQuestion
{
    Question = "What is the smallest unit of life?",
    Options = new List<string> { "A. Cell", "B. Molecule", "C. Organ", "D. Tissue" },
    CorrectOption = 'A'
},

// Biology Question 10
new BiologyQuestion
{
    Question = "Which gas do humans inhale during respiration?",
    Options = new List<string> { "A. Carbon Dioxide", "B. Nitrogen", "C. Oxygen", "D. Hydrogen" },
    CorrectOption = 'C'
},

// Biology Question 11
new BiologyQuestion
{
    Question = "What is the function of the ribcage in the human body?",
    Options = new List<string> { "A. Protecting the heart", "B. Aiding digestion", "C. Supporting the spine", "D. Protecting the lungs" },
    CorrectOption = 'D'
},

// Biology Question 12
new BiologyQuestion
{
    Question = "Which of the following is a mammal?",
    Options = new List<string> { "A. Crocodile", "B. Turtle", "C. Dolphin", "D. Frog" },
    CorrectOption = 'C'
},

// Biology Question 13
new BiologyQuestion
{
    Question = "What is the role of white blood cells in the immune system?",
    Options = new List<string> { "A. Producing antibodies", "B. Carrying oxygen", "C. Fighting infections", "D. Regulating body temperature" },
    CorrectOption = 'C'
},

// Biology Question 14
new BiologyQuestion
{
    Question = "Which organelle is responsible for producing energy in a cell?",
    Options = new List<string> { "A. Nucleus", "B. Ribosome", "C. Mitochondria", "D. Endoplasmic Reticulum" },
    CorrectOption = 'C'
},

// Biology Question 15
new BiologyQuestion
{
    Question = "What is the process by which DNA is copied?",
    Options = new List<string> { "A. Transcription", "B. Replication", "C. Translation", "D. Mutation" },
    CorrectOption = 'B'
},

// Biology Question 16
new BiologyQuestion
{
    Question = "What is the purpose of the respiratory system in the human body?",
    Options = new List<string> { "A. Pumping blood", "B. Filtering waste", "C. Exchanging gases", "D. Digesting food" },
    CorrectOption = 'C'
},            };
        }

        private void SelectRandomQuestions()
        {
            selectedQuestions = questions.OrderBy(q => rand.Next()).Take(10).ToList();
        }

        public List<BiologyQuestion> GetRandomQuestions()
        {
            return selectedQuestions;
        }

        public char GetCorrectOption(int questionIndex)
        {
            return selectedQuestions[questionIndex].CorrectOption;
        }
    }

    public partial class Biology : Window
    {
        private BiologyQuestionManager questionManager;

        public Biology()
        {
            InitializeComponent();
            questionManager = new BiologyQuestionManager();
            DisplayRandomQuestions();
        }

        private void DisplayRandomQuestions()
        {
            List<BiologyQuestion> allQuestions = questionManager.GetRandomQuestions();

            List<BiologyQuestion> randomQuestions = allQuestions.Take(10).ToList();

            for (int i = 0; i < randomQuestions.Count; i++)
            {
                TextBlock questionTextBlock = (TextBlock)this.FindName($"QuestionTextBlock{i + 1}");

                questionTextBlock.Text = $"{i + 1}. {randomQuestions[i].Question}";

                for (int j = 0; j < randomQuestions[i].Options.Count; j++)
                {
                    RadioButton optionRadioButton = (RadioButton)this.FindName($"Option{char.ConvertFromUtf32(65 + j)}{i + 1}");
                    optionRadioButton.Content = randomQuestions[i].Options[j];

                    if (randomQuestions[i].CorrectOption == char.ConvertFromUtf32(65 + j)[0])
                    {
                        optionRadioButton.Tag = true;
                    }
                }
            }
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            CheckAnswers();
        }

        private void CheckAnswers()
        {
            string errors = "";

            for (int i = 0; i < 10; i++)
            {
                char selectedOption = GetSelectedOption(i);
                if (selectedOption != questionManager.GetCorrectOption(i))
                {
                    errors += $"Question {i + 1}: Incorrect\n";
                }
            }

            if (string.IsNullOrEmpty(errors))
            {
                ResultText.Text = "All answers are correct!";
            }
            else
            {
                ResultText.Text = "Errors:\n" + errors;
            }
        }

        private char GetSelectedOption(int questionNumber)
        {
            for (int j = 0; j < 4; j++)
            {
                RadioButton optionRadioButton = (RadioButton)this.FindName($"Option{char.ConvertFromUtf32(65 + j)}{questionNumber + 1}");
                if (optionRadioButton.IsChecked.GetValueOrDefault())
                {
                    return char.ConvertFromUtf32(65 + j)[0];
                }
            }
            return ' ';
        }
    }
}
