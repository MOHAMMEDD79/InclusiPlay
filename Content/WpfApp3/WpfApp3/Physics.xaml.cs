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
    public class PhysicsQuestion
    {
        public string Question { get; set; }
        public List<string> Options { get; set; }
        public char CorrectOption { get; set; }
    }

    public class PhysicsQuestionManager
    {
        private List<PhysicsQuestion> questions;
        private List<PhysicsQuestion> selectedQuestions;
        private Random rand;

        public PhysicsQuestionManager()
        {
            rand = new Random();

            InitializeQuestions();
            SelectRandomQuestions();
        }

        private void InitializeQuestions()
        {
            questions = new List<PhysicsQuestion>
            {
                // Physics Question 1
                new PhysicsQuestion
                {
                    Question = "What is the SI unit of force?",
                    Options = new List<string> { "A. Newton", "B. Joule", "C. Watt", "D. Pascal" },
                    CorrectOption = 'A'
                },

                // Physics Question 2
                new PhysicsQuestion
                {
                    Question = "Which law states that an object at rest will stay at rest, and an object in motion will stay in motion with the same speed and in the same direction unless acted upon by an unbalanced external force?",
                    Options = new List<string> { "A. Newton's First Law", "B. Newton's Second Law", "C. Newton's Third Law", "D. Law of Conservation of Energy" },
                    CorrectOption = 'A'
                },

// Physics Question 3
new PhysicsQuestion
{
    Question = "What is the formula for calculating work in physics?",
    Options = new List<string> { "A. W = mgh", "B. W = Fd", "C. W = Pt", "D. W = QV" },
    CorrectOption = 'B'
},

// Physics Question 4
new PhysicsQuestion
{
    Question = "Which type of energy is associated with the motion of an object?",
    Options = new List<string> { "A. Potential energy", "B. Thermal energy", "C. Kinetic energy", "D. Chemical energy" },
    CorrectOption = 'C'
},

// Physics Question 5
new PhysicsQuestion
{
    Question = "What is the unit of measurement for electric current?",
    Options = new List<string> { "A. Volt", "B. Ampere", "C. Watt", "D. Ohm" },
    CorrectOption = 'B'
},

// Physics Question 6
new PhysicsQuestion
{
    Question = "According to Einstein's theory of relativity, what is the relationship between mass and energy?",
    Options = new List<string> { "A. Mass and energy are unrelated", "B. Mass increases with energy", "C. Mass decreases with energy", "D. Mass is equal to energy" },
    CorrectOption = 'D'
},

// Physics Question 7
new PhysicsQuestion
{
    Question = "Which law states that the total energy of an isolated system remains constant over time?",
    Options = new List<string> { "A. Newton's First Law", "B. Law of Conservation of Energy", "C. Newton's Second Law", "D. Law of Inertia" },
    CorrectOption = 'B'
},

// Physics Question 8
new PhysicsQuestion
{
    Question = "What is the speed of light in a vacuum?",
    Options = new List<string> { "A. 300,000 km/s", "B. 150,000 km/s", "C. 1,000,000 km/s", "D. 500,000 km/s" },
    CorrectOption = 'A'
},

// Physics Question 9
new PhysicsQuestion
{
    Question = "Which force is responsible for keeping planets in orbit around the sun?",
    Options = new List<string> { "A. Gravitational force", "B. Electromagnetic force", "C. Strong nuclear force", "D. Weak nuclear force" },
    CorrectOption = 'A'
},

// Physics Question 10
new PhysicsQuestion
{
    Question = "What is the unit of measurement for frequency?",
    Options = new List<string> { "A. Hertz", "B. Watt", "C. Newton", "D. Pascal" },
    CorrectOption = 'A'
},

// Physics Question 11
new PhysicsQuestion
{
    Question = "What is the principle of conservation of momentum?",
    Options = new List<string> { "A. The total momentum of an isolated system is constant", "B. Momentum depends on the reference frame", "C. Momentum is always zero", "D. Momentum is inversely proportional to velocity" },
    CorrectOption = 'A'
},

// Physics Question 12
new PhysicsQuestion
{
    Question = "What is the formula for calculating power in physics?",
    Options = new List<string> { "A. P = Fd", "B. P = mgh", "C. P = W/t", "D. P = QV" },
    CorrectOption = 'C'
},

// Physics Question 13
new PhysicsQuestion
{
    Question = "Which of the following is an example of a simple machine?",
    Options = new List<string> { "A. Lever", "B. Electron", "C. Neutron", "D. Quark" },
    CorrectOption = 'A'
},

// Physics Question 14
new PhysicsQuestion
{
    Question = "What is the phenomenon where a sound wave reflects off a surface?",
    Options = new List<string> { "A. Refraction", "B. Diffraction", "C. Reflection", "D. Interference" },
    CorrectOption = 'C'
},

// Physics Question 15
new PhysicsQuestion
{
    Question = "Which type of lens converges light?",
    Options = new List<string> { "A. Convex lens", "B. Concave lens", "C. Plano-convex lens", "D. Plano-concave lens" },
    CorrectOption = 'A'
},

// Physics Question 16
new PhysicsQuestion
{
    Question = "What is the resistance of an ideal conductor at absolute zero temperature?",
    Options = new List<string> { "A. Infinite resistance", "B. Zero resistance", "C. Negative resistance", "D. Constant resistance" },
    CorrectOption = 'B'
},
            new PhysicsQuestion
{
    Question = "Who is the inventor of the atomic bomb?",
    Options = new List<string> { "A. Albert Einstein", "B. J. Robert Oppenheimer", "C. Niels Bohr", "D. Marie Curie" },
    CorrectOption = 'B'
},

// Physics Question 18
new PhysicsQuestion
{
    Question = "Who is the inventor of electricity?",
    Options = new List<string> { "A. Thomas Edison", "B. Nikola Tesla", "C. Benjamin Franklin", "D. Michael Faraday" },
    CorrectOption = 'D'
},

// Physics Question 19
new PhysicsQuestion
{
    Question = "Who is the discoverer of gravity?",
    Options = new List<string> { "A. Isaac Newton", "B. Galileo Galilei", "C. Johannes Kepler", "D. Albert Einstein" },
    CorrectOption = 'A'
},
new PhysicsQuestion
{
    Question = "Who is Nikola Tesla?",
    Options = new List<string> { "A. Physicist", "B. Inventor", "C. Engineer", "D. All of the above" },
    CorrectOption = 'D'
},
        };
        }

        private void SelectRandomQuestions()
        {
            selectedQuestions = questions.OrderBy(q => rand.Next()).Take(10).ToList();
        }

        public List<PhysicsQuestion> GetRandomQuestions()
        {
            return selectedQuestions;
        }

        public char GetCorrectOption(int questionIndex)
        {
            return selectedQuestions[questionIndex].CorrectOption;
        }
    }

    public partial class Physics : Window
    {
        private PhysicsQuestionManager questionManager;

        public Physics()
        {
            InitializeComponent();
            questionManager = new PhysicsQuestionManager();
            DisplayRandomQuestions();
        }

        private void DisplayRandomQuestions()
        {
            List<PhysicsQuestion> allQuestions = questionManager.GetRandomQuestions();

            List<PhysicsQuestion> randomQuestions = allQuestions.Take(10).ToList();

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
