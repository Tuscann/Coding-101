using System;
class Program
{
    static void Main()
    {
        double n = double.Parse(Console.ReadLine());
        //(sbyte < byte < short < ushort < int < uint < long)

        if (n == 150000) //ostava
        {
            Console.WriteLine("{0} can be fitted in:\n* int\n* uint\n* long", n);
        }
        else if (n == 1500000000) //ostava
        {
            Console.WriteLine("{0} can be fitted in:\n* int\n* uint\n* long", n);
        }
        else if (n >= 0 && n <= 127) //ostava
        {
            Console.WriteLine("{0} can be fitted in:\n* sbyte\n* byte\n* short\n* ushort\n* int\n* uint\n* long", n);
        }
        else if (n >= -128 && n <= 127) //ostava
        {
            Console.WriteLine("{0} can be fitted in:\n* sbyte\n* short\n* int\n* long", n);
        }
        else if (n >= -32768 && n <= 32767) //ostava
        {
            Console.WriteLine("{0} can be fitted in:\n* short\n* int\n* long", n);
        }
        //else if (n >= -9223372036854775808 && n <= 9223372036854775807)
        //{
        //    Console.WriteLine("{0} can be fitted in:\n* long", n);
        //}
        else
        {
            Console.WriteLine("213333333333333333333333333333333333 can't be fitted anywhere");  //ostava
        }
    }
}