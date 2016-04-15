using System;
class Budget
{
    static void Main()
    {
        int budget = int.Parse(Console.ReadLine());
        int goingOut = int.Parse(Console.ReadLine());
        int hometown = int.Parse(Console.ReadLine());
        int expenses = goingOut * (int)((0.03 * budget) + 10) +
            ((22 - goingOut) * 10) +
            ((4 - hometown) * 2 * 20) +
            150;

        if (expenses == budget)
        {
            Console.WriteLine("Exact Budget.");
        }
        else if (expenses < budget)
        {
            Console.WriteLine("Yes, leftover {0}.", budget - expenses);
        }
        else
        {
            Console.WriteLine("No, not enough {0}.", expenses - budget);
        }
    }
}
