using System;
using System.Security.Principal;

class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        for (int row = 0; row < number; row++)
        {
            Console.Write(new string(' ', number - row - 1));
            for (int numberOfSymbols = 0; numberOfSymbols <= row; numberOfSymbols++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
        for (int row = number - 1; row > 0; row--)
        {
            Console.Write(new string(' ', number - row));
            for (int numberOfSymbols = row; numberOfSymbols > 0; numberOfSymbols--)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }


    }
}

