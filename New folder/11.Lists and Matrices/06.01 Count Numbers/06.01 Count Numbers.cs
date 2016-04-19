using System;
using System.Linq;
class Program
{
    static void Main()
    {
        var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        numbers.Sort();
        var position = 0;
        int currentElement = numbers[0];
        int counter = 1;

        for (int i = 1; i < numbers.Count; i++)
        {
            if (numbers[i] == currentElement)
            {
                counter++;
            }
            else
            {
                Console.WriteLine("{0} -> {1}", currentElement, counter);
                counter = 1;
                currentElement = numbers[i];
            }
        }
        Console.WriteLine("{0} -> {1}", currentElement, counter);
    }
}


