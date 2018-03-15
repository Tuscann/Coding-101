using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        if (n > 7)
        {
            Console.WriteLine("Sorry, you can't carry so many things!");
        }
        else
        {
            int budget = int.Parse(Console.ReadLine());
            int totalCost = 0;
            int gunPrice = 0;
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                switch (input)
                {
                    case "ak47": gunPrice = 2700; break;
                    case "awp": gunPrice = 4750; break;
                    case "sg553": gunPrice = 3500; break;
                    case "grenade": gunPrice = 300; break;
                    case "flash": gunPrice = 250; break;
                    case "glock": gunPrice = 500; break;
                    case "bazooka": gunPrice = 5600; break;
                }
                totalCost += gunPrice;
            }

            if (totalCost > budget)
            {
                Console.WriteLine($"Not enough money! You need {totalCost - budget} more money.");
            }
            else
            {
                Console.WriteLine($"You bought all {n} items! Get to work and defeat the bomb!");
            }
        }
    }
}