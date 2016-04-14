using System;
using System.Linq;
class Program
{
    static void Main()
    {
        string text = Console.ReadLine().ToLower();

        int[] countsymbols = new int[text.Max() + 1];

        foreach (var VARIABLE in text)
        {
            countsymbols[VARIABLE]++;
        }
        for (int i = 0; i < countsymbols.Length; i++)
        {
            if (countsymbols[i] != 0)
            {
                Console.WriteLine("{0} -> {1}", (char)i, countsymbols[i]);
            }
        }
    }
}

