using System.Data;

namespace TicTacToe;

public class GameActions
{
    public static void PlayerMakeMove(char[,] grid, int playerRow, int playerColumn, char symbol)
    {
        grid[playerRow, playerColumn] = symbol;
    }

    public static bool CheckPlayerWon(char[,] grid, int playerRow, int playerColumn, char playersymbol)
    {
        bool playerWon = false;

        for (int row = 0; row < 3; row++)
        {
            if (grid[row, 0] == playersymbol &&
                grid[row, 1] == playersymbol &&
                grid[row, 2] == playersymbol)
            {
                playerWon = true;
            }
        }

        for (int column = 0; column < 3; column++)
        {
            if (grid[0, column] == playersymbol &&
                grid[1, column] == playersymbol &&
                grid[2, column] == playersymbol)
            {
                playerWon = true;
            }
        }

        if (grid[0, 0] == playersymbol &&
            grid[1, 1] == playersymbol &&
            grid[2, 2] == playersymbol)
        {
            playerWon = true;
        }

        if (grid[0, 2] == playersymbol &&
            grid[1, 1] == playersymbol &&
            grid[2, 0] == playersymbol)
        {
            playerWon = true;
        }

        return playerWon;
    }

    public static int CheckPlayerDrawsWithAi(int moves)
    {
        return moves;
    }
    
    public static bool CheckAIPlayerWon(char[,] grid, int playerRow, int playerColumn, char aiSymbol)
    {
        bool aiWon = false;
        for (int row = 0; row < 3; row++)
        {
            if (grid[row, 0] == aiSymbol &&
                grid[row, 1] == aiSymbol &&
                grid[row, 2] == aiSymbol)
            {
                aiWon = true;
            }
        }

        for (int column = 0; column < 3; column++)
        {
            if (grid[0, column] == aiSymbol &&
                grid[1, column] == aiSymbol &&
                grid[2, column] == aiSymbol)
            {
                aiWon = true;
            }
        }

        if (grid[0, 0] == aiSymbol &&
            grid[1, 1] == aiSymbol &&
            grid[2, 2] == aiSymbol)
        {
            aiWon = true;
        }

        if (grid[0, 2] == aiSymbol &&
            grid[1, 1] == aiSymbol &&
            grid[2, 0] == aiSymbol)
        {
            aiWon = true;
        }
        
        return aiWon;
    }
}