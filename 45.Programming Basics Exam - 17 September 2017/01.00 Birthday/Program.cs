using System;
class Program
{
    static void Main() // 100/100
    {
        int lenght = int.Parse(Console.ReadLine());
        int weight = int.Parse(Console.ReadLine());
        int height = int.Parse(Console.ReadLine());
        double prosent = double.Parse(Console.ReadLine()) / 100;

        double sum = lenght * weight * height * 0.001 * (1 - prosent);
        Console.WriteLine("{0:f3}", sum);
    }
}