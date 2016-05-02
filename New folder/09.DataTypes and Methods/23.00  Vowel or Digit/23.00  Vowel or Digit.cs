using System;
class Program
{
    static void Main()
    {
        char symbol;

        symbol = Convert.ToChar(Console.ReadLine());

        if ((symbol == 'a') || (symbol == 'e') || (symbol == 'i') || (symbol == 'o') || (symbol == 'u'))
        {
            Console.WriteLine("vowel");
        }
        else if ((symbol >= '0') && (symbol <= '9'))
        {
            Console.WriteLine("digit");
        }
        else
        {
            Console.Write("It's another symbol");
        }
    }
}