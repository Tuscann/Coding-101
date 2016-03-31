using System;
using System.Linq;
class Program
{
    static void Main()
    {
        var n = long.Parse(Console.ReadLine());
        var nums = new int[n];

        for (long i = 0; i < n; i++)
        {
            nums[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Sum = {0}", nums.Sum());
        Console.WriteLine("Min = {0}", nums.Min());
        Console.WriteLine("Max = {0}", nums.Max());
        Console.WriteLine("First = {0}", nums[0]);
        Console.WriteLine("Last = {0}", nums[n - 1]);
        Console.WriteLine("Average = {0}", nums.Average());
      
    }
}

