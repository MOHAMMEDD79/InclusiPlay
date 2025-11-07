using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Threading;

namespace WhackAMoleGame
{
    public partial class MainWindow : Window
    {
        private readonly List<Button> moleButtons = new List<Button>();
        private readonly Random random = new Random();
        private int score = 0;
        private int level = 1;
        private DispatcherTimer gameTimer;

        public MainWindow()
        {
            InitializeComponent();
            InitializeMoleButtons();

            gameTimer = new DispatcherTimer();
            gameTimer.Tick += GameTimer_Tick;
            SetTimerInterval();
        }

        private void InitializeMoleButtons()
        {
            int buttonCount = (level == 1) ? 9 : (level == 2) ? 16 : 20;

            for (int i = 0; i < buttonCount; i++)
            {
                var button = new Button
                {
                    Content = FindResource("MoleImage"), // Set mole image as content
                    Width = 80,
                    Height = 40,
                    Tag = false // Indicates whether the mole is currently visible
                };

                button.Click += MoleButton_Click;
                Grid.SetColumn(button, i % 4); // Adjust column count based on level
                Grid.SetRow(button, i / 4);    // Adjust row count based on level
                moleButtons.Add(button);
                gameGrid.Children.Add(button);
            }
        }

        private void MoleButton_Click(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            if ((bool)button.Tag)
            {
                // Player clicked on a visible mole
                score++;
                scoreLabel.Content = $"Score: {score}";
                button.Tag = false;
                button.Content = "";
                if (score == 10 && level == 1)
                {
                    level++;
                    InitializeMoleButtons();
                    SetTimerInterval();
                }
                else if (score == 20 && level == 2)
                {
                    level++;
                    InitializeMoleButtons();
                    SetTimerInterval();
                }
                else if (score == 30 && level == 3)
                {
                    MessageBox.Show($"Congratulations! You won the game with a score of {score}", "Game Over");
                    gameTimer.Stop();
                }
            }
            else
            {
                // Player missed a mole, deduct one point
                if (score > 0)
                {
                    score--;
                    scoreLabel.Content = $"Score: {score}";
                }
            }
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            // Hide any visible moles
            foreach (var button in moleButtons)
            {
                button.Tag = false;
                button.Content = "";
            }

            // Show a mole at a random position
            int moleCount = (level == 1) ? 1 : (level == 2) ? 2 : 2;
            for (int i = 0; i < moleCount; i++)
            {
                var randomIndex = random.Next(moleButtons.Count);
                var moleButton = moleButtons[randomIndex];
                moleButton.Tag = true;
                moleButton.Content = FindResource("MoleImage"); // Set mole image as content
            }

            // Adjust game speed by changing the timer interval
            SetTimerInterval();
        }

        private void SetTimerInterval()
        {
            int interval = (level == 1) ? random.Next(2, 4) : (level == 2) ? random.Next(1, 3) : random.Next(1, 2);
            gameTimer.Interval = TimeSpan.FromSeconds(interval);
        }

        private void startButton_Click(object sender, RoutedEventArgs e)
        {
            score = 0;
            level = 1;
            scoreLabel.Content = "Score: 0";
            gameTimer.Start();
        }

        private void stopButton_Click(object sender, RoutedEventArgs e)
        {
            gameTimer.Stop();
            MessageBox.Show($"Game Over! Your final score is {score}", "Game Over");
        }
    }
}
