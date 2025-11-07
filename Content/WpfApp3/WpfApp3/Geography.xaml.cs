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
    public class GeographyQuestion
    {
        public string Question { get; set; }
        public List<string> Options { get; set; }
        public char CorrectOption { get; set; }
    }

    public class GeographyQuestionManager
    {
        private List<GeographyQuestion> questions;
        private List<GeographyQuestion> selectedQuestions;
        private Random rand;

        public GeographyQuestionManager()
        {
            rand = new Random();

            InitializeQuestions();
            SelectRandomQuestions();
        }

        private void InitializeQuestions()
        {
            questions = new List<GeographyQuestion>
            {
                // Geography Question 1
                new GeographyQuestion
                {
                    Question = "Which river is the longest in the world?",
                    Options = new List<string> { "A. Nile", "B. Amazon", "C. Yangtze", "D. Mississippi" },
                    CorrectOption = 'A'
                },

                // Geography Question 2
                new GeographyQuestion
                {
                    Question = "What is the capital city of Japan?",
                    Options = new List<string> { "A. Beijing", "B. Seoul", "C. Tokyo", "D. Bangkok" },
                    CorrectOption = 'C'
                },

               // Geography Question 3
new GeographyQuestion
{
    Question = "Which mountain is the tallest in the world?",
    Options = new List<string> { "A. Mount Everest", "B. K2", "C. Kangchenjunga", "D. Lhotse" },
    CorrectOption = 'A'
},

// Geography Question 4
new GeographyQuestion
{
    Question = "In which country is the Great Barrier Reef located?",
    Options = new List<string> { "A. Brazil", "B. Australia", "C. Mexico", "D. Thailand" },
    CorrectOption = 'B'
},

// Geography Question 5
new GeographyQuestion
{
    Question = "Which desert is the largest in the world?",
    Options = new List<string> { "A. Sahara Desert", "B. Arabian Desert", "C. Gobi Desert", "D. Antarctic Desert" },
    CorrectOption = 'A'
},

// Geography Question 6
new GeographyQuestion
{
    Question = "What is the capital city of Canada?",
    Options = new List<string> { "A. Toronto", "B. Vancouver", "C. Ottawa", "D. Montreal" },
    CorrectOption = 'C'
},

// Geography Question 7
new GeographyQuestion
{
    Question = "Which river is the longest in Europe?",
    Options = new List<string> { "A. Danube", "B. Thames", "C. Rhine", "D. Volga" },
    CorrectOption = 'D'
},

// Geography Question 8
new GeographyQuestion
{
    Question = "Which ocean is the largest in terms of surface area?",
    Options = new List<string> { "A. Atlantic Ocean", "B. Indian Ocean", "C. Southern Ocean", "D. Pacific Ocean" },
    CorrectOption = 'D'
},

// Geography Question 9
new GeographyQuestion
{
    Question = "In which country is the city of Marrakech located?",
    Options = new List<string> { "A. Egypt", "B. Morocco", "C. South Africa", "D. Turkey" },
    CorrectOption = 'B'
},

// Geography Question 10
new GeographyQuestion
{
    Question = "Which country is known as the 'Land of the Rising Sun'?",
    Options = new List<string> { "A. China", "B. South Korea", "C. Japan", "D. Vietnam" },
    CorrectOption = 'C'
},

// Geography Question 11
new GeographyQuestion
{
    Question = "Which mountain range separates Europe and Asia?",
    Options = new List<string> { "A. Andes", "B. Himalayas", "C. Ural Mountains", "D. Rockies" },
    CorrectOption = 'C'
},

// Geography Question 12
new GeographyQuestion
{
    Question = "What is the largest island in the Mediterranean Sea?",
    Options = new List<string> { "A. Sicily", "B. Sardinia", "C. Crete", "D. Cyprus" },
    CorrectOption = 'A'
},

// Geography Question 13
new GeographyQuestion
{
    Question = "In which country is Mount Kilimanjaro located?",
    Options = new List<string> { "A. Kenya", "B. Tanzania", "C. Uganda", "D. Rwanda" },
    CorrectOption = 'B'
},

// Geography Question 14
new GeographyQuestion
{
    Question = "Which canal connects the Mediterranean Sea to the Red Sea?",
    Options = new List<string> { "A. Panama Canal", "B. Suez Canal", "C. Kiel Canal", "D. Corinth Canal" },
    CorrectOption = 'B'
},

// Geography Question 15
new GeographyQuestion
{
    Question = "Which country is known as the 'Land of Fire and Ice'?",
    Options = new List<string> { "A. New Zealand", "B. Iceland", "C. Greenland", "D. Norway" },
    CorrectOption = 'B'
},

// Geography Question 16
new GeographyQuestion
{
    Question = "What is the capital city of South Africa?",
    Options = new List<string> { "A. Johannesburg", "B. Pretoria", "C. Cape Town", "D. Durban" },
    CorrectOption = 'B'
},
            };
        }

        private void SelectRandomQuestions()
        {
            selectedQuestions = questions.OrderBy(q => rand.Next()).Take(10).ToList();
        }

        public List<GeographyQuestion> GetRandomQuestions()
        {
            return selectedQuestions;
        }

        public char GetCorrectOption(int questionIndex)
        {
            return selectedQuestions[questionIndex].CorrectOption;
        }
    }

    public partial class Geography : Window
    {
        private GeographyQuestionManager questionManager;

        public Geography()
        {
            InitializeComponent();
            questionManager = new GeographyQuestionManager();
            DisplayRandomQuestions();
        }

        private void DisplayRandomQuestions()
        {
            List<GeographyQuestion> allQuestions = questionManager.GetRandomQuestions();

            List<GeographyQuestion> randomQuestions = allQuestions.Take(10).ToList();

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
