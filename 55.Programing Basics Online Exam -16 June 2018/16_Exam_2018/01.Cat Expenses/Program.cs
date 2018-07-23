using System;
class Program
{
    static void Main()
    {
        double bedPrice = double.Parse(Console.ReadLine());
        double catPrice = double.Parse(Console.ReadLine());

        double commandExpensis =
            catPrice + catPrice * 1.25 + catPrice * 1.25 * 0.50 + catPrice * 1.25 * 0.50 * 1.1;
       

        double sum = bedPrice + 12 * commandExpensis + 12 * 0.05 * commandExpensis;
        Console.WriteLine("{0:f2} lv.", sum);
    }
}