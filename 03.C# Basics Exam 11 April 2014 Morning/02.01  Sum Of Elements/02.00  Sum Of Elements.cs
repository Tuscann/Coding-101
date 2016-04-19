using System;
using System.Linq;
class Program
{
    static void Main()
    {
        long[] numbers = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

        long[] sumNumbers = { numbers.Sum() - numbers.Max() };

        long maxNumber = numbers.Max();

        if (numbers.Sum() - maxNumber == maxNumber)
        {
            Console.WriteLine("Yes, sum={0}", string.Join("", sumNumbers));
        }
        else 
        {
            Console.WriteLine("No, diff={0}", string.Join("", Math.Abs(numbers.Sum() - 2 * maxNumber)));
        }
    }
}

