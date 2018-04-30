using System;
class Program
{
    static void Main()
    {
        double pageCost = double.Parse(Console.ReadLine());
        double firstPageCost = double.Parse(Console.ReadLine());
        int discount = int.Parse(Console.ReadLine());
        double dizainerPrise = double.Parse(Console.ReadLine());
        int teamPrice = int.Parse(Console.ReadLine());
        
        double sum = ((pageCost * 899 + firstPageCost * 2) * (1 - discount / 100.0) + dizainerPrise) * (1 - teamPrice / 100.0);
        Console.WriteLine("Avtonom should pay {0:f2} BGN.", sum);
    }
}