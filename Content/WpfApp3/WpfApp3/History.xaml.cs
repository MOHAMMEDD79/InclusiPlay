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
    public class HistoryQuestion
    {
        public string Question { get; set; }
        public List<string> Options { get; set; }
        public char CorrectOption { get; set; }
    }

    public class HistoryQuestionManager
    {
        private List<HistoryQuestion> questions;
        private List<HistoryQuestion> selectedQuestions;
        private Random rand;

        public HistoryQuestionManager()
        {
            rand = new Random();

            InitializeQuestions();
            SelectRandomQuestions();
        }

        private void InitializeQuestions()
        {
            questions = new List<HistoryQuestion>
            {
                // History Question 1
                new HistoryQuestion
                {
                    Question = "Who was the first President of the United States?",
                    Options = new List<string> { "A. Thomas Jefferson", "B. John Adams", "C. George Washington", "D. James Madison" },
                    CorrectOption = 'C'
                },

                // History Question 2
                new HistoryQuestion
                {
                    Question = "In which year did Christopher Columbus reach the Americas?",
                    Options = new List<string> { "A. 1492", "B. 1607", "C. 1776", "D. 1498" },
                    CorrectOption = 'A'
                },

              // History Question 3
new HistoryQuestion
{
    Question = "Which war is known as the 'War of Roses'?",
    Options = new List<string> { "A. American Civil War", "B. Hundred Years' War", "C. Wars of the Roses", "D. English Civil War" },
    CorrectOption = 'C'
},

// History Question 4
new HistoryQuestion
{
    Question = "Who was the Egyptian queen famous for her relationships with Julius Caesar and Mark Antony?",
    Options = new List<string> { "A. Cleopatra", "B. Nefertiti", "C. Hatshepsut", "D. Ankhesenamun" },
    CorrectOption = 'A'
},

// History Question 5
new HistoryQuestion
{
    Question = "In which year did the Titanic sink?",
    Options = new List<string> { "A. 1910", "B. 1912", "C. 1915", "D. 1920" },
    CorrectOption = 'B'
},

// History Question 6
new HistoryQuestion
{
    Question = "Who was the first Emperor of China?",
    Options = new List<string> { "A. Qin Shi Huang", "B. Han Wudi", "C. Tang Taizong", "D. Sun Yat-sen" },
    CorrectOption = 'A'
},

// History Question 7
new HistoryQuestion
{
    Question = "What was the significance of the Magna Carta in medieval England?",
    Options = new List<string> { "A. Establishing a constitutional monarchy", "B. Declaring independence", "C. Ending the Hundred Years' War", "D. Establishing the Church of England" },
    CorrectOption = 'A'
},

// History Question 8
new HistoryQuestion
{
    Question = "Who was the author of 'The Communist Manifesto'?",
    Options = new List<string> { "A. Karl Marx", "B. Vladimir Lenin", "C. Joseph Stalin", "D. Friedrich Engels" },
    CorrectOption = 'A'
},

// History Question 9
new HistoryQuestion
{
    Question = "Which ancient civilization built the city of Machu Picchu?",
    Options = new List<string> { "A. Aztecs", "B. Mayans", "C. Incas", "D. Egyptians" },
    CorrectOption = 'C'
},

// History Question 10
new HistoryQuestion
{
    Question = "Who was the first President of the Soviet Union?",
    Options = new List<string> { "A. Vladimir Putin", "B. Joseph Stalin", "C. Nikita Khrushchev", "D. Mikhail Gorbachev" },
    CorrectOption = 'B'
},

// History Question 11
new HistoryQuestion
{
    Question = "Which ancient civilization built the Great Wall of China?",
    Options = new List<string> { "A. Mongols", "B. Han Dynasty", "C. Qin Dynasty", "D. Tang Dynasty" },
    CorrectOption = 'C'
},

// History Question 12
new HistoryQuestion
{
    Question = "In which year did the United States declare its independence?",
    Options = new List<string> { "A. 1765", "B. 1776", "C. 1789", "D. 1804" },
    CorrectOption = 'B'
},

// History Question 13
new HistoryQuestion
{
    Question = "Who was the leader of the Indian independence movement against British rule?",
    Options = new List<string> { "A. Jawaharlal Nehru", "B. Sardar Patel", "C. Mahatma Gandhi", "D. Subhas Chandra Bose" },
    CorrectOption = 'C'
},

// History Question 14
new HistoryQuestion
{
    Question = "What event marked the beginning of World War I?",
    Options = new List<string> { "A. Assassination of Archduke Franz Ferdinand", "B. Treaty of Versailles", "C. Invasion of Poland", "D. Bombing of Hiroshima" },
    CorrectOption = 'A'
},

// History Question 15
new HistoryQuestion
{
    Question = "Who was the first woman to win a Nobel Prize?",
    Options = new List<string> { "A. Marie Curie", "B. Rosalind Franklin", "C. Florence Nightingale", "D. Jane Goodall" },
    CorrectOption = 'A'
},

// History Question 16
new HistoryQuestion
{
    Question = "Which European explorer reached India by sea in 1498?",
    Options = new List<string> { "A. Christopher Columbus", "B. Ferdinand Magellan", "C. Vasco da Gama", "D. Marco Polo" },
    CorrectOption = 'C'
},
            };
        }

        private void SelectRandomQuestions()
        {
            selectedQuestions = questions.OrderBy(q => rand.Next()).Take(10).ToList();
        }

        public List<HistoryQuestion> GetRandomQuestions()
        {
            return selectedQuestions;
        }

        public char GetCorrectOption(int questionIndex)
        {
            return selectedQuestions[questionIndex].CorrectOption;
        }
    }

    public partial class History : Window
    {
        private HistoryQuestionManager questionManager;

        public History()
        {
            InitializeComponent();
            questionManager = new HistoryQuestionManager();
            DisplayRandomQuestions();
        }

        private void DisplayRandomQuestions()
        {
            List<HistoryQuestion> allQuestions = questionManager.GetRandomQuestions();

            List<HistoryQuestion> randomQuestions = allQuestions.Take(10).ToList();

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
