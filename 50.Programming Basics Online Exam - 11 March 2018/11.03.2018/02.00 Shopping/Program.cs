using System;
class Program
{
    static void Main()
    {
        double budget = double.Parse(Console.ReadLine());
        int countChocolates = int.Parse(Console.ReadLine());
        double milk = double.Parse(Console.ReadLine());

        double sum = countChocolates * 0.65 + milk * 2.70 + (countChocolates - Math.Ceiling((countChocolates * 0.35))) * 0.2;
        
        if (budget >= sum)
        {
            Console.WriteLine("You got this, {0:f2} money left!", budget - sum);
        }
        else
        {
            Console.WriteLine("Not enough money, you need {0:f2} more!", sum - budget);
        }
    }
}