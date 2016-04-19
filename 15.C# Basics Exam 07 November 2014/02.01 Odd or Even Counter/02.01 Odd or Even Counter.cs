/* Problem 2 – Odd or Even Counter
Petko is bad with numbers. He’s given a task to find and count some, but he has a hard time doing it. He is given N sets of numbers, 
 * and he has to count the odd numbers in each set, and then compare them. The number C shows how many numbers are there in a set. 
 * Then you are given a string S holding one of the words "odd" or "even" showing you what numbers should be counted.  
 * Then you are given N * C numbers representing all sets.
Your task is to count the odd or even numbers in each set, and then say in which set has most S numbers.
The set with most S numbers should be represented as ordinal number word e.g. 
 * "First", "Second", "Third", "Fourth", "Fifth", "Sixth", "Seventh", "Eighth", "Ninth", "Tenth". 
 * If the count of one or more sets is equal, print the first one with biggest count. If there is no set holding odd or even numbers print "No".  
Input
The input data should be read from the console. It consists of three input values, each at separate line:
•	The first line holds an integer N – the count of sets
•	The second line hold an integer C – the count of numbers in each set
•	The third line holds a string S  holding either "odd" or "even" showing what numbers to count
The input data will always be valid and in the format described. There is no need to check it explicitly.
Output
The output data should be printed on the console. It consists of exactly 1 line.
•	Print on the console the following formatted string "{0} set has the most {1} numbers: {2}", 
where {0} is the set as ordinal string {1} is the value of S and {2} is the biggest count of S numbers. If there is no set holding odd or even numbers print "No".   
Constraints
•	N will be an integer number in the range [1...10] 
•	C will be an integer number in the range [1...50] 
•	Each of the numbers in the set will be an integer in the range[-2 147 483 647… 2 147 483 647]
 */

using System;

class OddOrEvenCounter
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int C = int.Parse(Console.ReadLine());
        string S = Console.ReadLine();

        int biggestCount = 0;

        int set = 0;
        int count = 0;
        for (int i = 0; i < N * C; i++)
        {
            int num = int.Parse(Console.ReadLine());
            CheckForS(C, S, ref biggestCount, ref set, ref count, i, num);
        }
        if (biggestCount == 0)
        {
            Console.WriteLine("No");
        }
        else
        {
            Console.WriteLine("{0} set has the most {1} numbers: {2}", OrdinalNumbers(set), S, biggestCount);
        }
    }

    private static void CheckForS(int C, string S, ref int biggestCount, ref int set, ref int count, int i, int num)
    {
        if (S == "odd" && num % 2 != 0)
        {
            count++;
        }
        else if (S == "even" && num % 2 == 0)
        {
            count++;
        }
        if ((i + 1) % C == 0)
        {
            if (count > biggestCount)
            {
                biggestCount = count;
                set = i / C;
            }
            count = 0;
        }
    }

    private static string OrdinalNumbers(int set)
    {
        string[] ordinalNumbers = { "First", "Second", "Third", "Fourth", "Fifth", "Sixth", "Seventh", "Eighth", "Ninth", "Tenth" };
        return ordinalNumbers[set];
    }
}
