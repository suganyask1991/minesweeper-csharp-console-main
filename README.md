# Minesweeper C# Console Edition

This C# console application is a simple implementation of a Minesweeper-style game. The player navigates an 8x8 grid, trying to reach the bottom-right corner while avoiding hidden mines. The player has a limited number of lives and the game tracks the number of moves taken.

gridSize, totalMines, and initialLives are constants defining the size of the grid, the number of mines, and the initial number of lives.
grid is a 2D array representing the game board.
mines is a 2D array indicating the positions of the mines.
random is used to place mines randomly on the grid.

The first nested for loop initializes the grid with '.' and sets all mine positions to false.
The second for loop places totalMines mines randomly on the grid, ensuring no duplicate positions


playerRow and playerCol track the player's position.
lives and moves track the player's remaining lives and the number of moves taken.
The while loop continues until the player reaches the bottom-right corner.
The grid is displayed with the player's position marked by 'P'.


The switch statement handles player movement based on input.
The number of moves is incremented after each valid move.
If the player hits a mine, they lose a life. If lives reach zero, the game ends.
The player's position is marked on the grid with 'X'.

When the player reaches the bottom-right corner, a congratulatory message is displayed along with the total number of moves taken.