using System;

class Program
{
    static void Main()
    {
        var type = Console.ReadLine().ToLower();
        var rows = int.Parse(Console.ReadLine());
        var colums = int.Parse(Console.ReadLine());
        var ticketPrice = 0m;

        if (type == "premiere") { ticketPrice = 12.00m; }
        else if (type == "normal") { ticketPrice = 7.50m; }
        else if (type == "discount") { ticketPrice = 5.00m; }

        Console.WriteLine("{0:0.00} leva", (rows * colums * ticketPrice));

    }

}


