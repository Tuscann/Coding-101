using System;
namespace PlaidTowel
{
    class Program
    {
        static void PrintColumns(int columns, int size, int row, string rhombusStr, string backgroundStr)
        {
            for (int col = 0; col < columns; col++)
            {
                if (col == size - row || col == (size * 3) - row
                    || col == size + row || col == (size * 3) + row)
                {Console.Write(rhombusStr);}
                else
                {Console.Write(backgroundStr);}
            }
            Console.WriteLine();
        }

        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            string backgroundSymbol = Console.ReadLine();
            string rhombusSymbol = Console.ReadLine();
            int width = 4 * number + 1;
            for (int row = 0; row <= number; row++)
            {
                PrintColumns(width, number, row, rhombusSymbol, backgroundSymbol);
            }
            for (int row = number - 1; row > 0; row--)
            {
                PrintColumns(width, number, row, rhombusSymbol, backgroundSymbol);
            }
            for (int row = 0; row <= number; row++)
            {
                PrintColumns(width, number, row, rhombusSymbol, backgroundSymbol);
            }
            for (int row = number - 1; row >= 0; row--)
            {
                PrintColumns(width, number, row, rhombusSymbol, backgroundSymbol);
            }
        }
    }
}