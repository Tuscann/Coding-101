/* Magic Strings
This problem is from Variant 3 of C# Basics exam from 11-04-2014 Morning.  You can test your solution here .
You are given a number diff. Write a program to generate all sequences of 8 letters, each from the set { 's', 'n', 'k', 'p' }, such that the weight of the first 4 letters differs from the weight of the second 4 letters exactly by diff. These sequences are called “magic strings”. Print them in alphabetical order.
The weight of a single letter is calculated as follows:  weight('s') = 3; weight('n') = 4;  weight('k') = 1;  weight('p') = 5. The weight of a sequence of 4 letters is the calculated as sum of the weights of these 4 individual letters.
Input
•	The input data should be read from the console.
•	The number diff stays at the first line.
The input data will always be valid and in the format described. There is no need to check it explicitly.
Output
The output should be printed on the console as a sequence of strings in alphabetical order. Each string should stay on a separate line. In case no magic strings exist, print “No”.
 */

using System;
using System.Collections.Generic;
using System.Linq;

class MagicStrings
{
    static void Main()
    {
        // input
        int diff = int.Parse(Console.ReadLine());
        string[] combinations1 = CombinationsWithRepition("ksnp", 4).ToArray();
        string[] combinations = CombinationsWithRepition("1345", 4).ToArray();
        int[] numbers = combinations.Select(int.Parse).ToArray();
        List<string> results = new List<string>();

        Dictionary<int, List<string>> possibleSums = PossibleSums(combinations1, numbers);

        if (diff > 16)
        {
            Console.WriteLine("No");
            return;
        }
        for (int i = 4; i <= 20; i++)
        {
            int index = i + diff;
            if (i != 5 && possibleSums.ContainsKey(index))
            {
                for (int j = 0; j < possibleSums[i].Count; j++)
                {
                    for (int k = 0; k < possibleSums[index].Count; k++)
                    {
                        if (diff == 0)
                        {
                            results.Add(possibleSums[i][j] + possibleSums[index][k]);
                        }
                        else
                        {
                            results.Add(possibleSums[i][j] + possibleSums[index][k]);
                            results.Add(possibleSums[index][k] + possibleSums[i][j]);
                        }

                    }
                }
            }
        }

        results.Sort();

        foreach (string item in results)
        {
            Console.WriteLine(item);
        }
    }

    private static Dictionary<int, List<string>> PossibleSums(string[] combinations1, int[] numbers)
    {
        Dictionary<int, List<string>> possibleSums = new Dictionary<int, List<string>>();

        for (int i = 0; i < numbers.Length; i++)
        {
            int sum = DigitSum(numbers[i]);
            if (!possibleSums.ContainsKey(sum))
            {
                possibleSums.Add(sum, new List<string> { combinations1[i] });
            }
            else
            {
                possibleSums[sum].Add(combinations1[i]);
            }
        }
        return possibleSums;
    }

    private static int DigitSum(int value)
    {
        int sum = 0;
        while (value != 0)
        {
            int remainder;
            value = Math.DivRem(value, 10, out remainder);
            sum += remainder;
        }
        return sum;
    }

    #region Create all combinations with repetitions 4 choose 4
    static String Convert(string symbols, int number, int totalLen)
    {
        var result = "";
        var len = symbols.Length;
        var nullSym = symbols[0];
        while (number > 0)
        {
            var index = number % len;
            number = number / len;
            result = symbols[index] + result;
        }
        return result.PadLeft(totalLen, nullSym);
    }

    static IEnumerable<String> CombinationsWithRepition(string symbols, int len)
    {
        for (var i = 0; i < Math.Pow(symbols.Length, len); i++)
            yield return Convert(symbols, i, len);
    }

    #endregion

}

