using System;
class Program
{
    static void Main() // 100/100
    {
        int n = int.Parse(Console.ReadLine());
        double totalRakia = 0.0;
        double totalLitersRakia = 0.0;

        for (int i = 0; i < n; i++)
        {
            double quantityRakia = double.Parse(Console.ReadLine());
            double gradusRakia = double.Parse(Console.ReadLine());
            totalLitersRakia += quantityRakia * gradusRakia;
            totalRakia += quantityRakia;
        }
        double degress = totalLitersRakia / totalRakia;

        Console.WriteLine("Liter: {0:f2}", totalRakia);
        Console.WriteLine("Degrees: {0:f2}", degress);
        if (degress > 42.00)
        {
            Console.WriteLine("Dilution with distilled water!");
        }
        else if (degress >= 38.00 && degress <= 42.00)
        {
            Console.WriteLine("Super!");
        }
        else if (degress < 38.00)
        {
            Console.WriteLine("Not good, you should baking!");
        }
    }
}
