using System;
using System.Collections.Generic;
class Palindromes
{
    static string Reverse(string s)
    {
        char[] charArray = s.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    static void Main()
    {
        string[] input = Console.ReadLine().Split(new char[] { ',', ':', ';', ' ', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);
        List<string> sortedOutput = new List<string>();
        for (int i = 0; i < input.Length; i++)
        {
            string reversed = Reverse(input[i]);
            if (input[i] == reversed)
            {
                sortedOutput.Add(input[i]);
            }
        }
        sortedOutput.Sort();
        Console.WriteLine("[{0}]", string.Join(", ", sortedOutput));
    }
}