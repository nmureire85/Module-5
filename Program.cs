namespace TicTacToe;

class Program
{
    static void Main(string[] args)
    {
        //created 3 x 3 grid
        char[,] grid =
        {
            { ' ', ' ', ' ' },
            { ' ', ' ', ' ' },
            { ' ', ' ', ' ' }
        };

       //display empty grid
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

        Console.WriteLine();
        Console.WriteLine();
        
        bool gameOver = false;
        int moves = 0;

        while (!gameOver)
        {
            
            // Ask Player to input symbol at required position
            Console.Write("Enter row (0-2): ");
            int playerRow = int.Parse(Console.ReadLine());

            Console.Write("Enter column (0-2): ");
            int playerColumn = int.Parse(Console.ReadLine());

            // Check if position is empty
            if (grid[playerRow, playerColumn] == ' ')
            {
                grid[playerRow, playerColumn] = 'X';
                moves++;
            }
            else
            {
                Console.WriteLine("That position is already taken.");
                continue;
            }

            grid[playerRow, playerColumn] = 'X';

            //display grid again after user has entered symbol
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

            // AI turn
            Random random = new Random();
            int aiRow = random.Next(0, 3);
            int aiColumn = random.Next(0, 3);

            do
            {
                aiRow = random.Next(0, 3);
                aiColumn = random.Next(0, 3);
            } while (grid[aiRow, aiColumn] != ' ');

            grid[aiRow, aiColumn] = 'O';

            Console.WriteLine();

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
            
            Console.WriteLine();
        }

    }

}