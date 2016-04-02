using System;
class Program
{
    static void Main()
    {
        int dasd = int.Parse(Console.ReadLine());

        int d = dasd % 10;
        int c = (dasd / 10) % 10;
        int b = (dasd / 100) % 10;
        int a = (dasd / 1000) % 10;

        Console.WriteLine("{0}", d + c + b + a);
        Console.WriteLine("{0}{1}{2}{3}", d, c, b, a);
        Console.WriteLine("{0}{1}{2}{3}", d, a, b, c);
        Console.WriteLine("{0}{1}{2}{3}", a, c, b, d);
    }
}

