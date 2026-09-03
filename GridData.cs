namespace TicTacToe;

public class GridData
{
    public static char[,] CreateGrid()
    {
        char[,] grid =
        {
            { ' ', ' ', ' ' },
            { ' ', ' ', ' ' },
            { ' ', ' ', ' ' }
        };

        return grid;
    }
}