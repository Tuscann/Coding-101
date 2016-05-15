using System;
using System.Linq;
using System.Text.RegularExpressions;
class Palindromes_6
{
    static void Main()
    {
        string words = Console.ReadLine();
        var result = Regex.Matches(words, @"\w+")
            .Cast<Match>()
            .Select(m => m.Value)
            .Reverse()
            .Where(w => String.Join("", w.Reverse()) == w)
            .ToList();
        Console.WriteLine("[{0}]",string.Join(", ", result));
    }
}