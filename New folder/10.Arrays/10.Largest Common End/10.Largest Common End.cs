using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] wordFirst = Console.ReadLine().Split(' ');
        string[] wordSecond = Console.ReadLine().Split(' ');

        int cntleftRight = 0;

        for (int i = 0; i < wordFirst.Length && i < wordSecond.Length; i++)
        {
            if (wordFirst[i] == wordSecond[i])
            {
                cntleftRight++;

            }
        }

        int j = 0;
        int cntRightleft = 0;
        while (wordFirst.Length > j && wordSecond.Length > j)
        {
            if (wordFirst[wordFirst.Length - 1 - j] == wordSecond[wordSecond.Length - 1 - j])
            {
                cntRightleft++;
            }
            j++;
        }

        Console.WriteLine(cntleftRight > cntRightleft ? cntleftRight : cntRightleft);

    }
}

