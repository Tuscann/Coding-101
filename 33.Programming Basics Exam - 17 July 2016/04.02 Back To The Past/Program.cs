using System;
class Example
{
    public static void Main()  // 100/100
    {
        double Money = double.Parse(Console.ReadLine());
        int year = int.Parse(Console.ReadLine());
        int age = 18;
        int difference = year - 1800;

        age = age + difference;

        for (int i = difference; i >= 0; i--)
        {
            if (i % 2 == 0)
            {
                Money = Money - 12000;
            }
            else
            {
                Money = Money - (12000 + (50 * age));
            }
            age--;
        }

        if (Money >= 0)
        {
            Console.WriteLine("Yes! He will live a carefree life and will have {0:F2} dollars left.", Money);
        }
        else
        {
            Console.WriteLine("He will need {0:F2} dollars to survive.", Math.Abs(Money));
        }
        Console.ReadLine();

    }
}