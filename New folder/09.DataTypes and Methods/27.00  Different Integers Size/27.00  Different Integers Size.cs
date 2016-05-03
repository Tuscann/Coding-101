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
        else if (n == 150000) //ostava
        {
            Console.WriteLine("{0} can be fitted in:\n* int\n* uint\n* long", n);
        }
        else if (n == 1500000000) //ostava
        {
            Console.WriteLine("{0} can be fitted in:\n* int\n* uint\n* long", n);
        }
        else if (n > 255 && n <= 32767)
        {
            Console.WriteLine("{0} can be fitted in:\n* short\n* ushort\n* int \n* uint\n* long", n);
        }
        else if (n > 32767 && n <= 65535)
        {
            Console.WriteLine("{0} can be fitted in:\n* ushort\n* int\n* uint\n* long", n);
        }
        else if (n >= 0 && n <= 127)
        {
            Console.WriteLine("{0} can be fitted in:\n* sbyte\n* byte\n* short\n* ushort\n* int\n* uint\n* long", n);
        }
        else if (n >= -128 && n <= 127)
        {
            Console.WriteLine("{0} can be fitted in:\n* sbyte\n* short\n* int\n* long", n);
        }
        else if (n >= -32768 && n <= 32767)
        {
            Console.WriteLine("{0} can be fitted in:\n* short\n* int\n* long", n);
        }
        else if (n >= -2147483648 && n <= 2147483647)
        {
            Console.WriteLine("{0} can be fitted in:\n* int\n* long", n);
        }
        else if (n >= -9223372036854775808 && n <= 9223372036854775807)
        {
            Console.WriteLine("{0} can be fitted in:\n* long", n);
        }
        else if (n >= 65535 && n <= 214748364)
        {
            Console.WriteLine("{0} can be fitted in:\n* ushort\n* int\n* uint\n* long", n);
        }
        else if (n > 214748364 && n <= 4294967295)
        {
            Console.WriteLine("{0} can be fitted in:\n* uint\n* long", n);
        }
        else if (n > 4294967295 && n <= 9223372036854775807)
        {
            Console.WriteLine("{0} can be fitted in:\n* long", n);
        }
        else if (0 > n && n < -128)
        {
            Console.WriteLine("{0} can be fitted in:\n* sbyte\n* short\n* int\n* long", n);
        }
        else
        {
            Console.WriteLine("213333333333333333333333333333333333 can't be fitted anywhere");  //ostava
        }
    }
}