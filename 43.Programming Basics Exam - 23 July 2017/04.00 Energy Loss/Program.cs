using System;
class Program
{
    static void Main()
    {
        int trainingsDays = int.Parse(Console.ReadLine());
        int countDansers = int.Parse(Console.ReadLine());

        double leftEnergy = 100 * countDansers * trainingsDays;

        for (int i = 1; i <= trainingsDays; i++)
        {
            int curent = int.Parse(Console.ReadLine());

            if (curent % 2 == 0 && i % 2 == 0)
            {
                leftEnergy -= 68 * countDansers;
            }
            else if (curent % 2 != 0 && i % 2 == 0)
            {
                leftEnergy -= 65 * countDansers;
            }
            else if (curent % 2 != 0 && i % 2 != 0)
            {
                leftEnergy -= 30 * countDansers;
            }
            else if (curent % 2 == 0 && i % 2 != 0)
            {
                leftEnergy -= 49 * countDansers;
            }
        }
        double energyPerDancer = leftEnergy / countDansers / trainingsDays;
        
        if (energyPerDancer > 50)
        {
            Console.WriteLine("They feel good! Energy left: {0:f2}", energyPerDancer);
        }
        else
        {
            Console.WriteLine("They are wasted! Energy left: {0:f2}", energyPerDancer);
        }
    }
}