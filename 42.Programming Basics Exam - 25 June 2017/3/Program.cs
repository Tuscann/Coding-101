using System;
class Program
{
    static void Main()
    {
        string fruit = Console.ReadLine();
        string size = Console.ReadLine();
        int count = int.Parse(Console.ReadLine());

        decimal price = 0;
        int liters = 0;

        if (fruit == "Watermelon")
        {
            if (size == "small")
            {
                price = 56;
                liters = 2;
            }
            else if (size == "big")
            {
                price = (decimal)28.7;
                liters = 5;
            }
        }
        else if (fruit == "Mango")
        {
            if (size == "small")
            {
                price = (decimal)36.66;
                liters = 2;
            }
            else if (size == "big")
            {
                price = (decimal)19.6;
                liters = 5;
            }
        }
        else if (fruit == "Pineapple")
        {
            if (size == "small")
            {
                price = (decimal)42.1;
                liters = 2;
            }
            else if (size == "big")
            {
                price = (decimal)24.8;
                liters = 5;
            }
        }
        else if (fruit == "Raspberry")
        {
            if (size == "small")
            {
                price = 20;
                liters = 2;
            }
            else if (size == "big")
            {
                price = (decimal)15.2;
                liters = 5;
            }
        }
        decimal sum = liters * price * count;

        if (sum >= 400 && sum <= 1000)
        {
            sum *= (decimal)0.85;
        }
        else if (sum > 1000)
        {
            sum *= (decimal)0.5;
        }
        Console.WriteLine("{0:f2} lv.", sum);
    }
}