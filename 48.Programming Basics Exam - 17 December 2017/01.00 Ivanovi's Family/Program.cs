using System;
class Program
{
    static void Main() // 100/100
    {
        double budgjet = double.Parse(Console.ReadLine());
        double gift1 = double.Parse(Console.ReadLine());
        double gift2 = double.Parse(Console.ReadLine());
        double gift3 = double.Parse(Console.ReadLine());

        Console.WriteLine("{0:f2}", 0.9 * (budgjet - (gift1 + gift2 + gift3)));
    }
}