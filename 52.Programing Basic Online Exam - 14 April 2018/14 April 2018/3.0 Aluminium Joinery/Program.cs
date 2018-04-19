using System;
class Program
{
    static void Main()
    {
        int dograma = int.Parse(Console.ReadLine());
        string type = Console.ReadLine();
        string typeOfDelivery = Console.ReadLine();

        double price = 0.0;

        if (dograma < 10)
        {
            Console.WriteLine("Invalid order");
        }
        else if (type == "90X130" || type == "100X150" || type == "130X180" || type == "200X300")
        {
            if (type == "90X130")
            {
                price = 110;
                if (dograma > 30 && dograma <= 60)
                {
                    price *= 0.95;
                }
                else if (dograma > 60)
                {
                    price *= 0.92;
                }
            }
            else if (type == "100X150")
            {
                price = 140;
                if (dograma >= 40 && dograma <= 80)
                {
                    price *= 0.94;
                }
                else if (dograma > 80)
                {
                    price *= 0.9;
                }
            }
            else if (type == "130X180")
            {
                price = 190;
                if (dograma >= 20 && dograma <= 50)
                {
                    price *= 0.93;
                }
                else if (dograma > 50)
                {
                    price *= 0.88;
                }
            }
            else if (type == "200X300")
            {
                price = 250;
                if (dograma >= 25 && dograma <= 50)
                {
                    price *= 0.91;
                }
                else if (dograma > 50)
                {
                    price *= 0.86;
                }
            }
            price *= dograma;
            if (typeOfDelivery == "With delivery")
            {
                price += 60;
            }
            if (dograma > 99)
            {
                price *= 0.96;
            }
            Console.WriteLine("{0:f2} BGN", price);
        }
    }
}