using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        var words = Console.ReadLine().ToLower().Split(' ');
        var allWords = new Dictionary<string, int>();

        foreach (var word in words)
            if (!allWords.ContainsKey(word))

                allWords.Add(word, 1);
            else
                allWords[word]++;
        var result = new List<string>();

        foreach (var pair in allWords)
        {
            if (pair.Value % 2 == 1)
            {
                result.Add(pair.Key);
            }
        }
        Console.WriteLine(string.Join(", ", result));
    }
}
