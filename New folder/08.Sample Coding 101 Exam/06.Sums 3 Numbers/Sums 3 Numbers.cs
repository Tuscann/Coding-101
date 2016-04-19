using System;
class Program
{
    static void Main()
    {
        int first = int.Parse(Console.ReadLine());
        int second = int.Parse(Console.ReadLine());
        int thirt = int.Parse(Console.ReadLine());

        int max = Math.Max(first, Math.Max(second, thirt));
        int min = Math.Min(first, Math.Min(second, thirt));
        int sum = first + second + thirt;
        var middle = sum - max - min;

        if (min + second <= max)
        {
            Console.WriteLine("{0}+{1}={2}", first, second, max);
        }
        else { Console.WriteLine("No"); }
    }
}

