using System;
class Program
{
    static void Main() // 100/100
    {
        double salary = double.Parse(Console.ReadLine());
        int time = int.Parse(Console.ReadLine());
        string sindeikalen = Console.ReadLine();
        double totall = salary;

        for (int i = 1; i < 1000; i++)
        {
            totall = totall * 1.06;
            if (i % 5 == 0)
            {
                totall += 100;
            }
            if (i % 10 == 0)
            {
                totall += 100;
            }
            if (sindeikalen == "Yes" && (i % 5 != 0 || i % 10 != 0))
            {
                totall *= 0.99;
            }
            if (i == time && totall < 5000)
            {
                Console.WriteLine("Current salary: {0:f2}", totall);
            }
            else if (totall >= 5000 && time >= i)
            {
                Console.WriteLine("Current salary: {0:f2}", 5000);
                Console.WriteLine("{0} more years to max salary.", 0);
                break;
            }
            if (totall >= 5000)
            {
                Console.WriteLine("{0} more years to max salary.", i - 1 - time);
                break;
            }
        }
    }
}