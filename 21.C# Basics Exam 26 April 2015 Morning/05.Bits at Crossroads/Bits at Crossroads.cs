using System;

public class BitsAtCrossroads
{
    public static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        int[] matrix = new int[size];
        int numberOfCrossroads = 0;

        string command = Console.ReadLine();

        while (command != "end")
        {
            int row = int.Parse(command.Split()[0]);
            int column = int.Parse(command.Split()[1]);

            numberOfCrossroads++;

            matrix[row] |= 1 << column;

            // top-left
            FillPath(row - 1, column + 1, matrix, -1, 1, ref numberOfCrossroads);

            // bottom-right
            FillPath(row + 1, column - 1, matrix, 1, -1, ref numberOfCrossroads);

            // bottom-left
            FillPath(row + 1, column + 1, matrix, 1, 1, ref numberOfCrossroads);

            // top-right
            FillPath(row - 1, column - 1, matrix, -1, -1, ref numberOfCrossroads);

            command = Console.ReadLine();
        }

        foreach (var number in matrix)
        {
            Console.WriteLine((uint)number);
        }

        Console.WriteLine(numberOfCrossroads);
    }

    private static void FillPath(
        int currentRow,
        int currentColumn,
        int[] matrix,
        int rowUpdate,
        int colUpdate,
        ref int numberOfCrossroads)
    {
        while (AreCoordinatesValid(currentRow, currentColumn, matrix.Length))
        {
            if (((matrix[currentRow] >> currentColumn) & 1) == 1)
            {
                numberOfCrossroads++;
            }

            matrix[currentRow] |= 1 << currentColumn;

            currentRow += rowUpdate;
            currentColumn += colUpdate;
        }
    }

    private static bool AreCoordinatesValid(int row, int col, int size)
    {
        bool isRowValid = 0 <= row && row < size;
        bool isColumnValid = 0 <= col && col < size;

        return isRowValid && isColumnValid;
    }
}