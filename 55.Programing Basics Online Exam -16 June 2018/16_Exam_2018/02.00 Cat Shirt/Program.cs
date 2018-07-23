using System;
class Program
{
    static void Main()
    {
        double sizeSleeve = double.Parse(Console.ReadLine());
        double sizeFront = double.Parse(Console.ReadLine());
        string order = Console.ReadLine();
        string needTieOrNot = Console.ReadLine();

        double total = (sizeFront * 2 + sizeSleeve * 2) * 1.1 / 100;

        int fabricType = 0;

        switch (order)
        {
            case "Linen":
                fabricType = 15;
                break;
            case "Cotton":
                fabricType = 12;
                break;
            case "Denim":
                fabricType = 20;
                break;
            case "Twill":
                fabricType = 16;
                break;
            case "Flannel":
                fabricType = 11;
                break;
        }

        double price = total * fabricType + 10;

        if (needTieOrNot == "Yes")
        {
            price *= 1.2;
        }
        Console.WriteLine("The price of the shirt is: {0:f2}lv.", price);
    }
}