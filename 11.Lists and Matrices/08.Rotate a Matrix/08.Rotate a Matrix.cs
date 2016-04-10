using System;
using System.Linq;
class Program
{
    static void Main()
    {
        int rows = int.Parse(Console.ReadLine());
        int cols = int.Parse(Console.ReadLine());

        var matrix = new string[rows, cols];
        for (int row = 0; row < rows; row++)
        {
            var cells = Console.ReadLine().Split().ToArray();
            for (int col = 0; col < cols; col++)
            {
                matrix[row, col] = cells[col];
            }
        }
        var rotatedMatrix = new string[matrix.GetLength(1), matrix.GetLength(0)];

        for (int row = 0; row < rotatedMatrix.GetLength(0); row++)
        {
            for (int col = 0; col < rotatedMatrix.GetLength(1); col++)
            {
                rotatedMatrix[row, col] = matrix[matrix.GetLength(0) - 1 - col, row];

                Console.Write(rotatedMatrix[row,col]+" ");
            }
            Console.WriteLine();
        }
    }
}

