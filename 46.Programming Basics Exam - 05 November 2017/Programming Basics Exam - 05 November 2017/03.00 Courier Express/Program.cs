using System;
class Program
{
    static void Main()  // 100/100
    {
        double weight = double.Parse(Console.ReadLine());
        string typeOfServie = Console.ReadLine();
        int distance = int.Parse(Console.ReadLine());

        double price = 0.0;
        double prozent = 0.0;

        if (weight < 1.0)
        {
            price = 0.03;
            if (typeOfServie == "express")
            {
                prozent = 0.8;
            }
        }
        else if (weight <= 10.0)
        {
            price = 0.05;
            if (typeOfServie == "express")
            {
                prozent = 0.4;
            }
        }
        else if (weight <= 40.0)
        {
            price = 0.1;
            if (typeOfServie == "express")
            {
                prozent = 0.05;
            }
        }
        else if (weight <= 90.0)
        {
            price = 0.15;
            if (typeOfServie == "express")
            {
                prozent = 0.02;
            }
        }
        else if (weight <= 150.0)
        {
            price = 0.2;
            if (typeOfServie == "express")
            {
                prozent = 0.01;
            }
        }

        double afterWeight = price * distance * (1 + prozent * weight);

        Console.WriteLine("The delivery of your shipment with weight of {0:f3} kg. would cost {1:f2} lv.", weight, afterWeight);
    }
}