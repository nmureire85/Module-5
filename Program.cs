namespace TicTacToe;

class Program
{
    
    static void Main(string[] args)
    {
        char[,] grid = GameActions.CreateGrid(5);
        UIMethods.DisplayGrid(grid);
        UIMethods.ApplyLineSeperator();

        bool gameOver = false;
        int moves = 0;
        Random random = new Random();   
        while (!gameOver)
        {
            int playerRow = UIMethods.GetPlayerRowInput(5);
            int playerColumn = UIMethods.GetPlayerColumnInput(5);
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
            var playerWon = GameActions.CheckPlayerWon(grid,  'X');
            if (playerWon)
            {
                UIMethods.PrintPlayerWins();
                gameOver = true;
                continue;
            }

            int gridSize = grid.GetLength(0);
            int totalCells = gridSize * gridSize;
            if (moves == totalCells)
            {
                UIMethods.PrintPlayerDraws();
                gameOver = true;
                continue;
            }
            int aiRow;
            int aiColumn;

            do
            {
                aiRow = random.Next(gridSize);
                aiColumn = random.Next(gridSize);
            }
            while (grid[aiRow, aiColumn] != ' ');

            AIActions.AIMakeMove(grid, '0', aiRow, aiColumn);
            moves++;

            UIMethods.ApplyLineSeperator();
            UIMethods.DisplayGrid(grid);
            UIMethods.ApplyLineSeperator();

            var aiWon = GameActions.CheckAiPlayerWon(grid,  '0');
            if (aiWon)
            {
                UIMethods.PrintAIPlayerWins();
                gameOver = true;
            }
        }
    }
}