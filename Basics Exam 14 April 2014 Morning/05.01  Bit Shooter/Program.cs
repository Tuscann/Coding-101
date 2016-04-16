using System;
class BitShooter2
{
    static void Main()
    {
        const int BITS = 64;

        ulong inputBits = ulong.Parse(Console.ReadLine());
        ulong shootedBits = 0;
        for (int i = 0; i < 3; i++)
        {
            string shoot = Console.ReadLine();
            string[] shootDetails = shoot.Split(' ');
            int shootCenter = int.Parse(shootDetails[0]);
            int shootSize = int.Parse(shootDetails[1]);
            int startBit = shootCenter - shootSize / 2;
            int endBit = shootCenter + shootSize / 2;
            for (int bit = startBit; bit <= endBit; bit++)
            {
                if (bit >= 0 && bit < BITS)
                {
                    shootedBits = shootedBits | ((ulong)1 << bit);
                }
            }
        }
        ulong aliveBits = inputBits & (~shootedBits);

        //Console.WriteLine(Convert.ToString((long)inputBits, 2).PadLeft(64,'0'));
        //Console.WriteLine(Convert.ToString((long)~shootedBits, 2).PadLeft(64, '0'));
        //Console.WriteLine(Convert.ToString((long)aliveBits, 2).PadLeft(64, '0'));

        ulong rightBits = 0;
        for (int i = 0; i < BITS / 2; i++)
        {
            rightBits += aliveBits & 1;
            aliveBits >>= 1;
        }

        ulong leftBits = 0;
        for (int i = 0; i < BITS / 2; i++)
        {
            leftBits += aliveBits & 1;
            aliveBits >>= 1;
        }

        Console.WriteLine("left: " + leftBits);
        Console.WriteLine("right: " + rightBits);
    }
}