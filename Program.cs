namespace TicTacToe;

class Program
{
    const int FIRST_RANDOM_NUMBER = 0;
    const int SECOND_RANDOM_NUMBER = 3;

    static void Main(string[] args)
    {
        char[,] grid = GridData.CreateGrid();
        UIMethods.DisplayGrid(grid);
        UIMethods.LineSeperator();

        bool gameOver = false;
        int moves = 0;

        while (!gameOver)
        {
            // Ask Player to input symbol at required position
            int playerRow = UIMethods.GetPlayerRowInput();
            int playerColumn = UIMethods.GetPlayerColumnInput();
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

            GameActions.PlayerMakeMove(grid, playerRow, playerColumn, 'X');
            UIMethods.DisplayGrid(grid);
            var playerWon = GameActions.CheckPlayerWon(grid, playerRow, playerColumn, 'X');
            if (playerWon)
            {
                UIMethods.PrintPlayerWins();
                gameOver = true;
                continue;
            }

            if (GameActions.CheckPlayerDrawsWithAi(moves) == 9)
            {
                UIMethods.PrintPlayerDraws();
                gameOver = true;
                continue;
            }

            // AI turn
            Random random = new Random();
            int aiRow = random.Next(FIRST_RANDOM_NUMBER, SECOND_RANDOM_NUMBER);
            int aiColumn = random.Next(FIRST_RANDOM_NUMBER, SECOND_RANDOM_NUMBER);
            do
            {
                aiRow = random.Next(FIRST_RANDOM_NUMBER, SECOND_RANDOM_NUMBER);
                aiColumn = random.Next(FIRST_RANDOM_NUMBER, SECOND_RANDOM_NUMBER);
            } while (grid[aiRow, aiColumn] != ' ');

            AIActions.AIMakeMove(grid, '0', aiRow, aiColumn);
            moves++;

            UIMethods.LineSeperator();
            UIMethods.DisplayGrid(grid);
            UIMethods.LineSeperator();

            var aiWon = GameActions.CheckAIPlayerWon(grid, aiRow, aiColumn, '0');
            if (aiWon)
            {
                UIMethods.PrintAIPlayerWins();
                gameOver = true;
            }
        }
    }
}