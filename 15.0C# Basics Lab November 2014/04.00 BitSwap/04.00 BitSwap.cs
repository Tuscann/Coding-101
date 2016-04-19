using System;
public class BitSwap
{
    static void Main()
    {
        long number = long.Parse(Console.ReadLine());

        long bit3mask = 1 << 3;
        long numberAndBit3Mask = number & bit3mask;
        long bit3 = numberAndBit3Mask >> 3;

        long bit24mask = 1 << 24;
        long numberAndBit24Mask = number & bit24mask;
        long bit24 = numberAndBit24Mask >> 24;

        if (bit3 == 1)
        {
            long newMaskBit3 = bit3 << 24;
            number = number | newMaskBit3;
        }
        else
        {
            long newMaskBit3 = ~(1 << 24);
            number = number & newMaskBit3;
        }

        if (bit24 == 1)
        {
            long newMaskBit24 = bit24 << 3;
            number = number | newMaskBit24;
        }
        else
        {
            long newMaskBit24 = ~(1 << 3);
            number = number & newMaskBit24;
        }
        Console.WriteLine(number);
    }
}