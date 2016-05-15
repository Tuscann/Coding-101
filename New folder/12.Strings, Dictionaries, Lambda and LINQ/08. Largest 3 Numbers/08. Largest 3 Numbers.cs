using System;
using System.Linq;
class Program
{
    static void Main()
    {
        var nums = Console.ReadLine().
             Split(' ').
             Select(int.Parse).
             OrderBy(x => -x).Take(3);

        Console.WriteLine(string.Join(" ", nums));
    }
}