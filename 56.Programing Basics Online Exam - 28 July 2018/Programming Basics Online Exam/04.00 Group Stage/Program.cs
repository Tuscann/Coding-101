using System;

internal class Program
{
    public static void Main()
    {
        string country = Console.ReadLine();
        int counterMatches = int.Parse(Console.ReadLine());

        int totalPoints = 0;
        int totalInside = 0;
        int totalOutside = 0;

        for (int i = 0; i < counterMatches; i++)
        {
            int insideGoals = int.Parse(Console.ReadLine());
            int outeGoals = int.Parse(Console.ReadLine());

            totalInside += insideGoals;
            totalOutside += outeGoals;

            if (insideGoals > outeGoals)
            {
                totalPoints += 3;
            }
            else if (insideGoals == outeGoals)
            {
                totalPoints += 1;
            }
        }

        if (totalOutside <= totalInside)
        {
            Console.WriteLine(country + " has finished the group phase with {0} points.", totalPoints);
            Console.WriteLine("Goal difference: {0}.", totalInside - totalOutside);
        }
        else
        {
            Console.WriteLine(country + " has been eliminated from the group phase.");
            Console.WriteLine("Goal difference: {0}.", totalInside - totalOutside);
        }
    }
}