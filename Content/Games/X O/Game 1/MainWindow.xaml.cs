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

namespace Game_1
{
    public partial class MainWindow : Window
    {
        private bool isPlayerX = true; // true if it's Player X's turn, false if it's Player O's turn
        private string[,] gameBoard = new string[3, 3];

        public MainWindow()
        {
            InitializeComponent();
            InitializeGameBoard();
        }

        private void InitializeGameBoard()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    gameBoard[i, j] = string.Empty;
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;

            // Check if the button is already clicked or the game is over
            if (button.Content != null && button.Content.ToString() != "" || CheckForWinner())
                return;

            // Set the content of the button based on the current player
            button.Content = isPlayerX ? "X" : "O";

            // Update the game board state
            UpdateGameBoard(button);

            // Switch to the other player's turn
            isPlayerX = !isPlayerX;

            // Check for a winner
            if (CheckForWinner())
            {
                MessageBox.Show($"Player {(isPlayerX ? "O" : "X")} wins!");
                ResetGame();
            }
            else if (IsBoardFull())
            {
                MessageBox.Show("It's a draw!");
                ResetGame();
            }
        }

        private void UpdateGameBoard(Button button)
        {
            int row = Grid.GetRow(button);
            int col = Grid.GetColumn(button);

            gameBoard[row, col] = button.Content.ToString();
        }

        private bool CheckForWinner()
        {
            // Check rows, columns, and diagonals for a winner
            if (CheckLine(0, 0, 0, 1, 0, 2) ||
                CheckLine(1, 0, 1, 1, 1, 2) ||
                CheckLine(2, 0, 2, 1, 2, 2) ||
                CheckLine(0, 0, 1, 0, 2, 0) ||
                CheckLine(0, 1, 1, 1, 2, 1) ||
                CheckLine(0, 2, 1, 2, 2, 2) ||
                CheckLine(0, 0, 1, 1, 2, 2) ||
                CheckLine(0, 2, 1, 1, 2, 0))
            {
                return true;
            }

            return false;
        }

        private bool CheckLine(int row1, int col1, int row2, int col2, int row3, int col3)
        {
            string content1 = gameBoard[row1, col1];
            string content2 = gameBoard[row2, col2];
            string content3 = gameBoard[row3, col3];

            return !string.IsNullOrEmpty(content1) &&
                   content1 == content2 &&
                   content2 == content3;
        }

        private bool IsBoardFull()
        {
            // Check if all positions on the game board are filled
            foreach (string content in gameBoard)
            {
                if (string.IsNullOrEmpty(content))
                {
                    return false;
                }
            }
            return true;
        }

        private void ResetGame()
        {
            // Clear button contents and reset the game board
            foreach (var child in grid.Children)
            {
                if (child is Button btn)
                {
                    btn.Content = "";
                }
            }

            InitializeGameBoard();

            // Reset player turn
            isPlayerX = true;
        }
    }
}
