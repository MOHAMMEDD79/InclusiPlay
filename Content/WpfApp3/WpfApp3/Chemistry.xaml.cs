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
    public class ChemistryQuestion
    {
        public string Question { get; set; }
        public List<string> Options { get; set; }
        public char CorrectOption { get; set; }
    }

    public class ChemistryQuestionManager
    {
        private List<ChemistryQuestion> questions;
        private List<ChemistryQuestion> selectedQuestions;
        private Random rand;

        public ChemistryQuestionManager()
        {
            rand = new Random();

            InitializeQuestions();
            SelectRandomQuestions();
        }

        private void InitializeQuestions()
        {
            questions = new List<ChemistryQuestion>
            {
                // Chemistry Question 1
                new ChemistryQuestion
                {
                    Question = "What is the chemical formula for water?",
                    Options = new List<string> { "A. H2O", "B. CO2", "C. CH4", "D. O2" },
                    CorrectOption = 'A'
                },

                // Chemistry Question 2
                new ChemistryQuestion
                {
                    Question = "Which gas is responsible for the smell of rotten eggs?",
                    Options = new List<string> { "A. Oxygen", "B. Hydrogen", "C. Sulfur dioxide", "D. Methane" },
                    CorrectOption = 'C'
                },

                // Chemistry Question 3
new ChemistryQuestion
{
    Question = "Which element has the chemical symbol 'Na'?",
    Options = new List<string> { "A. Nickel", "B. Sodium", "C. Nitrogen", "D. Neptunium" },
    CorrectOption = 'B'
},

// Chemistry Question 4
new ChemistryQuestion
{
    Question = "What is the pH of pure water?",
    Options = new List<string> { "A. 5", "B. 7", "C. 10", "D. 14" },
    CorrectOption = 'B'
},

// Chemistry Question 5
new ChemistryQuestion
{
    Question = "Which gas do plants absorb during photosynthesis?",
    Options = new List<string> { "A. Oxygen", "B. Carbon dioxide", "C. Nitrogen", "D. Hydrogen" },
    CorrectOption = 'B'
},

// Chemistry Question 6
new ChemistryQuestion
{
    Question = "What is the chemical symbol for gold?",
    Options = new List<string> { "A. Au", "B. Ag", "C. Fe", "D. Cu" },
    CorrectOption = 'A'
},

// Chemistry Question 7
new ChemistryQuestion
{
    Question = "Which gas is known as laughing gas?",
    Options = new List<string> { "A. Nitrous oxide", "B. Oxygen", "C. Carbon monoxide", "D. Hydrogen" },
    CorrectOption = 'A'
},

// Chemistry Question 8
new ChemistryQuestion
{
    Question = "What is the main component of natural gas?",
    Options = new List<string> { "A. Methane", "B. Ethane", "C. Propane", "D. Butane" },
    CorrectOption = 'A'
},

// Chemistry Question 9
new ChemistryQuestion
{
    Question = "Which metal is liquid at room temperature?",
    Options = new List<string> { "A. Mercury", "B. Iron", "C. Aluminum", "D. Lead" },
    CorrectOption = 'A'
},

// Chemistry Question 10
new ChemistryQuestion
{
    Question = "What is the chemical formula for table salt?",
    Options = new List<string> { "A. NaCl", "B. KCl", "C. HCl", "D. CaCl2" },
    CorrectOption = 'A'
},

// Chemistry Question 11
new ChemistryQuestion
{
    Question = "What is the atomic number of oxygen?",
    Options = new List<string> { "A. 6", "B. 7", "C. 8", "D. 9" },
    CorrectOption = 'C'
},

// Chemistry Question 12
new ChemistryQuestion
{
    Question = "Which element is essential for human bone health?",
    Options = new List<string> { "A. Calcium", "B. Iron", "C. Sodium", "D. Potassium" },
    CorrectOption = 'A'
},

// Chemistry Question 13
new ChemistryQuestion
{
    Question = "What is the process of converting a solid directly to a gas called?",
    Options = new List<string> { "A. Sublimation", "B. Condensation", "C. Vaporization", "D. Melting" },
    CorrectOption = 'A'
},

// Chemistry Question 14
new ChemistryQuestion
{
    Question = "Which gas is responsible for the greenhouse effect?",
    Options = new List<string> { "A. Carbon dioxide", "B. Oxygen", "C. Nitrogen", "D. Methane" },
    CorrectOption = 'A'
},

// Chemistry Question 15
new ChemistryQuestion
{
    Question = "What is the chemical symbol for silver?",
    Options = new List<string> { "A. Ag", "B. Au", "C. Cu", "D. Al" },
    CorrectOption = 'A'
},

// Chemistry Question 16
new ChemistryQuestion
{
    Question = "Which acid is found in lemons?",
    Options = new List<string> { "A. Citric acid", "B. Acetic acid", "C. Hydrochloric acid", "D. Sulfuric acid" },
    CorrectOption = 'A'
},
            };
        }

        private void SelectRandomQuestions()
        {
            selectedQuestions = questions.OrderBy(q => rand.Next()).Take(10).ToList();
        }

        public List<ChemistryQuestion> GetRandomQuestions()
        {
            return selectedQuestions;
        }

        public char GetCorrectOption(int questionIndex)
        {
            return selectedQuestions[questionIndex].CorrectOption;
        }
    }

    public partial class Chemistry : Window
    {
        private ChemistryQuestionManager questionManager;

        public Chemistry()
        {
            InitializeComponent();
            questionManager = new ChemistryQuestionManager();
            DisplayRandomQuestions();
        }

        private void DisplayRandomQuestions()
        {
            List<ChemistryQuestion> allQuestions = questionManager.GetRandomQuestions();

            List<ChemistryQuestion> randomQuestions = allQuestions.Take(10).ToList();

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
