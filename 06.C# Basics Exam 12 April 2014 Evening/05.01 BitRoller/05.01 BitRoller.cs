using System;
// This solutions cheats by using char[] instead of bits
public class BitRoller
{
    public static void Main()
    {
        const int SIZE = 19;

        int n = int.Parse(Console.ReadLine());
        int pillarPosition = int.Parse(Console.ReadLine());
        int rolls = int.Parse(Console.ReadLine());

        char[] bits = Convert.ToString(n, 2).PadLeft(SIZE, '0').ToCharArray();
        //Console.WriteLine(new string(bits));

        pillarPosition = SIZE - 1 - pillarPosition;

        for (int i = 0; i < rolls; i++)
        {
            RollBitsRight(bits, pillarPosition);
            //Console.WriteLine(new string(bits));
        }

        int result = Convert.ToInt32(new string(bits), 2);
        Console.WriteLine(result);
    }

    private static void RollBitsRight(char[] bits, int pillarPosition)
    {
        char[] newBits = new char[bits.Length];
        for (int pos = 0; pos < bits.Length; pos++)
        {
            if (pos == pillarPosition)
            {
                newBits[pos] = bits[pos];
            }
            else
            {
                int newPos = (pos + 1) % bits.Length;
                if (newPos == pillarPosition)
                {
                    newPos = (newPos + 1) % bits.Length;
                }
                newBits[newPos] = bits[pos];
            }
        }

        for (int i = 0; i < bits.Length; i++)
        {
            bits[i] = newBits[i];
        }
    }
}
