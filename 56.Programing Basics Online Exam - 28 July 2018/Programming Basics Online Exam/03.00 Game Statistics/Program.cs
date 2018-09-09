using System;

internal class Program
{
    public static void Main()
    {
        int minutes = int.Parse(Console.ReadLine());
        String name = Console.ReadLine();

        if (minutes == 0)
        {
            Console.WriteLine("Match has just began!");
        }
        else if (minutes >= 1 && minutes <= 44)
        {
            Console.WriteLine("First half time.");
        }
        else if (minutes >= 45)
        {
            Console.WriteLine("Second half time.");
        }

        if (minutes >= 1 && minutes <= 10)
        {
            Console.WriteLine(name + " missed a penalty.");
            if (minutes % 2 == 0)
            {
                Console.WriteLine(name + " was injured after the penalty.");
            }
        }
        else if (minutes >= 11 && minutes <= 35)
        {
            Console.WriteLine(name + " received yellow card.");
            if (minutes % 2 != 0)
            {
                Console.WriteLine(name + " got another yellow card.");
            }
        }
        else if (minutes >= 36 && minutes <= 44)
        {
            Console.WriteLine(name + " SCORED A GOAL !!!");
        }
        else if (minutes >= 46 && minutes <= 55)
        {
            Console.WriteLine(name + " got a freekick.");
            if (minutes % 2 == 0)
            {
                Console.WriteLine(name + " missed the freekick.");
            }
        }
        else if (minutes >= 56 && minutes <= 80)
        {
            Console.WriteLine(name + " missed a shot from corner.");
            if (minutes % 2 != 0)
            {
                Console.WriteLine(name + " has been changed with another player.");
            }
        }
        else if (minutes >= 81 && minutes <= 90)
        {
            Console.WriteLine(name + " SCORED A GOAL FROM PENALTY !!!");
        }
    }
}