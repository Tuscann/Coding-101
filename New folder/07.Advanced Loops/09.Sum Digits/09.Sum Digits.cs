using System;
using System.Linq;

class FourDigitNumber
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine()).ToString().Sum(c => c - '0');
        Console.WriteLine(number);
    }
}