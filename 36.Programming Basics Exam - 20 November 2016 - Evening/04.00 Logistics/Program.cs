using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        decimal carPeople = 0;
        decimal mikrobus = 0;
        decimal malakbus = 0;

        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());

            if (number <= 3)
            {
                carPeople += number;
            }
            else if (number >= 4 && number <= 11)
            {
                mikrobus += number;
            }
            else if (number >= 12)
            {
                malakbus += number;
            }
        }
        decimal total = carPeople + mikrobus + malakbus;
        decimal total1 = (carPeople * 200 + mikrobus * 175 + malakbus * 120) / total;

        Console.WriteLine("{0:f2}", total1);
        Console.WriteLine("{0:f2}%", (decimal)carPeople / (decimal)total * 100);
        Console.WriteLine("{0:f2}%", (decimal)mikrobus / (decimal)total * 100);
        Console.WriteLine("{0:f2}%", (decimal)malakbus / (decimal)total * 100);
    }
}