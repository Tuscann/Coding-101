using System;

class Program
{
    static void Main()
    {
        var number = int.Parse(Console.ReadLine());
        var gem = Console.ReadLine()[0];


        Console.Write(new string('-', (number - 1) / 2));
        Console.Write(gem);
        Console.WriteLine(new string('-', (number - 1) / 2));


        int rows = (number - 1) / 2;
        for (int curentRow = 0; curentRow < rows; curentRow++)
        {
            var numberOfDashes = curentRow * 2 + 1;
            var numberOfDashesOutside = number - 2 - numberOfDashes;
            Console.Write(new string('-', numberOfDashesOutside / 2));
            Console.Write(gem);
            Console.Write(new string(gem, numberOfDashes));
            Console.Write(gem);
            Console.WriteLine(new string('-', numberOfDashesOutside / 2));

        }
        for (int curentRow = rows - 2; curentRow >= 0; curentRow--)
        {
            var numberOfDashes = (curentRow * 2) + 1;
            var numberOfDashesOutside = number - 2 - numberOfDashes;
            Console.Write(new string('-', numberOfDashesOutside / 2));
            Console.Write(gem);
            Console.Write(new string(gem, numberOfDashes));
            Console.Write(gem);
            Console.WriteLine(new string('-', numberOfDashesOutside / 2));
        }
        Console.Write(new string('-', (number - 1) / 2));
        Console.Write(gem);
        Console.WriteLine(new string('-', (number - 1) / 2));
    }
    
}


