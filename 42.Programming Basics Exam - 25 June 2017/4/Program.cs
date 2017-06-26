using System;
class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        decimal price = decimal.Parse(Console.ReadLine());

        decimal sum = 0;

        for (int i = 1; i <= number; i++)
        {
            int curentnumber = int.Parse(Console.ReadLine());
            if (i % 2 == 0)
            {
                curentnumber *= 2;
            }
            sum += curentnumber;
        }
        Console.WriteLine("The project prize was {0:f2} lv.", sum * price);
    }
}