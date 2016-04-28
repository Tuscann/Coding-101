using System;
class Program
{
    static void Main()
    {

        decimal n = decimal.Parse(Console.ReadLine());
        //(sbyte < byte < short < ushort < int < uint < long)
        if (-128 <= n && n <= 0)
        {
            Console.WriteLine("{0} can be fitted in:\n*sbyte\n*short\n*int\n*long", n);
        }
        else if (-32768 <= n && n <= 0)
        {
            Console.WriteLine("{0} can be fitted in:\n*short\n*int\n*long", n);
        }

        else if (0 <= n && n <= 255)
        {
            Console.WriteLine("{0} can be fitted in:\n*sbyte", n);
        }
        else if (n <= long.MinValue && n > long.MaxValue)
        {
            Console.WriteLine("{0} can't be fitted anywhere", n);
        }

    }
}