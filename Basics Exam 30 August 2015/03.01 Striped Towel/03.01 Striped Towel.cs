using System;
class StripedTowel
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double height = n * 1.5;
        int dotsCount = 0;
        int stripesPos = 0;
        int rowIndicate = 0;

        for (int i = 0; i < (int)height; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i == 0 && j == 0 || i == rowIndicate && j == stripesPos)
                {
                    Console.Write("#");
                    stripesPos += 3;
                }
                else if (dotsCount < 2)
                {
                    Console.Write(".");
                    dotsCount++;

                    if (dotsCount == 2)
                    {
                        dotsCount = 0;
                    }
                }
            }
            rowIndicate++;
            stripesPos = 2 - i;

            while (stripesPos < 0)
            {
                stripesPos = 3 + stripesPos;
            }
            Console.WriteLine();
        }
    }
}