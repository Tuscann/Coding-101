using System;

class CrossingSequences
{
    static void Main()
    {
        int MAX = 1000000;

        int t1 = int.Parse(Console.ReadLine());
        int t2 = int.Parse(Console.ReadLine());
        int t3 = int.Parse(Console.ReadLine());

        // Calculate all Tribonacci numbers in the range [1 ... 1 000 000]
        bool[] trib = new bool[MAX + 1];
        trib[t1] = true;
        trib[t2] = true;
        trib[t3] = true;
        while (true)
        {
            int tNext = t3 + t2 + t1;
            if (tNext <= MAX)
            {
                trib[tNext] = true;
            }
            else
            {
                // The end of the range is reached
                break;
            }
            t1 = t2;
            t2 = t3;
            t3 = tNext;
        }

        // Calculate all spiral numbers in the range [1 ... 1 000 000]
        long corner = long.Parse(Console.ReadLine());
        long step = long.Parse(Console.ReadLine());
        bool oddCorner = true;
        long side = 0;
        bool[] spiral = new bool[MAX + 1];
        while (corner <= MAX)
        {
            spiral[corner] = true;
            if (oddCorner)
            {
                side += 1;
            }
            corner += side * step;
            oddCorner = !oddCorner;
        }

        // Find the smallest common number
        for (int num = 1; num <= MAX; num++)
        {
            if (trib[num] && spiral[num])
            {
                Console.WriteLine(num);
                return;
            }
        }

        Console.WriteLine("No");
    }
}
