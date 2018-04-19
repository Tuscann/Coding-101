using System;
class Program
{
    static void Main()
    {
        int budget = int.Parse(Console.ReadLine());
        int count = int.Parse(Console.ReadLine());
        string brand = Console.ReadLine();

        double price = 0;
        double discount = 0;

        if (brand == "Gsm4e")
        {
            price = 20.5;
            discount = 1;
        }
        else if (brand == "Mobifon4e")
        {
            price = 50.75;
            discount = 2;
        }
        else if (brand == "Telefon4e")
        {
            price = 115;
            discount = 3;
        }
        if (count > 10 && count <= 20)
        {
            discount += 2;
        }
        else if (count > 20 && count <= 50)
        {
            discount += 5;
        }
        else if (count > 50)
        {
            discount += 7;
        }

        double total = count * price * (1.0 - discount / 100);
        if (total < budget)
        {
            Console.WriteLine("The company bought all mobile phones. {0:f2} leva left.", budget - total);
        }
        else
        {
            Console.WriteLine("Not enough money for all mobiles. Company needs {0:f2} more leva.", total - budget);
        }
    }
}