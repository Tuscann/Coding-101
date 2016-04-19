using System;
using System.Collections.Generic;
class MagicStrings
{
    static string PrintResult(char[] a, char[] b)
    {
        string result = "";
        foreach (var digit in a)
        {
            switch (digit)
            {
                case '1': result += "k"; break;
                case '4': result += "n"; break;
                case '5': result += "p"; break;
                case '3': result += "s"; break;
            }
        }

        foreach (var digit in b)
        {
            switch (digit)
            {
                case '1': result += "k"; break;
                case '4': result += "n"; break;
                case '5': result += "p"; break;
                case '3': result += "s"; break;
            }
        }
        return result;
    }

    static void Main()
    {
        int count = 0;
        int diff = Int32.Parse(Console.ReadLine());
        int diffTempo = 0;
        List<string> end = new List<string>();

        for (int i = 1111; i < 5556; i++)
        {
            char[] left = i.ToString().ToCharArray();

            if (left[0] > '0' && left[0] < '6' && left[0] != '2' && left[1] > '0' && left[1] < '6' && left[1] != '2' && left[2] > '0' && left[2] < '6' && left[2] != '2' && left[3] > '0' && left[3] < '6' && left[3] != '2')
            {
                for (int j = 1111; j < 5556; j++)
                {
                    char[] right = j.ToString().ToCharArray();

                    if (right[0] > '0' && right[0] < '6' && right[0] != '2' && right[1] > '0' && right[1] < '6' && right[1] != '2' && right[2] > '0' && right[2] < '6' && right[2] != '2' && right[3] > '0' && right[3] < '6' && right[3] != '2')
                    {
                        diffTempo = left[0] + left[1] + left[2] + left[3] - right[0] - right[1] - right[2] - right[3];
                        if (diffTempo == diff || diffTempo == -diff)
                        {
                            end.Add(PrintResult(left, right));
                            count++;
                        }
                    }
                }
            }
        }
        if (count == 0)
        {
            Console.WriteLine("No"); return;
        }
        end.Sort();
        foreach (var item in end)
        {
            Console.WriteLine(item);
        }
    }
}