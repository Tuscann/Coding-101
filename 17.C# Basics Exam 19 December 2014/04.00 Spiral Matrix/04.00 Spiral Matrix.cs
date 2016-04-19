using System;
using System.Linq;
class SpiralMatrix
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        string input = Console.ReadLine().ToLower();

        int[][] matrix = new int[size][];

        for (int i = 0; i < size; i++)
        {
            matrix[i] = new int[size];
        }

        int row = 0;
        int col = 0;
        int letterIndex = 0;

        while (letterIndex < size * size)
        {
            while (col < size && matrix[row][col] == 0)
            {
                matrix[row][col] = input[letterIndex % input.Length];
                col++;
                letterIndex++;
            }

            col--;
            row++;

            while (row < size && matrix[row][col] == 0)
            {
                matrix[row][col] = input[letterIndex % input.Length];
                row++;
                letterIndex++;
            }

            row--;
            col--;

            while (col >= 0 && matrix[row][col] == 0)
            {
                matrix[row][col] = input[letterIndex % input.Length];
                col--;
                letterIndex++;
            }

            col++;
            row--;

            while (row >= 0 && matrix[row][col] == 0)
            {
                matrix[row][col] = input[letterIndex % input.Length];
                row--;
                letterIndex++;
            }

            row++;
            col++;
        }

        int maxSum = 0;
        int maxIndex = 0;

        for (int i = 0; i < size; i++)
        {
            int currentSum = matrix[i].Sum();
            if (currentSum > maxSum)
            {
                maxSum = currentSum;
                maxIndex = i;
            }
        }

        maxSum -= ('a' - 1) * size;
        maxSum *= 10;

        Console.WriteLine("{0} - {1}", maxIndex, maxSum);
    }
}