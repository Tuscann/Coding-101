using System;
class Program
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
        for (row = 0; row < rowInput - 3; row++)
        {
            for (col = 0; col < colInput; col++)
            {
                if (matrix[row, col] == 'o' && matrix[row + 1, col] == 'o' &&
                    matrix[row + 2, col] == 'o' && matrix[row + 3, col] == 'o')
                {
                    countI++;
                }
            }
        }
        for (row = 0; row < rowInput - 2; row++)
        {
            for (col = 0; col < colInput - 1; col++)
            {
                if (matrix[row, col] == 'o' && matrix[row + 1, col] == 'o' &&
                    matrix[row + 2, col] == 'o' && matrix[row + 2, col + 1] == 'o')
                {
                    countL++;
                }
            }
        }
        for (row = 0; row < rowInput - 2; row++)
        {
            for (col = 1; col < colInput; col++)
            {
                if (matrix[row, col] == 'o' && matrix[row + 1, col] == 'o' &&
                    matrix[row + 2, col] == 'o' && matrix[row + 2, col - 1] == 'o')
                {
                    countJ++;
                }
            }
        }
        for (row = 0; row < rowInput - 1; row++)
        {
            for (col = 0; col < colInput - 1; col++)
            {
                if (matrix[row, col] == 'o' && matrix[row + 1, col] == 'o' &&
                    matrix[row, col + 1] == 'o' && matrix[row + 1, col + 1] == 'o')
                {
                    countO++;
                }
            }
        }
        for (row = 0; row < rowInput - 1; row++)
        {
            for (col = 0; col < colInput - 2; col++)
            {
                if (matrix[row, col] == 'o' && matrix[row, col + 1] == 'o' &&
                    matrix[row + 1, col + 1] == 'o' && matrix[row + 1, col + 2] == 'o')
                {
                    countZ++;
                }
            }
        }
        for (row = 1; row < rowInput; row++)
        {
            for (col = 0; col < colInput - 2; col++)
            {
                if (matrix[row, col] == 'o' && matrix[row, col + 1] == 'o' &&
                    matrix[row - 1, col + 1] == 'o' && matrix[row - 1, col + 2] == 'o')
                {
                    countS++;
                }
            }
        }
        for (row = 0; row < rowInput - 1; row++)
        {
            for (col = 0; col < colInput - 2; col++)
            {
                if (matrix[row, col] == 'o' && matrix[row, col + 1] == 'o' &&
                    matrix[row + 1, col + 1] == 'o' && matrix[row, col + 2] == 'o')
                {
                    countT++;
                }
            }
        }
        Console.WriteLine("I:{0}, L:{1}, J:{2}, O:{3}, Z:{4}, S:{5}, T:{6}", countI, countL, countJ, countO, countZ, countS, countT);
    }
}