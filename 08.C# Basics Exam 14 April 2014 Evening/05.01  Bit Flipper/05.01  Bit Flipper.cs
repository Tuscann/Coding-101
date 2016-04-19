using System;
class BitFlipperBitwise
{
    static void Main()
    {
        ulong number = ulong.Parse(Console.ReadLine());
        ulong mask = 7;
        int n = 61;

        for (int i = n; i >= 0; i--)
        {
            ulong checker = mask << i;
            checker = checker & number;
            checker = checker >> i;
            if (checker == 0 || checker == 7)
            {
                number = number ^ (mask << i);
                i -= 2;
            }
        }
        Console.WriteLine(number);
    }
}