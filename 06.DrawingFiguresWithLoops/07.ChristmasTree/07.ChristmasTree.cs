using System;
class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int numberOfRows = number + 1;
        int lenghtOfRow = 2 * number + 3;

        for (int row = 0; row < numberOfRows; row++)
        {
            int numberOfAsterix = row;
            int numberOfWhiteSpaces = number - numberOfAsterix;

            Console.Write(new string(' ', numberOfWhiteSpaces));
            Console.Write(new string('*', numberOfAsterix));
            Console.Write(" | ");
            Console.Write(new string('*', numberOfAsterix));
            Console.WriteLine(new string(' ', numberOfWhiteSpaces));
        }
    }
}

