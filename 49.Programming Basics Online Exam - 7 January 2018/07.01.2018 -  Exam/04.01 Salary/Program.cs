using System;
class Program
{
    static void Main() // 100/100
    {
        double salary = double.Parse(Console.ReadLine());
        int time = int.Parse(Console.ReadLine());
        string sindyc = Console.ReadLine();

        double yearSupplement;
        double sumSalary = salary;
        double oddrajka = 1;

        for (int i = 1; i <= time; i++)
        {
            if (sindyc == "Yes" && i % 5 != 0)
            {
                oddrajka = 0.99;
            }
            yearSupplement = (sumSalary * 6) / 100;
            sumSalary = (sumSalary + yearSupplement) * oddrajka;
            if (i % 5 == 0 && i % 10 != 0)
            {
                sumSalary = sumSalary + 100;
            }
            if (i % 10 == 0)
            {
                sumSalary = sumSalary + 200;
            }
        }
        if (sumSalary > 5000)
        {
            sumSalary = 5000;
        }
        Console.WriteLine($"Current salary: {sumSalary:f2}");

        sumSalary = salary;
        oddrajka = 1;
        int complementary = 0;
        for (int i = 1; i <= 10000; i++)
        {
            if (sindyc == "Yes" && i % 5 != 0)
            {
                oddrajka = 0.99;
            }
            yearSupplement = (sumSalary * 6) / 100;
            sumSalary = (sumSalary + yearSupplement) * oddrajka;
            if (i % 5 == 0 && i % 10 != 0)
            {
                sumSalary = sumSalary + 100;
            }
            if (i % 10 == 0)
            {
                sumSalary = sumSalary + 200;
            }
            complementary = i - time - 1;
            if (sumSalary >= 5000)
            {
                break;
            }

        }
        if (complementary < 0)
        {
            complementary = 0;
        }
        Console.WriteLine($"{complementary} more years to max salary.");
    }
}