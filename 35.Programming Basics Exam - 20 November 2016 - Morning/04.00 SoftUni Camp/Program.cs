using System;
class Program
{
    static void Main()
    {
        int students = int.Parse(Console.ReadLine());

        int carPeople = 0;
        int mikrobus = 0;
        int malakbus = 0;
        int golqmBus = 0;
        int train = 0;

        for (int i = 0; i < students; i++)
        {
            int number = int.Parse(Console.ReadLine());
            if (number <= 5)
            {
                carPeople += number;
            }
            else if (number >= 6 && number <= 12)
            {
                mikrobus += number;
            }
            else if (number >= 13 && number <= 25)
            {
                malakbus += number;
            }
            else if (number >= 26 && number <= 40)
            {
                golqmBus += number;
            }
            else if (number >= 41)
            {
                train += number;
            }
        }
        int total = carPeople + mikrobus + malakbus + golqmBus + train;

        Console.WriteLine("{0:f2}%", (decimal)carPeople / (decimal)total * 100);
        Console.WriteLine("{0:f2}%", (decimal)mikrobus / (decimal)total * 100);
        Console.WriteLine("{0:f2}%", (decimal)malakbus / (decimal)total * 100);
        Console.WriteLine("{0:f2}%", (decimal)golqmBus / (decimal)total * 100);
        Console.WriteLine("{0:f2}%", (decimal)train / (decimal)total * 100);
    }
}