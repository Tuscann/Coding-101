using System;
using System.Linq;

namespace Text_Bombardment
{
    class TextBombardment
    {
        static void Main()
        {
            // Get the matrix params
            string text = Console.ReadLine();
            int cols = int.Parse(Console.ReadLine());
            int rows = text.Length / cols;
            rows += text.Length % cols == 0 ? 0 : 1;

            // Get the bomb params
            string bombs = Console.ReadLine();
            int[] bombCols = bombs.Split(' ').Select(int.Parse).ToArray();

            // Build the matrix with the text
            char[,] matrix = new char[rows, cols];
            for (int row = 0, letter = 0; row < rows; row++)
            {
                for (int col = 0; letter < text.Length && col < cols; col++, letter++)
                {
                    matrix[row, col] = text[letter];
                }
            }

            // Bombard the text
            for (int col = 0; col < bombCols.Length; col++)
            {
                int bombCol = bombCols[col];
                Bombard(matrix, bombCol);
            }

            // Print the remaining text
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    char letter = matrix[row, col];
                    if (letter != '\0')
                    {
                        Console.Write(matrix[row, col]);
                    }
                }
            }
        }

        private static void Bombard(char[,] matrix, int col)
        {
            int startRow = 0;
            int endRow = 0;

            // Get the rows whose cols should be cleared
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                if (matrix[row, col] != ' ')
                {
                    startRow = row;
                    while (row < matrix.GetLength(0) && matrix[row, col] != ' ')
                    {
                        row++;
                    }
                    endRow = row - 1;
                    break;
                }
            }

            // Clear the bombed positions
            int currentRow = startRow;
            while (currentRow <= endRow)
            {
                matrix[currentRow, col] = ' ';
                currentRow++;
            }
        }
    }
}
