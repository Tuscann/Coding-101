using System;

class Sunglasses
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()); // Sunglasses height        

        for (int i = 0; i < n; i++)
        {
            if (i == 0 || i == n - 1)
            {
                PrintTopBottomPart(n);
            }
            else
            {
                PrintMiddlePart(n, i);
            }
        }
    }

    private static void PrintMiddlePart(int n, int i)
    {
        string lens = new string('/', n * 2 - 2);
        string middleFrame = string.Format("{0}{1}{0}", '*', lens);
        string connection = new string(' ', n); // Default empty space between the two frames
        // Checking if the row we're currently at is the one that the bridge should be on
        if (i == n / 2)
        {
            connection = new string('|', n); // Bridge
        }
        Console.WriteLine("{0}{1}{0}", middleFrame, connection);
    }

    private static void PrintTopBottomPart(int n)
    {
        string frame = new string('*', 2 * n);
        string emptySpace = new string(' ', n);
        Console.WriteLine("{0}{1}{0}", frame, emptySpace, frame);
    }
}