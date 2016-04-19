using System;
using System.Collections.Generic;
internal class FiveSpecialLetters
{
    private static char[] letters = new char[] { 'a', 'b', 'c', 'd', 'e' };
    public static bool hasMach = false;
    public static string result;

    private static void Main()
    {
        int start = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());
        generate(start, end);
        if (!hasMach)
        {
            Console.WriteLine("No");
        }
        else
        {
            Console.WriteLine(result);
        }
    }

    private static void generate(int start, int end)
    {
        for (int a = 0; a < letters.Length; a++)
        {
            for (int b = 0; b < letters.Length; b++)
            {
                for (int c = 0; c < letters.Length; c++)
                {
                    for (int d = 0; d < letters.Length; d++)
                    {
                        for (int e = 0; e < letters.Length; e++)
                        {
                            string toTest = "" + letters[a] + letters[b] + letters[c] + letters[d] + letters[e];
                            int weight = calcWeight(toTest);
                            if (weight >= start && weight <= end)
                            {
                                if (string.IsNullOrEmpty(result))
                                {
                                    result = toTest;
                                }
                                else
                                {
                                    result = result + " " + toTest;
                                }
                                hasMach = true;
                            }
                        }
                    }
                }
            }
        }
    }

    private static int calcWeight(string x)
    {
        int weight = 0;
        int multiplier = 1;
        x = cleanDublicates(x);
        foreach (char item in x)
        {
            switch (item)
            {
                case 'a':
                    weight += multiplier * 5; multiplier++;
                    break;

                case 'b':
                    weight += multiplier * -12; multiplier++;
                    break;

                case 'c':
                    weight += multiplier * 47; multiplier++;
                    break;

                case 'd':
                    weight += multiplier * 7; multiplier++;
                    break;

                case 'e':
                    weight += multiplier * -32; multiplier++;
                    break;

                default:
                    break;
            }
        }
        return weight;
    }

    private static string cleanDublicates(string x)
    {
        List<char> chr = new List<char>();
        foreach (char item in x)
        {
            if (chr.Contains(item))
            {
                continue;
            }
            chr.Add(item);
        }
        string toCheck = "";
        foreach (var item in chr)
        {
            toCheck = toCheck + item;
        }
        return toCheck;
    }
}