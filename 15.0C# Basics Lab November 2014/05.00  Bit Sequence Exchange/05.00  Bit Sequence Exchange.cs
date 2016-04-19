using System;
public class BitSequenceExchange
{
    static void Main()
    {
        long number = long.Parse(Console.ReadLine());

        long bit3 = findBitAtPosition(number, 3);
        long bit4 = findBitAtPosition(number, 4);
        long bit5 = findBitAtPosition(number, 5);
        long bit24 = findBitAtPosition(number, 24);
        long bit25 = findBitAtPosition(number, 25);
        long bit26 = findBitAtPosition(number, 26);

        number = swapPositions(number, bit24, 3);
        number = swapPositions(number, bit25, 4);
        number = swapPositions(number, bit26, 5);

        number = swapPositions(number, bit3, 24);
        number = swapPositions(number, bit4, 25);
        number = swapPositions(number, bit5, 26);

        Console.WriteLine(number);
    }

    public static long findBitAtPosition(long number, int bitPosition)
    {
        long mask = 1 << bitPosition;
        long numAndMask = number & mask;
        long bit = numAndMask >> bitPosition;
        return bit;
    }

    public static long swapPositions(long number, long bit, int newPosition)
    {
        if (bit == 1)
        {
            long mask = bit << newPosition;
            number = number | mask;
        }
        else
        {
            long mask = ~(1 << newPosition);
            number = number & mask;
        }
        return number;
    }
}