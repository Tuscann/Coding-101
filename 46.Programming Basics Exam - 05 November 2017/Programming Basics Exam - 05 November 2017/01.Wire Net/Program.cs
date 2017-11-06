using System;
class Program
{
    static void Main()  // 100/100
    {
        int lenght = int.Parse(Console.ReadLine());
        int width = int.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());
        double price = double.Parse(Console.ReadLine());
        double weight = double.Parse(Console.ReadLine());

        double len = 2 * lenght + 2 * width;
        double sum1 = len * price;
        double weghtFinal = len * height * weight;

        Console.WriteLine("{0:f0}", len);
        Console.WriteLine("{0:f2}", sum1);
        Console.WriteLine("{0:f3}", weghtFinal);
    }
}