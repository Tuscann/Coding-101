using System;
public class BitCopy
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int position = int.Parse(Console.ReadLine());

        int mask = 1 << position;
        int numberAndMask = number & mask;
        int bit = numberAndMask >> position;
        if (bit == 1)
        {
            int newMask = bit << 2;
            int newNumber = number | newMask;
            Console.WriteLine(newNumber);
        }
        else
        {
            int newMask = ~(1 << 2);
            int newNumber = number & newMask;
            Console.WriteLine(newNumber);
        }
    }
}