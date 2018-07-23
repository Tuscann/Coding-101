using System;
class Program
{
    static void Main()
    {
        int numOfCats = int.Parse(Console.ReadLine());

        int groupOne = 0;
        int groupTwo = 0;
        int groupThree = 0;
        double totalFood = 0;

        for (int i = 1; i <= numOfCats; i++)
        {
            double food = double.Parse(Console.ReadLine());
            totalFood += food;

            if (food >= 100 && food < 200)
            {
                groupOne++;
            }
            else if (food < 300)
            {
                groupTwo++;
            }
            else if (food < 400)
            {
                groupThree++;
            }
        }

        Console.WriteLine($"Group 1: {groupOne} cats.");
        Console.WriteLine($"Group 2: {groupTwo} cats.");
        Console.WriteLine($"Group 3: {groupThree} cats.");
        Console.WriteLine("Price for food per day: {0} lv.", Math.Round(totalFood / 1000 * 12.45, 2));
    }
}