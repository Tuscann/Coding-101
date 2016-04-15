using System;
class FriendBitsBitwise
{
    static void Main()
    {
        uint number = uint.Parse(Console.ReadLine()); ;
        uint friendNumber = 0;
        uint aloneNumber = 0;
        int counter = 1;

        for (int i = 31; i >= 0; i--)
        {
            uint firstBit = number >> i & 1;
            uint nextBit = number >> i - 1 & 1;

            if (i == 0)
            {
                nextBit = 2;
            }

            if (firstBit == nextBit)
            {
                friendNumber = friendNumber << 1;
                friendNumber = friendNumber | firstBit;
                counter++;
            }
            else if (firstBit != nextBit && counter > 1)
            {
                friendNumber = friendNumber << 1;
                friendNumber = friendNumber | firstBit;
                counter = 1;
            }
            else
            {
                aloneNumber = aloneNumber << 1;
                aloneNumber = aloneNumber | firstBit;
            }
        }
        Console.WriteLine(friendNumber);
        Console.WriteLine(aloneNumber);
    }
}