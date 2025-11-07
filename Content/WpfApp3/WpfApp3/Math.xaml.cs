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

    public class MathQuestion
    {
        public string Question { get; set; }
        public List<string> Options { get; set; }
        public char CorrectOption { get; set; }
    }

    public class MathQuestionManager
    {
        private List<MathQuestion> questions;
        private List<MathQuestion> selectedQuestions;
        private Random rand;  // Move Random object to the class level

        public MathQuestionManager()
        {
            rand = new Random();

            InitializeQuestions();
            SelectRandomQuestions();
        }

        private void InitializeQuestions()
        {
            questions = new List<MathQuestion>
            {
              // Question 1
new MathQuestion
{
    Question = "What is the result of 12 * 3 - 4 / 2?",
    Options = new List<string> { "A. 32", "B. 34", "C. 36", "D. 38" },
    CorrectOption = 'B'
},

// Question 2
new MathQuestion
{
    Question = "Evaluate: √(16) + 2^3 =",
    Options = new List<string> { "A. 12", "B. 14", "C. 16", "D. 18" },
    CorrectOption = 'A'
},

// Question 3
new MathQuestion
{
    Question = "Solve for x: 2x + 5 = 17",
    Options = new List<string> { "A. 6", "B. 7", "C. 8", "D. 9" },
    CorrectOption = 'A'
},

// Question 4
new MathQuestion
{
    Question = "Find the value of: sin(30°) + cos(60°)",
    Options = new List<string> { "A. √3/2", "B. 1", "C. 3/2", "D. 1/2" },
    CorrectOption = 'B'
},

// Question 5
new MathQuestion
{
    Question = "If a = 4 and b = 7, what is the value of a² + b²?",
    Options = new List<string> { "A. 45", "B. 53", "C. 65", "D. 55" },
    CorrectOption = 'C'
},

// Question 6
new MathQuestion
{
    Question = "Solve the equation: 2^(x-1) = 8",
    Options = new List<string> { "A. 2", "B. 3", "C. 4", "D. 5" },
    CorrectOption = 'C'
},



// Question 7
new MathQuestion
{
    Question = "Evaluate: log₂(16) + √(9)",
    Options = new List<string> { "A. 8", "B. 10", "C. 12", "D. 7" },
    CorrectOption = 'D'
},

// Question 8
new MathQuestion
{
    Question = "If a triangle has angles of 60°, 70°, and 50°, what type of triangle is it?",
    Options = new List<string> { "A. Equilateral", "B. Isosceles", "C. Scalene", "D. Right-angled" },
    CorrectOption = 'C'
},

// Question 9
new MathQuestion
{
    Question = "Solve for x: cos(x) = 0.5",
    Options = new List<string> { "A. π/3", "B. π/4", "C. π/6", "D. π/2" },
    CorrectOption = 'A'
},

// Question 10
new MathQuestion
{
    Question = "If f(x) = 2x² + 3x - 5, what is f'(x)?",
    Options = new List<string> { "A. 4x + 3", "B. 2x + 3", "C. 4x - 3", "D. 2x - 3" },
    CorrectOption = 'A'
},



              // Question 11
new MathQuestion
{
    Question = "Evaluate: ∫(3x² + 2x)dx from 0 to 2",
    Options = new List<string> { "A. 12", "B. 16", "C. 20", "D. 24" },
    CorrectOption = 'A'
},

// Question 12
new MathQuestion
{
    Question = "Solve the system of equations: 2x + y = 5 and x - y = 1",
    Options = new List<string> { "A. x = 2, y = 3", "B. x = 3, y = 2", "C. x = 1, y = 4", "D. x = 4, y = 1" },
    CorrectOption = 'B'
},

// Question 13
new MathQuestion
{
    Question = "Find the sum of the first 10 terms of the arithmetic sequence: 3, 7, 11, ...",
    Options = new List<string> { "A. 300", "B. 320", "C. 340", "D. 210" },
    CorrectOption = 'B'
},

// Question 14
new MathQuestion
{
    Question = "If log₃(x) = 2, what is the value of x?",
    Options = new List<string> { "A. 3", "B. 9", "C. 27", "D. 81" },
    CorrectOption = 'B'
},

// Question 15
new MathQuestion
{
    Question = "Calculate the determinant of the matrix: |[1 2 3; 4 5 6; 7 8 9]|",
    Options = new List<string> { "A. 0", "B. 1", "C. 2", "D. 3" },
    CorrectOption = 'A'
},

// Question 16
new MathQuestion
{
    Question = "Solve for x: e^(2x) = 8",
    Options = new List<string> { "A. 2 * ln(4)", "B. 1.5 * ln(2)", "C. 0.5 * ln(8)", "D. ln(16)" },
    CorrectOption = 'B'
},


        };
            }

        private void SelectRandomQuestions()
        {
            selectedQuestions = questions.OrderBy(q => rand.Next()).Take(10).ToList();

        }

        public List<MathQuestion> GetRandomQuestions()
        {
            return selectedQuestions;
        }

        public char GetCorrectOption(int questionIndex)
        {
            return selectedQuestions[questionIndex].CorrectOption;
        }
    }

    public partial class Math : Window
    {
        private MathQuestionManager questionManager;

        public Math()
        {
            InitializeComponent();
            questionManager = new MathQuestionManager();
            DisplayRandomQuestions();
        }

        private void DisplayRandomQuestions()
        {
            List<MathQuestion> allQuestions = questionManager.GetRandomQuestions();

            // Select and display only the first 10 questions
            List<MathQuestion> randomQuestions = allQuestions.Take(10).ToList();

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