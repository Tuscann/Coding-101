using System;
public class GameOfLife
{
    public static void Main()
    {
        int[] board = new int[10];
        int[] boardCopy = new int[10];

        int countOfLiveCells = int.Parse(Console.ReadLine());

        for (int i = 0; i < countOfLiveCells; i++)
        {
            int row = int.Parse(Console.ReadLine());
            int column = int.Parse(Console.ReadLine());

            board[row] |= 1 << column;
            boardCopy[row] |= 1 << column;
        }

        for (int row = 0; row < boardCopy.Length; row++)
        {
            for (int col = 0; col < boardCopy.Length; col++)
            {
                ChangeCellValue(boardCopy, board, row, col);
            }
        }

        PrintBoard(board);
    }

    private static void ChangeCellValue(int[] boardCopy, int[] board, int row, int column)
    {
        int currentBitValue = (boardCopy[row] >> column) & 1;
        int numberOfLiveNeighbours = GetNumberOfLiveNeighbours(boardCopy, row, column);

        if (currentBitValue == 1)
        {
            if (numberOfLiveNeighbours < 2 || 3 < numberOfLiveNeighbours)
            {
                board[row] &= ~(1 << column);
            }
        }
        else
        {
            if (numberOfLiveNeighbours == 3)
            {
                board[row] |= 1 << column;
            }
        }
    }

    private static int GetNumberOfLiveNeighbours(int[] boardCopy, int row, int column)
    {
        int startRow = Math.Max(0, row - 1);
        int endRow = Math.Min(boardCopy.Length - 1, row + 1);
        int startCol = Math.Max(0, column - 1);
        int endCol = Math.Min(boardCopy.Length - 1, column + 1);

        int countOfLiveNeighbours = 0;

        for (int i = startRow; i <= endRow; i++)
        {
            for (int j = startCol; j <= endCol; j++)
            {
                if (i == row && j == column)
                {
                    continue;
                }

                if (((boardCopy[i] >> j) & 1) == 1)
                {
                    countOfLiveNeighbours++;
                }
            }
        }

        return countOfLiveNeighbours;
    }

    private static void PrintBoard(int[] board)
    {
        foreach (var row in board)
        {
            Console.WriteLine(Convert.ToString(row, 2).PadLeft(10, '0'));
        }
    }
}