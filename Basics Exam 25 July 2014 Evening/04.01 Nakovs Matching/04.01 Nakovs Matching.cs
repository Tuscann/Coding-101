/* Problem 4 – Nakovs Matching
We are given two words a and b. Each word can be split in several ways into left and right side:
•	a = (aLeft|aRight)
•	b = (bLeft|bRight)
The weight w(s) of given character sequence s is calculated as sum of the ASCII codes of its characters. 
 * The Nakov's distance between two split words (aLeft|aRight) and (bLeft|bRight) is defined as:
•	nakovs = w(aLeft) * w(bRight) - w(aRight) * w(bLeft), as absolute value
We assume that two word splits have good matching if their Nakov's difference is not greater than given limit number d. 
 * Your task is to write a program that prints all good matchings between given two words a and b and given limit number d.
Example: a = "hello", b = "csharp", d = 20000. The word a can be split in 4 ways: "h|ello", "he|llo","hel|lo" and "hell|o". 
 * The word b can be split in 5 ways: "c|sharp", "cs|harp", "csh|arp", "csha|rp" and "cshar|p". 
 * There are 20 possible matchings between the words a and b, but only 3 of them are good matchings (nakovs ≤ d):
(h|ello) matches (c|sharp) by 13996 nakovs	w(h) = 104, w(ello) = 428, w(c) = 99, w(sharp) = 542
nakovs = abs(104 * 542 - 428 * 99) = 13996 ≤ 20000
(he|llo) matches (cs|harp) by 17557 nakovs	w(he) = 205, w(llo) = 327, w(cs) = 214, w(harp) = 427
nakovs = abs(205 * 427 - 327 * 214) = 17557 ≤ 20000
(hell|o) matches (cshar|p) by 11567 nakovs	w(hell) = 421, w(o) = 111, w(cshar) = 529, w(p) = 112
nakovs = abs(421 * 112 - 529 * 111) = 11567 ≤ 20000
Your task is to write a program that enters a, b and d and prints on the console all good matchings between a and b.
Input
The input data should be read from the console. It consists of 3 lines:
•	The first line hold the first string.
•	The second line holds the second string.
•	The third line holds the limit number d.
The input data will always be valid and in the format described. There is no need to check it explicitly.
Output
Print on the console all good matchings between these two words in format "(aLeft|aRight) matches (bLeft|bRight) by XXX nakovs",
 * each at separate line. The order of the output lines is not important. Print "No" if no good matchings are found.
Constraints
•	The input words a and b consist of small Latin letters only. The length of the words is in the range [2…20].
•	The number d is integer in the range [0…5 000 000].
 */

using System;
class NakovsMatching
{
    static void Main()
    {
        string first = Console.ReadLine().ToLower();
        string second = Console.ReadLine().ToLower();

        int D = int.Parse(Console.ReadLine());
        int count = 0;

        for (int i = 0; i < first.Length - 1; i++)
        {
            string a = first.Substring(0, i + 1);
            string b = first.Substring(i + 1);
            int wA = CalcWeight(a);
            int wB = CalcWeight(b);

            for (int j = 0; j < second.Length - 1; j++)
            {
                string c = second.Substring(0, j + 1);
                string d = second.Substring(j + 1);
                int wC = CalcWeight(c);
                int wD = CalcWeight(d);

                int match = Math.Abs(wA * wD - wB * wC);
                if (match <= D)
                {
                    Console.WriteLine("({0}|{1}) matches ({2}|{3}) by {4} nakovs", a, b, c, d, match);
                    count++;
                }
            }
        }

        if (count == 0)
        {
            Console.WriteLine("No");
        }
    }

    private static int CalcWeight(string s)
    {
        char[] arr = s.ToCharArray();

        int weight = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            weight += arr[i];
        }
        return weight;
    }
}