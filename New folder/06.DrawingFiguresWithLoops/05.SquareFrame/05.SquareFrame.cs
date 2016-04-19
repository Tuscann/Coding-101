using System;

class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        Console.Write(new string('+', 1));
        for (int i = 0; i < number - 2; i++)
        {
            Console.Write(" -");
        }
        Console.WriteLine(" +");

        for (int i = 0; i < number - 2; i++)
        {
            Console.Write(new string('|', 1));
            for (int row = 0; row < number - 2; row++)
            {
                Console.Write(" -");
            }
            Console.WriteLine(" |");
        }
        Console.Write(new string('+', 1));
        for (int i = 0; i < number - 2; i++)
        {
            Console.Write(" -");
        }
        Console.WriteLine(" +");
    }
}

