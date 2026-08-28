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
        // Ask Player to input symbol at required position
        Console.Write("Enter row: ");
        int rowInput = int.Parse(Console.ReadLine());

        Console.Write("Enter column: ");
        int columnInput = int.Parse(Console.ReadLine());

        grid[rowInput, columnInput] = 'X';
        
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
        
        
    }
}