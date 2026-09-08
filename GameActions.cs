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
        if (CheckRows(grid, playerSymbol))
        {
            return true;
        }

        if (CheckColumns(grid, playerSymbol))
        {
            return true;
        }

        if (CheckFirstDiagonal(grid, playerSymbol))
        {
            return true;
        }

        if (CheckSecondDiagonal(grid, playerSymbol))
        {
            return true;
        }

        return false;
    }

    
    
    public static bool CheckRows(char[,] grid, char playerSymbol)
    {
        int gridSize = grid.GetLength(0);

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

        return false;
    }
    
    public static bool CheckColumns(char[,] grid, char playerSymbol)
    {
        int gridSize = grid.GetLength(0);

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

        return false;
    }
    
    public static bool CheckFirstDiagonal(char[,] grid, char playerSymbol)
    {
        int gridSize = grid.GetLength(0);

        for (int index = 0; index < gridSize; index++)
        {
            if (grid[index, index] != playerSymbol)
            {
                return false;
            }
        }

        return true;
    }
    
    public static bool CheckSecondDiagonal(char[,] grid, char playerSymbol)
    {
        int gridSize = grid.GetLength(0);

        for (int index = 0; index < gridSize; index++)
        {
            if (grid[index, gridSize - 1 - index] != playerSymbol)
            {
                return false;
            }
        }

        return true;
    }
    
    public static bool CheckAiPlayerWon(char[,] grid, char aiSymbol)
    {
        if (CheckRows(grid, aiSymbol))
        {
            return true;
        }

        if (CheckColumns(grid, aiSymbol))
        {
            return true;
        }

        if (CheckFirstDiagonal(grid, aiSymbol))
        {
            return true;
        }

        if (CheckSecondDiagonal(grid, aiSymbol))
        {
            return true;
        }

        return false;
    }
}