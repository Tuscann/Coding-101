using System;
using System.Numerics;
class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        BigInteger integer = 1;
        for (int i = 2; i <= number; i++)
        {
            integer = integer * i;
        }
        Console.WriteLine(integer);
    }
}