namespace TicTacToe;

public class AIActions
{
    
    public static void AIMakeMove(char[,] grid, char symbol, int aiRow, int aiColumn)
    {
        grid[aiRow, aiColumn] = symbol;
    }
}