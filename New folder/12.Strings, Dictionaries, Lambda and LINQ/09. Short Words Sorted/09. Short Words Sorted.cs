using System;
using System.Linq;
class Program
{
    static void Main()
    {
        var result = Console.ReadLine().
            Split(".,:;()[]\"'!? ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
            .Where(word => word.Length < 5)
            .OrderBy(word => word)
            .Select(word => word.ToLower())
            .Distinct()
            .ToList();

        Console.WriteLine(string.Join(", ", result));
    }
}