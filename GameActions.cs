using System.Data;

namespace TicTacToe;

public class GameActions
{
    
    public static char[,] CreateGrid(int size)
    {
        char[,] grid = new char[size, size];

        for (int row = 0; row < size; row++)
        {
            for (int column = 0; column < size; column++)
            {
                grid[row, column] = ' ';
            }
        }

        return grid;
    }
    
    public static void PlayerMakeMove(char[,] grid, int playerRow, int playerColumn, char symbol)
    {
        grid[playerRow, playerColumn] = symbol;
    }

    public static bool CheckPlayerWon(char[,] grid, char playerSymbol)
    {
        int gridSize = grid.GetLength(0);

        // Check rows
        for (int row = 0; row < gridSize; row++)
        {
            bool rowWon = true;

            for (int column = 0; column < gridSize; column++)
            {
                if (grid[row, column] != playerSymbol)
                {
                    rowWon = false;
                    break;
                }
            }

            if (rowWon)
            {
                return true;
            }
        }

        // Check columns
        for (int column = 0; column < gridSize; column++)
        {
            bool columnWon = true;

            for (int row = 0; row < gridSize; row++)
            {
                if (grid[row, column] != playerSymbol)
                {
                    columnWon = false;
                    break;
                }
            }

            if (columnWon)
            {
                return true;
            }
        }

        // Check first diagonal
        bool firstDiagonalWon = true;

        for (int index = 0; index < gridSize; index++)
        {
            if (grid[index, index] != playerSymbol)
            {
                firstDiagonalWon = false;
                break;
            }
        }

        if (firstDiagonalWon)
        {
            return true;
        }

        // Check second diagonal
        bool secondDiagonalWon = true;

        for (int index = 0; index < gridSize; index++)
        {
            if (grid[index, gridSize - 1 - index] != playerSymbol)
            {
                secondDiagonalWon = false;
                break;
            }
        }

        return secondDiagonalWon;
    }

    public static int CheckPlayerDrawsWithAi(int moves)
    {
        return moves;
    }
    
    
    public static bool CheckAIPlayerWon(char[,] grid, char aiSymbol)
    {
        int gridSize = grid.GetLength(0);
        bool aiWon = false;

        // Check rows
        for (int row = 0; row < gridSize; row++)
        {
            bool rowWon = true;

            for (int column = 0; column < gridSize; column++)
            {
                if (grid[row, column] != aiSymbol)
                {
                    rowWon = false;
                    break;
                }
            }

            if (rowWon)
            {
                aiWon = true;
            }
        }

        // Check columns
        for (int column = 0; column < gridSize; column++)
        {
            bool columnWon = true;

            for (int row = 0; row < gridSize; row++)
            {
                if (grid[row, column] != aiSymbol)
                {
                    columnWon = false;
                    break;
                }
            }

            if (columnWon)
            {
                aiWon = true;
            }
        }

        // Check first diagonal
        bool firstDiagonalWon = true;

        for (int index = 0; index < gridSize; index++)
        {
            if (grid[index, index] != aiSymbol)
            {
                firstDiagonalWon = false;
                break;
            }
        }

        if (firstDiagonalWon)
        {
            aiWon = true;
        }

        // Check second diagonal
        bool secondDiagonalWon = true;

        for (int index = 0; index < gridSize; index++)
        {
            if (grid[index, gridSize - 1 - index] != aiSymbol)
            {
                secondDiagonalWon = false;
                break;
            }
        }

        if (secondDiagonalWon)
        {
            aiWon = true;
        }

        return aiWon;
    }
}