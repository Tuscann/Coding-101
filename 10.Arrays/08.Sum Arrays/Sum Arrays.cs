using System;
using System.Linq;
class Program
{
    static void Main()
    {
        var arr1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        var arr2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        var n = Math.Max(arr1.Length, arr2.Length);
        var sumArr = new int[n];
        for (int i = 0; i < n; i++)
            sumArr[i] = arr1[i % arr1.Length] + arr2[i % arr2.Length];
        
        Console.WriteLine(string.Join(" ", sumArr));
    }
}

