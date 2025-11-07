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
using System.Windows.Shapes;

namespace WpfApp3
{
    public class IslamicQuestion
    {
        public string Question { get; set; }
        public List<string> Options { get; set; }
        public char CorrectOption { get; set; }
    }

    public class IslamicQuestionManager
    {
        private List<IslamicQuestion> questions;
        private List<IslamicQuestion> selectedQuestions;
        private Random rand;  // Move Random object to the class level

        public IslamicQuestionManager()
        {
            rand = new Random();

            InitializeQuestions();
            SelectRandomQuestions();
        }

        private void InitializeQuestions()
        {
            questions = new List<IslamicQuestion>
            {
                // Question 1
                new IslamicQuestion
                {
                    Question = "ما هو الشهر الذي يأتي بعد شهر رمضان؟",
                    Options = new List<string> { "أ. شوال", "ب. ذو القعدة", "ج. ذو الحجة", "د. محرم" },
                    CorrectOption = 'A'
                },

                // Question 2
                new IslamicQuestion
                {
                    Question = "ما هو الكتاب المقدس في الإسلام؟",
                    Options = new List<string> { "أ. التوراة", "ب. الإنجيل", "ج. القرآن", "د. الزبور" },
                    CorrectOption = 'C'
                },

                // Question 3
                new IslamicQuestion
                {
                    Question = "من هو النبي الذي بُنيت معبده الأقصى للمسلمين؟",
                    Options = new List<string> { "أ. نوح", "ب. إبراهيم", "ج. داود", "د. سليمان" },
                    CorrectOption = 'D'
                },

                // Question 4
                new IslamicQuestion
                {
                    Question = "ما هو أول شهر في التقويم الهجري؟",
                    Options = new List<string> { "أ. محرم", "ب. رجب", "ج. صفر", "د. شعبان" },
                    CorrectOption = 'A'
                },

                // Question 5
                new IslamicQuestion
                {
                    Question = "ما هو عدد أركان الإسلام؟",
                    Options = new List<string> { "أ. 3", "ب. 4", "ج. 5", "د. 6" },
                    CorrectOption = 'C'
                },

                // Question 6
                new IslamicQuestion
                {
                    Question = "ما هي أول كلمة نزلت من القرآن؟",
                    Options = new List<string> { "أ. اقْرَأْ", "ب. ابْتَرَكَت", "ج. اسْمَعْ", "د. يا أيها الإنسان" },
                    CorrectOption = 'A'
                },

                // Question 7
                new IslamicQuestion
                {
                    Question = "من هو الصحابي الذي قال للنبي محمد: 'أخبرني عن الإسلام'؟",
                    Options = new List<string> { "أ. أبو بكر", "ب. علي بن أبي طالب", "ج. عثمان بن عفان", "د. عبد الله بن مسعود" },
                    CorrectOption = 'A'
                },

                // Question 8
                new IslamicQuestion
                {
                    Question = "ما هو أكبر عيد في الإسلام؟",
                    Options = new List<string> { "أ. عيد الفطر", "ب. عيد الأضحى", "ج. عيد الغدير", "د. عيد المولد النبوي" },
                    CorrectOption = 'B'
                },

                // Question 9
                new IslamicQuestion
                {
                    Question = "من هو النبي الذي بُعث إلى قوم عاد؟",
                    Options = new List<string> { "أ. نوح", "ب. هود", "ج. صالح", "د. لوط" },
                    CorrectOption = 'C'
                },

                // Question 10
                new IslamicQuestion
                {
                    Question = "ما هو الصوم الذي يُعتبر صوم القلوب؟",
                    Options = new List<string> { "أ. صوم رمضان", "ب. صوم النذر", "ج. صوم الأيام البيض", "د. صوم الصدقة" },
                    CorrectOption = 'A'
                },

                // Question 11
                new IslamicQuestion
                {
                    Question = "من هو النبي الذي بُعث إلى قوم مدين؟",
                    Options = new List<string> { "أ. هود", "ب. صالح", "ج. شعيب", "د. لوط" },
                    CorrectOption = 'C'
                },

                // Question 12
                new IslamicQuestion
                {
                    Question = "من هو النبي الذي أُرسل إلى قوم عماد؟",
                    Options = new List<string> { "أ. هود", "ب. صالح", "ج. شعيب", "د. لوط" },
                    CorrectOption = 'D'
                },

                // Question 13
                new IslamicQuestion
                {
                    Question = "ما هو السورة التي تُسمى 'قلب القرآن'؟",
                    Options = new List<string> { "أ. الفاتحة", "ب. البقرة", "ج. العصر", "د. الرحمن" },
                    CorrectOption = 'B'
                },

                // Question 14
                new IslamicQuestion
                {
                    Question = "من هو النبي الذي بُعث إلى قوم ثمود؟",
                    Options = new List<string> { "أ. نوح", "ب. هود", "ج. صالح", "د. إسماعيل" },
                    CorrectOption = 'C'
                },

                // Question 15
                new IslamicQuestion
                {
                    Question = "ما هو الشهر الذي يتم فيه صيام يوم عاشوراء؟",
                    Options = new List<string> { "أ. رمضان", "ب. شعبان", "ج. محرم", "د. ذو الحجة" },
                    CorrectOption = 'C'
                },

                // Question 16
                new IslamicQuestion
                {
                    Question = "من هو أول خليفة للنبي محمد؟",
                    Options = new List<string> { "أ. أبو بكر الصديق", "ب. علي بن أبي طالب", "ج. عمر بن الخطاب", "د. عثمان بن عفان" },
                    CorrectOption = 'A'
                },
            };
        }

        private void SelectRandomQuestions()
        {
            selectedQuestions = questions.OrderBy(q => rand.Next()).Take(10).ToList();

        }

        public List<IslamicQuestion> GetRandomQuestions()
        {
            return selectedQuestions;
        }

        public char GetCorrectOption(int questionIndex)
        {
            return selectedQuestions[questionIndex].CorrectOption;
        }
    }

    public partial class Islam : Window
    {
        private IslamicQuestionManager questionManager;

        public Islam()
        {
            InitializeComponent();
            questionManager = new IslamicQuestionManager();
            DisplayRandomQuestions();
        }

        private void DisplayRandomQuestions()
        {
            List<IslamicQuestion> allQuestions = questionManager.GetRandomQuestions();

            // Select and display only the first 10 questions
            List<IslamicQuestion> randomQuestions = allQuestions.Take(10).ToList();

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
