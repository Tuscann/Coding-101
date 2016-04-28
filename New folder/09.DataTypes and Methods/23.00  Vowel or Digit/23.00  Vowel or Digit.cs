using System;
class Program
{
    static void Main()
    {
        string input = Console.ReadLine();

        if (input == "a" || input == "o" || input == "e" || input == "i" || input == "u" || input == "y")
        {
            Console.WriteLine("vowel");
        }
        else if (input == "1" || input == "2" || input == "3" || input == "4" || input == "5" || input == "6" || input == "7" || input == "8" || input == "9" || input == "0")
        {
            Console.WriteLine("digit");
        }
        else
        {
            Console.WriteLine("It’s another symbol");
        }
    }
}
