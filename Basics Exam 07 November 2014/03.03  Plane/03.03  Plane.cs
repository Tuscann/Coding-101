using System;
class Problem3
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int width = 3 * n;

        Console.WriteLine("{0}*{0}", new String('.', (width - 1) / 2));

        int outerDots = (width - 1) / 2 - 1;
        int innerDots = 1;

        int firstPartCounter = 0;

        switch (n)
        {
            case 5: firstPartCounter = 4; break;
            case 7: firstPartCounter = 5; break;
            case 9: firstPartCounter = 6; break;
            case 11: firstPartCounter = 7; break;
            case 13: firstPartCounter = 8; break;
            case 15: firstPartCounter = 9; break;
            case 17: firstPartCounter = 10; break;
            case 19: firstPartCounter = 11; break;
            case 21: firstPartCounter = 12; break;
            case 23: firstPartCounter = 13; break;
            case 25: firstPartCounter = 14; break;
            case 27: firstPartCounter = 15; break;
            case 29: firstPartCounter = 16; break;
            case 31: firstPartCounter = 17; break;
        }

        for (int row = 1; row <= firstPartCounter; row++)
        {
            Console.WriteLine("{0}*{1}*{0}", new String('.', outerDots), new String('.', innerDots));
            outerDots--;
            innerDots += 2;
        }

        outerDots = outerDots - 1;
        innerDots += 2;

        int secondPartCounter = 0;

        switch (n)
        {
            case 5: secondPartCounter = 1; break;
            case 7: secondPartCounter = 2; break;
            case 9: secondPartCounter = 3; break;
            case 11: secondPartCounter = 4; break;
            case 13: secondPartCounter = 5; break;
            case 15: secondPartCounter = 6; break;
            case 17: secondPartCounter = 7; break;
            case 19: secondPartCounter = 8; break;
            case 21: secondPartCounter = 9; break;
            case 23: secondPartCounter = 10; break;
            case 25: secondPartCounter = 11; break;
            case 27: secondPartCounter = 12; break;
            case 29: secondPartCounter = 13; break;
            case 31: secondPartCounter = 14; break;
        }

        for (int row = 1; row <= secondPartCounter; row++)
        {
            Console.WriteLine("{0}*{1}*{0}", new String('.', outerDots), new String('.', innerDots));
            outerDots -= 2;
            innerDots += 4;
        }

        Console.WriteLine("*{0}*{1}*{0}*", new String('.', n - 2), new string('.', n));

        int thirdPartCounter = 0;

        switch (n)
        {
            case 5: thirdPartCounter = 1; break;
            case 7: thirdPartCounter = 2; break;
            case 9: thirdPartCounter = 3; break;
            case 11: thirdPartCounter = 4; break;
            case 13: thirdPartCounter = 5; break;
            case 15: thirdPartCounter = 6; break;
            case 17: thirdPartCounter = 7; break;
            case 19: thirdPartCounter = 8; break;
            case 21: thirdPartCounter = 9; break;
            case 23: thirdPartCounter = 10; break;
            case 25: thirdPartCounter = 11; break;
            case 27: thirdPartCounter = 12; break;
            case 29: thirdPartCounter = 13; break;
            case 31: thirdPartCounter = 14; break;
        }

        outerDots = n - 4;
        int sideDots = 1;
        innerDots = n;

        for (int row = 1; row <= thirdPartCounter; row++)
        {
            Console.WriteLine("*{0}*{1}*{2}*{1}*{0}*", new String('.', outerDots), new String('.', sideDots), new String('.', innerDots));
            outerDots -= 2;
            sideDots += 2;
        }

        outerDots = n - 1;
        innerDots = n;

        for (int row = 1; row <= n; row++)
        {
            if (row != n)
            {
                Console.WriteLine("{0}*{1}*{0}", new String('.', outerDots), new String('.', innerDots));
            }
            else
            {
                Console.WriteLine(new String('*', width));
            }
            outerDots--;
            innerDots += 2;
        }
    }
}