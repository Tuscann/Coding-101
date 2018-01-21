using System;
class Program
{
    static void Main()  // 100/100
    {
        double weightBegining = double.Parse(Console.ReadLine());
        double m = double.Parse(Console.ReadLine());
        double price = double.Parse(Console.ReadLine());
        double cellCount = double.Parse(Console.ReadLine());
        double sweatCount = double.Parse(Console.ReadLine());

        double total = cellCount * price;
        double nededd = cellCount * m;
        double priceSweat = price * 1.25;
        double weightSmall = 0.8 * m;
        double testo = sweatCount * weightSmall;
        double nightIncome = sweatCount * priceSweat;
        double totaltesto = (weightBegining / 1000.0 + nededd / 1000.0) * 4.0;
        double income = total + nightIncome - totaltesto;
        double dough = nededd + testo;

        Console.WriteLine("Pure income: {0:f2} lv.", income);
        Console.WriteLine("Dough used: {0:f0} g.", dough);
    }
}