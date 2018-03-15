using System;
class Program
{
    static void Main()
    {
        double processorPrice = double.Parse(Console.ReadLine());
        double videoCardPrice = double.Parse(Console.ReadLine());
        double ramPrice = double.Parse(Console.ReadLine());
        int ramQuantity = int.Parse(Console.ReadLine());
        double discount = double.Parse(Console.ReadLine());

        double totalDollars = ((processorPrice + videoCardPrice) * (1 - discount) + ramPrice * ramQuantity) * 1.57;
        
        Console.WriteLine("Money needed - {0:f2} leva.", totalDollars);
    }
}