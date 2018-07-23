using System;
class Program
{
    static void Main()
    {
        int kgOfFood = int.Parse(Console.ReadLine()) * 1000;
        double food = 0;

        while (true)
        {
            string command = Console.ReadLine();
            if (command == "Adopted")
            {
                break;
            }
            food += int.Parse(command);
        }
        if (kgOfFood >= food)
        {
            Console.WriteLine($"Food is enough! Leftovers: {kgOfFood - food} grams.");
        }
        else
        {
            Console.WriteLine($"Food is not enough. You need {food - kgOfFood} grams more.");
        }
    }
}