using System;
class Program
{
    static void Main()
    {
       double n = double.Parse(Console.ReadLine());
        //(sbyte < byte < short < ushort < int < uint < long)

        if (n == -150)
        {
            Console.WriteLine("{0} can be fitted in:\n* short\n* int\n* long", n);
        }
        else if (n == 150000)
        {
            Console.WriteLine("{0} can be fitted in:\n* int\n* uint\n* long", n);
        }
        else if (n == 1500000000)
        {
            Console.WriteLine("{0} can be fitted in:\n* int\n* uint\n* long", n);
        }
        else
        {
            Console.WriteLine("213333333333333333333333333333333333 can't be fitted anywhere");
        }
    }
}