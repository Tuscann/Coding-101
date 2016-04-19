using System;
using System.Collections.Generic;
using System.Linq;

class Five
{
    static void Main()
    {
        int[,] matrix = new int[8, 8];

        //InitialiseMatrix(matrix);
        Console.WriteLine();

        string input = "";
        int row = 0;
        int col = 7;

        matrix[0, 7] = 1;

        //command loop
        while (true)
        {
            input = Console.ReadLine();

            if (input == "stop")
                break;

            //commands
            if (input == "left up" && row > 0 && col > 1)
            {
                row = row - 1;
                col = col - 2;

                matrix[row, col] = ExchangeValue(matrix, row, col);
            }
            else if (input == "left down" && row < 7 && col > 1)
            {

                row = row + 1;
                col = col - 2;

                matrix[row, col] = ExchangeValue(matrix, row, col);
            }
            else if (input == "right up" && row > 0 && col < 6)
            {
                row = row - 1;
                col = col + 2;

                matrix[row, col] = ExchangeValue(matrix, row, col);
            }
            else if (input == "right down" && row < 7 && col < 6)
            {
                row = row + 1;
                col = col + 2;

                matrix[row, col] = ExchangeValue(matrix, row, col);
            }
            else if (input == "up left" && row > 1 && col > 0)
            {
                row = row - 2;
                col = col - 1;

                matrix[row, col] = ExchangeValue(matrix, row, col);
            }
            else if (input == "up right" && row > 1 && col > 0)
            {
                row = row - 2;
                col = col + 1;

                matrix[row, col] = ExchangeValue(matrix, row, col);
            }
            else if (input == "down left" && row < 6 && col > 0)
            {
                row = row + 2;
                col = col - 1;

                matrix[row, col] = ExchangeValue(matrix, row, col);
            }
            else if (input == "down right" && row < 6 && col < 7)
            {
                row = row + 2;
                col = col + 1;

                matrix[row, col] = ExchangeValue(matrix, row, col);
            }
            else
            {
                continue;
            }
            // InitialiseMatrix(matrix);
        }

        //InitialiseMatrix(matrix);

        for (int i = 0; i < 8; i++)
        {
            Result(matrix, i);
        }

        int emptyCounter = 0;

        for (int rows = 0; rows < 8; rows++)
        {
            for (int cols = 0; cols < 8; cols++)
            {
                emptyCounter += matrix[rows, cols];
            }

        }

        if (emptyCounter == 0)
        {
            Console.WriteLine("[Board is empty]");
        }
    }

    public static void InitialiseMatrix(int[,] matrix)
    {
        for (int row = 0; row < 8; row++)
        {
            for (int col = 0; col < 8; col++)
            {
                Console.Write(matrix[row, col] + " ");
            }
            Console.WriteLine();
        }
    }

    public static void Result(int[,] matrix, int row)
    {
        int result = 0;
        int counter = 0;

        for (int i = 7; i > -1; i--)
        {
            result = ExchangeBits(result, counter, matrix[row, i]);
            counter++;
        }

        //InitialiseMatrix(matrix);
        if (result != 0)
        {
            Console.WriteLine(result);
        }
    }

    public static int ExchangeValue(int[,] matrix, int row, int col)
    {
        if (matrix[row, col] == 1)
        {
            return 0;
        }
        else if (matrix[row, col] == 0)
        {
            return 1;
        }
        else return 100;
    }


    public static int GetBits(int number, int position)
    {
        int newPosition = number >> position;
        int bit = newPosition & 1;

        // Console.WriteLine(bit);

        return bit;
    }

    public static int ExchangeBits(int number, int position, int value)
    {
        int result = 0;

        if (value == 0)
        {
            int mask = ~(1 << position);
            result = number & mask;

        }
        else
        {
            int mask = 1 << position;
            result = number | mask;
        }

        return result;
    }

}