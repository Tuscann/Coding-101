using System;
using System.Linq;

class Program
{
    static void Main()
    {

        int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int k = arr.Length/4;
        var rowLeft = arr.Take(k).Reverse();
        var rowRight = arr.Reverse().Take(k);
        
        Console.WriteLine(string.Join("  ",rowLeft));
        Console.WriteLine(string.Join("  ", rowRight));

        //var row1 = rowLeft.Concat(rowRight).ToArray();
        //var row2 = arr.Skip(k).Take(2 * k).ToArray();
        //var sumArr = row1.Select((x, index) => x + row2[index]);
        //Console.WriteLine(string.Join(" ", sumArr));




    }
}

