using System;
class Program
{
    static void Main() // 100/100
    {
        decimal days = decimal.Parse(Console.ReadLine());
        decimal sladkari = decimal.Parse(Console.ReadLine());
        decimal torti = decimal.Parse(Console.ReadLine());
        decimal gofreti = decimal.Parse(Console.ReadLine());
        decimal palachinki = decimal.Parse(Console.ReadLine());

        decimal sum = (torti * (decimal)45.00 + gofreti * (decimal)5.80 + palachinki * (decimal)3.20) * sladkari * days * (decimal)(1 - 0.125);

        Console.WriteLine("{0:f2}", sum);
    }
}