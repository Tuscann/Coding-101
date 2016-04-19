using System;
class Program
{
    static void Main()
    {
        var firstWord = Console.ReadLine().ToLower();
        var secondWord = Console.ReadLine().ToLower();
        if (firstWord == secondWord)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}

