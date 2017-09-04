using System;
class Program
{
    static void Main() // 100/100
    {
        double daljina = double.Parse(Console.ReadLine());
        double shirina = double.Parse(Console.ReadLine());

        Console.WriteLine((int)((shirina * 100 - 100) / 70) * (int)(daljina * 100 / 120) - 3);
    }
}