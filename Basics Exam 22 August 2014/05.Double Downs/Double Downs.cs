using System;
class DoubleDowns
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        int leftDiagonalCounter = 0;
        int rightDiagonalCounter = 0;
        int downCounter = 0;

        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < n - 1; i++)
        {
            for (int bit = 0; bit < 32; bit++)
            {
                int upNumber = numbers[i];
                int downNumber = numbers[i + 1];
                int mask = 1 << bit;
                bool checkUp = (upNumber & mask) > 0;

                if (checkUp && (downNumber & (mask << 1)) > 0)
                {
                    leftDiagonalCounter++;
                }
                if (checkUp && (downNumber & mask) > 0)
                {
                    downCounter++;
                }
                if (bit > 0 && checkUp && (downNumber & (mask >> 1)) > 0)
                {
                    rightDiagonalCounter++;
                }
            }
        }
        Console.WriteLine(rightDiagonalCounter);
        Console.WriteLine(leftDiagonalCounter);
        Console.WriteLine(downCounter);
    }
}
