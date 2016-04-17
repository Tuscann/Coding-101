using System;
class DrunkAni
{
    static void Main()
    {
        long numberOfCabins = long.Parse(Console.ReadLine());
        long currentPosition = 0;
        long totalLenghtCovered = 0;
        long stepsCount = 0;
        
        while (true)
        {
            string nextCommand = Console.ReadLine();
            if (nextCommand == "Found a free one!"){break;}

            stepsCount = int.Parse(nextCommand);

            long oldPosition = currentPosition;
            currentPosition = (currentPosition + stepsCount) % numberOfCabins;
            long difference = currentPosition - oldPosition;

            if (difference > 0)
            {
                Console.WriteLine("Go {0} steps to the right, Ani.", Math.Abs(difference));
            }
            else if (difference < 0)
            {
                Console.WriteLine("Go {0} steps to the left, Ani.", Math.Abs(difference));
            }
            else
            {
                Console.WriteLine("Stay there, Ani.");
            }
            totalLenghtCovered += Math.Abs(difference);
        }
        Console.WriteLine("Moved a total of {0} steps.", Math.Abs(totalLenghtCovered));
    }
}
