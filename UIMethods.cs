namespace TicTacToe;

public static class UIMethods
{
    
    public static void DisplayGrid(char[,] grid)
    {
        for (int row = 0; row < 3; row++)
        {
            for (int column = 0; column < 3; column++)
            {
                Console.Write(grid[row, column]);

                if (column < 2)
                {
                    Console.Write(" | ");
                }
            }

            Console.WriteLine();

            if (row < 2)
            {
                Console.WriteLine("---------");
            }
        }
    }

    public static int GetPlayerRowInput()
    {
        while (true)
        {
            Console.Write("Enter row (0-2): ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int playerRow))
            {
                if (playerRow >= 0 && playerRow <= 2)
                {
                    return playerRow;
                }
            }

            Console.WriteLine("Please enter a number between 0 and 2.");
        }
    }

    public static int GetPlayerColumnInput()
    {
        while (true)
        {
            Console.Write("Enter column (0-2): ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int playerColumn))
            {
                if (playerColumn >= 0 && playerColumn <= 2)
                {
                    return playerColumn;
                }
            }

            Console.WriteLine("Please enter a number between 0 and 2.");
        }
    }

    public static void LineSeperator()
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