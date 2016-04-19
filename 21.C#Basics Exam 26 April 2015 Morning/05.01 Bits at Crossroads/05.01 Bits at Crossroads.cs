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

            int currentRow = row - 1;
            int currentColumn = column + 1;

            // top-left
            while (0 <= currentRow && currentRow < size && 0 <= currentColumn && currentColumn < size)
            {
                if (((matrix[currentRow] >> currentColumn) & 1) == 1)
                {
                    numberOfCrossroads++;
                }

                matrix[currentRow] |= 1 << currentColumn;

                currentRow--;
                currentColumn++;
            }

            currentRow = row + 1;
            currentColumn = column - 1;

            // bottom-right
            while (0 <= currentRow && currentRow < size && 0 <= currentColumn && currentColumn < size)
            {
                if (((matrix[currentRow] >> currentColumn) & 1) == 1)
                {
                    numberOfCrossroads++;
                }

                matrix[currentRow] |= 1 << currentColumn;

                currentRow++;
                currentColumn--;
            }

            currentRow = row + 1;
            currentColumn = column + 1;

            // bottom-left
            while (0 <= currentRow && currentRow < size && 0 <= currentColumn && currentColumn < size)
            {
                if (((matrix[currentRow] >> currentColumn) & 1) == 1)
                {
                    numberOfCrossroads++;
                }

                matrix[currentRow] |= 1 << currentColumn;

                currentRow++;
                currentColumn++;
            }

            currentRow = row - 1;
            currentColumn = column - 1;

            // top-right
            while (0 <= currentRow && currentRow < size && 0 <= currentColumn && currentColumn < size)
            {
                if (((matrix[currentRow] >> currentColumn) & 1) == 1)
                {
                    numberOfCrossroads++;
                }

                matrix[currentRow] |= 1 << currentColumn;

                currentRow--;
                currentColumn--;
            }

            command = Console.ReadLine();
        }

        foreach (var number in matrix)
        {
            Console.WriteLine((uint)number);
        }

        Console.WriteLine(numberOfCrossroads);
    }
}