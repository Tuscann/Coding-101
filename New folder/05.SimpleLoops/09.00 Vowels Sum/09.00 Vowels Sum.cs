using System;
using System.Linq;

internal class Program
{
    private static void Main()
    {
        string s = Console.ReadLine();

        int sum = 0;
        //foreach (string s in sss)
        //{
        //    if (s == "a") { sum += 1; }
        //    if (s == "e") { sum += 2; }
        //    if (s == "i") { sum += 3; }
        //    if (s == "o") { sum += 4; }
        //    if (s == "u") { sum += 5; }
        //}
        
        for (int a = 0; a < s.Length; a++)
        {
            if (s[a] == 'a') { sum = sum + 1; }
            else if (s[a] == 'e') { sum = sum + 2; }
            else if (s[a] == 'i') { sum = sum + 3; }
            else if (s[a] == 'o') { sum = sum + 4; }
            else if (s[a] == 'u') { sum = sum + 5; }
        }
        Console.WriteLine("{0}", sum);
    }
}

