using System;
class Program
{
    static void Main()
    {
        int rows = int.Parse(Console.ReadLine());
        int cols = int.Parse(Console.ReadLine());
        var matrix = new char[rows, cols];

        char letter ='A';
        
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = letter++;
            }
        }
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols - 1; col++)
                Console.Write(matrix[row, col] + " ");
            Console.WriteLine(matrix[row, cols - 1]);
        }
    }
}
