using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    private static IList<int> numbers = new List<int>();

    static void Main(string[] args)
    {
        Console.Write("Count of numbers:");

        int x = int.Parse(Console.ReadLine());

        for (int i = 0; i < x; i++)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            numbers.Add(number);
        }

        int minNumber = numbers.Min();
        Console.WriteLine("The smallest number is {0}.", minNumber);
    }
}