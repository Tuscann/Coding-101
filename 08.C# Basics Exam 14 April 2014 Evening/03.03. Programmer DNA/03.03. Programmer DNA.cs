using System;

class Program
{
    static void Main()
    {
        int totalLenght = int.Parse(Console.ReadLine());
        char printChar = char.Parse(Console.ReadLine());

        char spaceChar = '.';

        int blockSize = 7;
        int midPoint = blockSize / 2;
        int diff = 0;
        int diffCouner = 0;

        for (int counter = 0; counter < totalLenght; counter++)
        {
            for (int i = 0; i < blockSize; i++)
            {
                if (i >= midPoint - diff && i <= midPoint + diff)
                {
                    Console.Write(printChar);
                    if (printChar == 'G')
                    {
                        printChar = 'A';
                    }
                    else
                    {
                        printChar++;
                    }

                }
                else
                {
                    Console.Write(spaceChar);
                }

            }
            if (diffCouner >= midPoint)
            {
                diff--;
            }
            else
            {
                diff++;
            }
            diffCouner++;
            if (diffCouner==blockSize)
            {
                diffCouner = 0;
                diff++;
            }
            Console.WriteLine();
        }
    }
}

