namespace TicTacToe;

public static class UIMethods
{
    
    public static void DisplayGrid(char[,] grid)
    {
        for (int row = 0; row < grid.GetLength(0); row++)
        {
            for (int column = 0; column < grid.GetLength(1); column++)
            {
                Console.Write(grid[row, column]);

                if (column < grid.GetLength(1) - 1)
                {
                    Console.Write(" | ");
                }
            }

            Console.WriteLine();

            if (row < grid.GetLength(0) - 1)
            {
                Console.WriteLine("------------------");
            }
        }
    }

    public static int GetPlayerRowInput(int gridSize)
    {
        while (true)
        {
            Console.Write($"Enter row (0-{gridSize - 1}): ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int playerRow))
            {
                if (playerRow >= 0 && playerRow < gridSize)
                {
                    return playerRow;
                }
            }

            Console.WriteLine($"Please enter a number between 0 and {gridSize - 1}.");
        }
    }

    public static int GetPlayerColumnInput(int gridSize)
    {
        while (true)
        {
            Console.Write($"Enter column (0-{gridSize - 1}): ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int playerColumn))
            {
                if (playerColumn >= 0 && playerColumn < gridSize)
                {
                    return playerColumn;
                }
            }

            Console.WriteLine($"Please enter a number between 0 and {gridSize - 1}.");
        }
    }

    public static void ApplyLineSeperator()
    {
        Console.WriteLine();
        Console.WriteLine();
    }

    public static void PrintPlayerWins()
    {
        Console.WriteLine();
        Console.WriteLine("You win!");
    }
    
    public static void PrintAIPlayerWins()
    {
        Console.WriteLine();
        Console.WriteLine("AI wins!");
    }
    
    public static void PrintPlayerDraws()
    {
        Console.WriteLine();
        Console.WriteLine("It's a draw with AI player!");
    }
}