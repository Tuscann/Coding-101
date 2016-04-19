using System;
class BitsKiller
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());

        int index = 0;
        int outputBits = 0;
        int outputBitsCount = 0;
        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());
            for (int bitIndex = 7; bitIndex >= 0; bitIndex--)
            {
                if (!((index % step == 1) || (step == 1 && index > 0)))
                {
                    int bitValue = (num >> bitIndex) & 1;
                    // Console.WriteLine("bit : " + bitValue);
                    outputBits = outputBits << 1;
                    outputBits = outputBits | bitValue;
                    outputBitsCount++;
                    if (outputBitsCount == 8)
                    {
                        // We have 8 bits (1 byte) --> flush it to the output
                        Console.WriteLine(outputBits);
                        outputBits = 0;
                        outputBitsCount = 0;
                    }
                }
                index++;
            }
        }
        if (outputBitsCount > 0)
        {
            // We have a few bits left --> add trailing zeroes and flush them to the output
            outputBits = outputBits << (8 - outputBitsCount);
            Console.WriteLine(outputBits);
        }
    }
}
