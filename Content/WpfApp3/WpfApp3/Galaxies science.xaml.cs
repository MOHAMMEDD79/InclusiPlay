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
    public class GalacticScienceQuestion
    {
        public string Question { get; set; }
        public List<string> Options { get; set; }
        public char CorrectOption { get; set; }
    }

    public class GalacticScienceQuestionManager
    {
        private List<GalacticScienceQuestion> questions;
        private List<GalacticScienceQuestion> selectedQuestions;
        private Random rand;

        public GalacticScienceQuestionManager()
        {
            rand = new Random();

            InitializeQuestions();
            SelectRandomQuestions();
        }

        private void InitializeQuestions()
        {
            questions = new List<GalacticScienceQuestion>
            {
                // Galactic Science Question 1
                new GalacticScienceQuestion
                {
                    Question = "What is the largest planet in our solar system?",
                    Options = new List<string> { "A. Earth", "B. Mars", "C. Jupiter", "D. Saturn" },
                    CorrectOption = 'C'
                },

                // Galactic Science Question 2
                new GalacticScienceQuestion
                {
                    Question = "Which galaxy is home to our solar system?",
                    Options = new List<string> { "A. Andromeda", "B. Milky Way", "C. Triangulum", "D. Pinwheel" },
                    CorrectOption = 'B'
                },

// Galactic Science Question 3
new GalacticScienceQuestion
{
    Question = "Which planet is known as the 'Red Planet'?",
    Options = new List<string> { "A. Venus", "B. Mars", "C. Jupiter", "D. Saturn" },
    CorrectOption = 'B'
},

// Galactic Science Question 4
new GalacticScienceQuestion
{
    Question = "What is the largest moon in our solar system?",
    Options = new List<string> { "A. Titan", "B. Europa", "C. Ganymede", "D. Callisto" },
    CorrectOption = 'C'
},

// Galactic Science Question 5
new GalacticScienceQuestion
{
    Question = "Which spacecraft was the first to reach interstellar space?",
    Options = new List<string> { "A. Voyager 1", "B. Pioneer 10", "C. New Horizons", "D. Juno" },
    CorrectOption = 'A'
},

// Galactic Science Question 6
new GalacticScienceQuestion
{
    Question = "What is the name of the closest star to Earth?",
    Options = new List<string> { "A. Proxima Centauri", "B. Alpha Centauri A", "C. Alpha Centauri B", "D. Sirius" },
    CorrectOption = 'A'
},

// Galactic Science Question 7
new GalacticScienceQuestion
{
    Question = "What is the Kuiper Belt?",
    Options = new List<string> { "A. A region of interstellar gas", "B. A dwarf planet", "C. A belt of asteroids", "D. A region of icy bodies beyond Neptune" },
    CorrectOption = 'D'
},

// Galactic Science Question 8
new GalacticScienceQuestion
{
    Question = "Which galaxy is the nearest spiral galaxy to the Milky Way?",
    Options = new List<string> { "A. Andromeda", "B. Triangulum", "C. Pinwheel", "D. Sculptor" },
    CorrectOption = 'A'
},

// Galactic Science Question 9
new GalacticScienceQuestion
{
    Question = "What is a light-year?",
    Options = new List<string> { "A. A unit of time", "B. A unit of distance", "C. A unit of brightness", "D. A unit of speed" },
    CorrectOption = 'B'
},

// Galactic Science Question 10
new GalacticScienceQuestion
{
    Question = "What is a black hole?",
    Options = new List<string> { "A. A collapsed star", "B. A region of intense gravity", "C. A type of galaxy", "D. A wormhole" },
    CorrectOption = 'B'
},

// Galactic Science Question 11
new GalacticScienceQuestion
{
    Question = "What is dark matter?",
    Options = new List<string> { "A. Matter that emits light", "B. Invisible matter that does not emit light", "C. Antimatter", "D. Dark energy" },
    CorrectOption = 'B'
},

// Galactic Science Question 12
new GalacticScienceQuestion
{
    Question = "Which moon of Saturn is known for its prominent ice geysers?",
    Options = new List<string> { "A. Titan", "B. Enceladus", "C. Mimas", "D. Rhea" },
    CorrectOption = 'B'
},

// Galactic Science Question 13
new GalacticScienceQuestion
{
    Question = "What is the Great Red Spot on Jupiter?",
    Options = new List<string> { "A. A giant storm", "B. A volcano", "C. A desert", "D. A mountain" },
    CorrectOption = 'A'
},

// Galactic Science Question 14
new GalacticScienceQuestion
{
    Question = "Which space telescope has provided valuable images and data about distant galaxies and nebulae?",
    Options = new List<string> { "A. Hubble Space Telescope", "B. Chandra X-ray Observatory", "C. Spitzer Space Telescope", "D. Kepler Space Telescope" },
    CorrectOption = 'A'
},

// Galactic Science Question 15
new GalacticScienceQuestion
{
    Question = "What is the Oort Cloud?",
    Options = new List<string> { "A. A region of comets", "B. A belt of asteroids", "C. A type of galaxy", "D. A planetary system" },
    CorrectOption = 'A'
},

// Galactic Science Question 16
new GalacticScienceQuestion
{
    Question = "What is the main component of the Sun?",
    Options = new List<string> { "A. Helium", "B. Hydrogen", "C. Oxygen", "D. Carbon" },
    CorrectOption = 'B'
},
            // Galactic Science Question 17
new GalacticScienceQuestion
{
    Question = "What is the name of our home galaxy?",
    Options = new List<string> { "A. Pinwheel galaxy", "B. Sombrero", "C. Milky Way", "D. Sunflower Galaxy" },
    CorrectOption = 'C'
},

// Galactic Science Question 18
new GalacticScienceQuestion
{
    Question = "Which of the following galaxies is closest to our galaxy?",
    Options = new List<string> { "A. Andromeda", "B. Tadpole", "C. Cigar", "D. NGC1300" },
    CorrectOption = 'A'
},

// Galactic Science Question 19
new GalacticScienceQuestion
{
    Question = "What is the source of the gravitational force of galaxies?",
    Options = new List<string> { "A. The Magnetic Field", "B. Black Holes", "C. Rotation Factor", "D. None Of The Mentioned" },
    CorrectOption = 'B'
},

// Galactic Science Question 20
new GalacticScienceQuestion
{
    Question = "What is the name of the galaxy cluster to which our galaxy belongs?",
    Options = new List<string> { "A. El Gordo Cluster", "B. Old Rifle Cluster", "C. Pandora Cluster", "D. Virgo Super Cluster" },
    CorrectOption = 'D'
},

// Galactic Science Question 21
new GalacticScienceQuestion
{
    Question = "How fast is a galaxy in the universe?",
    Options = new List<string> { "A. 150km/s", "B. 232.5km/s", "C. 411km/s", "D. 600km/s" },
    CorrectOption = 'B'
},

// Galactic Science Question 22
new GalacticScienceQuestion
{
    Question = "What is the shape of the Andromeda Galaxy?",
    Options = new List<string> { "A. Spiral", "B. Linear", "C. Elliptical", "D. Crooked" },
    CorrectOption = 'A'
},
        };
        }

        private void SelectRandomQuestions()
        {
            selectedQuestions = questions.OrderBy(q => rand.Next()).Take(10).ToList();
        }

        public List<GalacticScienceQuestion> GetRandomQuestions()
        {
            return selectedQuestions;
        }

        public char GetCorrectOption(int questionIndex)
        {
            return selectedQuestions[questionIndex].CorrectOption;
        }
    }

    public partial class Galaxies_science : Window
    {
        private GalacticScienceQuestionManager questionManager;

        public Galaxies_science()
        {
            InitializeComponent();
            questionManager = new GalacticScienceQuestionManager();
            DisplayRandomQuestions();
        }

        private void DisplayRandomQuestions()
        {
            List<GalacticScienceQuestion> allQuestions = questionManager.GetRandomQuestions();

            List<GalacticScienceQuestion> randomQuestions = allQuestions.Take(10).ToList();

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
