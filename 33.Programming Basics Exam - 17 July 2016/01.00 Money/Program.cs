using System;
class Program
{
    static void Main() // 100/100
    {
        int bitkoins = int.Parse(Console.ReadLine());
        double chinseUana = double.Parse(Console.ReadLine());
        double commnins = double.Parse(Console.ReadLine());

        const double bitcoin = 1168;
        const double chinseuan = 0.15;
        const double dolar = 1.76;
        const double euro = 1.95;

        double totalBitcoin = bitkoins * bitcoin;
        double totalUana = chinseUana * chinseuan * dolar;
        double total = (totalUana + totalBitcoin) / euro;

        double t = total - commnins / 100 * total;

        Console.WriteLine("{0:f2}", t);
    }
}