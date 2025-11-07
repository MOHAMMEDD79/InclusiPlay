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
    public class EngineeringQuestion
    {
        public string Question { get; set; }
        public List<string> Options { get; set; }
        public char CorrectOption { get; set; }
    }

    public class EngineeringQuestionManager
    {
        private List<EngineeringQuestion> questions;
        private List<EngineeringQuestion> selectedQuestions;
        private Random rand;

        public EngineeringQuestionManager()
        {
            rand = new Random();

            InitializeQuestions();
            SelectRandomQuestions();
        }

        private void InitializeQuestions()
        {
            questions = new List<EngineeringQuestion>
            {
                // Engineering Question 1
                new EngineeringQuestion
                {
                    Question = "What is the primary function of a capacitor in an electronic circuit?",
                    Options = new List<string> { "A. Store electrical charge", "B. Amplify signals", "C. Control current flow", "D. Generate heat" },
                    CorrectOption = 'A'
                },

                // Engineering Question 2
                new EngineeringQuestion
                {
                    Question = "Which material is commonly used as a semiconductor in electronics?",
                    Options = new List<string> { "A. Copper", "B. Aluminum", "C. Silicon", "D. Gold" },
                    CorrectOption = 'C'
                },

                // Engineering Question 3
new EngineeringQuestion
{
    Question = "What is the purpose of a flywheel in mechanical engineering?",
    Options = new List<string> { "A. Store energy", "B. Generate electricity", "C. Control vibrations", "D. Increase friction" },
    CorrectOption = 'A'
},

// Engineering Question 4
new EngineeringQuestion
{
    Question = "Which engineering discipline deals with the design and construction of structures?",
    Options = new List<string> { "A. Mechanical engineering", "B. Civil engineering", "C. Electrical engineering", "D. Aerospace engineering" },
    CorrectOption = 'B'
},

// Engineering Question 5
new EngineeringQuestion
{
    Question = "What is the SI unit of force?",
    Options = new List<string> { "A. Newton", "B. Watt", "C. Joule", "D. Pascal" },
    CorrectOption = 'A'
},

// Engineering Question 6
new EngineeringQuestion
{
    Question = "Which material is commonly used as a lubricant in mechanical systems?",
    Options = new List<string> { "A. Graphite", "B. Copper", "C. Aluminum", "D. Silver" },
    CorrectOption = 'A'
},

// Engineering Question 7
new EngineeringQuestion
{
    Question = "What is the function of a diode in electrical circuits?",
    Options = new List<string> { "A. Amplify signals", "B. Control current flow", "C. Store charge", "D. Generate heat" },
    CorrectOption = 'B'
},

// Engineering Question 8
new EngineeringQuestion
{
    Question = "In computer science, what does the acronym 'CPU' stand for?",
    Options = new List<string> { "A. Central Processing Unit", "B. Central Power Unit", "C. Central Programming Unit", "D. Central Peripheral Unit" },
    CorrectOption = 'A'
},

// Engineering Question 9
new EngineeringQuestion
{
    Question = "Which programming language is widely used for web development?",
    Options = new List<string> { "A. Java", "B. C++", "C. Python", "D. JavaScript" },
    CorrectOption = 'D'
},

// Engineering Question 10
new EngineeringQuestion
{
    Question = "What is the primary purpose of a router in computer networks?",
    Options = new List<string> { "A. Connect devices within a local network", "B. Convert digital signals to analog", "C. Block unauthorized access", "D. Amplify signals" },
    CorrectOption = 'A'
},

// Engineering Question 11
new EngineeringQuestion
{
    Question = "Which material is commonly used as a conductor in electrical wires?",
    Options = new List<string> { "A. Aluminum", "B. Copper", "C. Silver", "D. Gold" },
    CorrectOption = 'B'
},

// Engineering Question 12
new EngineeringQuestion
{
    Question = "What is the purpose of a heat exchanger in thermal systems?",
    Options = new List<string> { "A. Generate electricity", "B. Control temperature", "C. Convert light to heat", "D. Increase pressure" },
    CorrectOption = 'B'
},

// Engineering Question 13
new EngineeringQuestion
{
    Question = "Which engineering discipline focuses on the design and optimization of industrial processes?",
    Options = new List<string> { "A. Chemical engineering", "B. Environmental engineering", "C. Biomedical engineering", "D. Materials engineering" },
    CorrectOption = 'A'
},

// Engineering Question 14
new EngineeringQuestion
{
    Question = "What is the purpose of a gearbox in mechanical systems?",
    Options = new List<string> { "A. Store energy", "B. Amplify signals", "C. Control speed and torque", "D. Convert thermal energy" },
    CorrectOption = 'C'
},

// Engineering Question 15
new EngineeringQuestion
{
    Question = "In electrical engineering, what is the unit of electrical resistance?",
    Options = new List<string> { "A. Ohm", "B. Watt", "C. Volt", "D. Ampere" },
    CorrectOption = 'A'
},

// Engineering Question 16
new EngineeringQuestion
{
    Question = "Which engineering discipline involves the study of fluid flow and its applications?",
    Options = new List<string> { "A. Mechanical engineering", "B. Aerospace engineering", "C. Chemical engineering", "D. Civil engineering" },
    CorrectOption = 'C'
},
            };
        }

        private void SelectRandomQuestions()
        {
            selectedQuestions = questions.OrderBy(q => rand.Next()).Take(10).ToList();
        }

        public List<EngineeringQuestion> GetRandomQuestions()
        {
            return selectedQuestions;
        }

        public char GetCorrectOption(int questionIndex)
        {
            return selectedQuestions[questionIndex].CorrectOption;
        }
    }

    public partial class Engineering : Window
    {
        private EngineeringQuestionManager questionManager;

        public Engineering()
        {
            InitializeComponent();
            questionManager = new EngineeringQuestionManager();
            DisplayRandomQuestions();
        }

        private void DisplayRandomQuestions()
        {
            List<EngineeringQuestion> allQuestions = questionManager.GetRandomQuestions();

            List<EngineeringQuestion> randomQuestions = allQuestions.Take(10).ToList();

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
