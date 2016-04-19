using System;
public class BitRoller
{
    const int SIZE = 19;

    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int pillarPosition = int.Parse(Console.ReadLine());
        int rolls = int.Parse(Console.ReadLine());

        //Console.WriteLine(Convert.ToString(n, 2).PadLeft(SIZE, '0'));

        for (int i = 0; i < rolls; i++)
        {
            n = RollBitsRight(n, pillarPosition);
            //Console.WriteLine(Convert.ToString(n, 2).PadLeft(SIZE, '0'));
        }

        Console.WriteLine(n);
    }

    private static int RollBitsRight(int n, int pillarPosition)
    {
        int result = 0;
        for (int pos = 0; pos < SIZE; pos++)
        {
            int bit = (n >> pos) & 1;
            if (pos == pillarPosition)
            {
                //newBits[pos] = bits[pos];
                result = result | (bit << pos);
            }
            else
            {
                int newPos = RightPosition(pos);
                if (newPos == pillarPosition)
                {
                    newPos = RightPosition(newPos);
                }
                //newBits[newPos] = bits[pos];
                result = result | (bit << newPos);
            }
        }
        return result;
    }

    private static int RightPosition(int pos)
    {
        int newPos = pos - 1;
        if (newPos < 0)
        {
            newPos = SIZE - 1;
        }
        return newPos;
    }
}
