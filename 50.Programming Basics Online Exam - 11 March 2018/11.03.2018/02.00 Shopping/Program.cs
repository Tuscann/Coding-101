using System;
class Program
{
    static void Main()
    {
        double budget = double.Parse(Console.ReadLine());
        int countChocolates = int.Parse(Console.ReadLine());
        double milk = double.Parse(Console.ReadLine());

        double priceAll = countChocolates * 0.65 + milk * 2.70 + (countChocolates - Math.Ceiling(countChocolates * 0.35)) * 0.2;
        
        if (budget >= priceAll )
        {
            Console.WriteLine("You got this, {0:f2} money left!", budget - priceAll );
        }
        else
        {
            Console.WriteLine("Not enough money, you need {0:f2} more!", priceAll  - budget);
        }
    }
}