using System;
class Program
{
    static void Main() // 100/100
    {
        double first = double.Parse(Console.ReadLine());
        double secound = double.Parse(Console.ReadLine());
        double third = double.Parse(Console.ReadLine());
        double fourt = double.Parse(Console.ReadLine());
        double five = double.Parse(Console.ReadLine());

        double rakia = fourt * (first / 2);
        double vino = third * (first / 2 - 0.4 * first / 2);
        double bira = secound * (first / 2 - 0.8 * first / 2);
        double uuskii = first * five;

        Console.WriteLine("{0:f2}", rakia + vino + bira + uuskii);
    }
}