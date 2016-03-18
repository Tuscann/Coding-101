using System;
class BabaTincheAirlines
{
    static void Main()
    {
        string[] firstInput = Console.ReadLine().Split();
        string[] secondInput = Console.ReadLine().Split();
        string[] thirdInput = Console.ReadLine().Split();

        // Calculating the income from First Class passengers
        int firstClassIncome = (Convert.ToInt32(firstInput[0]) - Convert.ToInt32(firstInput[1])) * 7000;
        firstClassIncome += (int)(Convert.ToInt32(firstInput[1]) * (7000 * 0.3));
        firstClassIncome += (int)(Convert.ToInt32(firstInput[2]) * (0.005 * 7000));

        // Calculating the income from Business Class passengers
        int secondClassIncome = (Convert.ToInt32(secondInput[0]) - Convert.ToInt32(secondInput[1])) * 3500;
        secondClassIncome += (int)(Convert.ToInt32(secondInput[1]) * (3500 * 0.3));
        secondClassIncome += (int)(Convert.ToInt32(secondInput[2]) * (0.005 * 3500));

        // Calculating the income from Economy Class passengers
        int thirdClassIncome = (Convert.ToInt32(thirdInput[0]) - Convert.ToInt32(thirdInput[1])) * 1000;
        thirdClassIncome += (int)(Convert.ToInt32(thirdInput[1]) * (1000 * 0.3));
        thirdClassIncome += (int)(Convert.ToInt32(thirdInput[2]) * (0.005 * 1000));

        // Calculating the total income
        int totalIncome = firstClassIncome + secondClassIncome + thirdClassIncome;

        // Calculate the maximum possible income
        int maxIncome = (int)(12 * 7000 + 12 * (0.005 * 7000)) + (int)(28 * 3500 + 28 * (0.005 * 3500)) + (int)(50 * 1000 + 50 * (0.005 * 1000));

        Console.WriteLine(totalIncome);
        Console.WriteLine(maxIncome - totalIncome);
    }
}