using System;

namespace MinesweeperConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            const int gridSize = 8;
            const int totalMines = 10;
            const int initialLives = 3;

            char[,] grid = new char[gridSize, gridSize];
            bool[,] mines = new bool[gridSize, gridSize];
            Random random = new Random();

            // Initialize grid and place mines
            for (int i = 0; i < gridSize; i++)
            {
                for (int j = 0; j < gridSize; j++)
                {
                    grid[i, j] = '.';
                    mines[i, j] = false;
                }
            }

            for (int i = 0; i < totalMines; i++)
            {
                int mineRow, mineCol;
                do
                {
                    mineRow = random.Next(gridSize);
                    mineCol = random.Next(gridSize);
                } while (mines[mineRow, mineCol]);
                mines[mineRow, mineCol] = true;
            }

            int playerRow = 0, playerCol = 0;
            int lives = initialLives;
            int moves = 0;

            while (playerRow < gridSize - 1 || playerCol < gridSize - 1)
            {
                Console.Clear();
                Console.WriteLine("Minesweeper Game");
                Console.WriteLine($"Lives: {lives} | Moves: {moves}");
                Console.WriteLine("Grid:");

                for (int i = 0; i < gridSize; i++)
                {
                    for (int j = 0; j < gridSize; j++)
                    {
                        if (i == playerRow && j == playerCol)
                            Console.Write('P');
                        else
                            Console.Write(grid[i, j]);
                    }
                    Console.WriteLine();
                }

                Console.WriteLine("Enter move (up, down, left, right):");
                string move = Console.ReadLine().ToLower();

                switch (move)
                {
                    case "up":
                        if (playerRow > 0) playerRow--;
                        break;
                    case "down":
                        if (playerRow < gridSize - 1) playerRow++;
                        break;
                    case "left":
                        if (playerCol > 0) playerCol--;
                        break;
                    case "right":
                        if (playerCol < gridSize - 1) playerCol++;
                        break;
                    default:
                        Console.WriteLine("Invalid move. Try again.");
                        continue;
                }

                moves++;

                if (mines[playerRow, playerCol])
                {
                    lives--;
                    Console.WriteLine("You hit a mine! Lives remaining: " + lives);
                    if (lives == 0)
                    {
                        Console.WriteLine("Game Over! You ran out of lives.");
                        return;
                    }
                }

                grid[playerRow, playerCol] = 'X';
            }

            Console.WriteLine("Congratulations! You reached the other side of the board.");
            Console.WriteLine($"Total moves: {moves}");
        }
    }
}
