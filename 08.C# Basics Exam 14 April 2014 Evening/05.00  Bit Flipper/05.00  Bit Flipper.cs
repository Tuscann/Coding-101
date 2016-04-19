using System;

class BitFlipper
{
    static void Main()
    {
        ulong n = ulong.Parse(Console.ReadLine());
        int endBit = 62;

        while (endBit > 0)
        {
            endBit--;
            ulong last3Bits = (n >> endBit) & 7;
            if (last3Bits == 0 || last3Bits == 7)
            {
                n = n ^ ((ulong)7 << endBit);
                endBit -= 2;
            }
        }

        Console.WriteLine(n);
    }
}
