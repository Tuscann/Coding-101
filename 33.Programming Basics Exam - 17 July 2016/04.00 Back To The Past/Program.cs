using System;
class Program
{
    static void Main() // 100/100
    {
        double heritage = double.Parse(Console.ReadLine());
        int yearToLive = int.Parse(Console.ReadLine());

        double yearsold = 17;

        for (int year = 1800; year <= yearToLive; year++)
        {
            if (year % 2 == 0)
            {
                heritage = heritage - 12000;
            }
            else if (year % 2 != 0)
            {
                yearsold += 2;
                heritage = heritage - (12000 + (50 * yearsold));
            }
        }
        if (heritage >= 0)
        {
            Console.WriteLine("Yes! He will live a carefree life and will have {0:F2} dollars left.", heritage);
        }
        else
        {
            Console.WriteLine("He will need {0:F2} dollars to survive.", Math.Abs(heritage));
        }
    }
}