using System;

class Tetris
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split(' ');
        int rowInput = int.Parse(input[0]);
        int colInput = int.Parse(input[1]);
        char[,] matrix = new char[rowInput, colInput];
        string inpuLine;
        int row, col = new int();
        for (row = 0; row < rowInput; row++)
        {
            inpuLine = Console.ReadLine();
            for (col = 0; col < colInput; col++)
            {
                matrix[row, col] = inpuLine[col];
                // Console.Write("{0}",matrix[row, col]);
            }
            // Console.WriteLine();
        }
        int countI = 0;
        int countL = 0;
        int countJ = 0;
        int countO = 0;
        int countZ = 0;
        int countS = 0;
        int countT = 0;
        for (row = 0; row < rowInput; row++)
        {
            for (col = 0; col < colInput; col++)
            {
                countI += CountShape(matrix, row, col, row + 1, col, row + 2, col, row + 3, col);
                countL += CountShape(matrix, row, col, row + 1, col, row + 2, col, row + 2, col + 1);
                countJ += CountShape(matrix, row, col, row + 1, col, row + 2, col, row + 2, col - 1);
                countO += CountShape(matrix, row, col, row + 1, col, row, col + 1, row + 1, col + 1);
                countZ += CountShape(matrix, row, col, row, col + 1, row + 1, col + 1, row + 1, col + 2);
                countS += CountShape(matrix, row, col, row, col + 1, row - 1, col + 1, row - 1, col + 2);
                countT += CountShape(matrix, row, col, row, col + 1, row + 1, col + 1, row, col + 2);
            }
        }
        Console.WriteLine("I:{0}, L:{1}, J:{2}, O:{3}, Z:{4}, S:{5}, T:{6}", countI, countL, countJ, countO, countZ, countS, countT);
    }


    private static int CountShape(char[,] matrix, int row1, int col1, int row2, int col2, int row3, int col3, int row4, int col4)
    {
        int count = 0;
        if (row1 >= 0 && row1 < matrix.GetLength(0) && row2 >= 0 && row2 < matrix.GetLength(0) &&
            row3 >= 0 && row3 < matrix.GetLength(0) && row4 >= 0 && row4 < matrix.GetLength(0) &&
            col1 >= 0 && col1 < matrix.GetLength(1) && col2 >= 0 && col2 < matrix.GetLength(1)
            && col3 >= 0 && col3 < matrix.GetLength(1) && col4 >= 0 && col4 < matrix.GetLength(1))
        {
            if (matrix[row1, col1] == 'o' && matrix[row2, col2] == 'o' &&
            matrix[row3, col3] == 'o' && matrix[row4, col4] == 'o')
            {
                count = 1;
            }
        }
        return count;
    }
}