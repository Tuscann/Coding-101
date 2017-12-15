using System;
class Program
{
    static void Main() // 100/100
    {
        double nasledstvo = double.Parse(Console.ReadLine());
        int godina = int.Parse(Console.ReadLine());

        for (int i = 1800; i <= godina; i++)
        {
            if (i % 2 == 0)
            {
                nasledstvo -= 12000;
            }
            else
            {
                nasledstvo -= 12000 + (18 + (i - 1800)) * 50;
            }
        }
        if (nasledstvo >= 0)
        {
            Console.WriteLine("Yes! He will live a carefree life and will have {0:f2} dollars left.", nasledstvo);
        }
        else
        {
            Console.WriteLine("He will need {0:f2} dollars to survive.", Math.Abs(nasledstvo));
        }
    }
}