using System;
namespace ConsoleApp3
{
    class Program
    {
        static void Main()
        {
            float prizeTrip = float.Parse(Console.ReadLine());
            float numberPizzels = float.Parse(Console.ReadLine());
            float numberDools = float.Parse(Console.ReadLine());
            float numberBears = float.Parse(Console.ReadLine());
            float numberMinions = float.Parse(Console.ReadLine());
            float numberTrucks = float.Parse(Console.ReadLine());

            float prizePuzzels = 2.60f;
            float prizeDools = 3f;
            float prizeBear = 4.1f;
            float prizeMinions = 8.2f;
            float prizeTruck = 2f;

            float total = numberPizzels * prizePuzzels + (numberDools * prizeDools) + (numberBears * prizeBear) + numberMinions * prizeMinions + numberTrucks * prizeTruck;

            float countToys = numberPizzels + numberBears + numberDools + numberMinions + numberTrucks;

            if (countToys >= 50)
            {
                total *= 0.75f;
            }
            total *= 0.9f;

            if (total >= prizeTrip)
            {
                Console.WriteLine("Yes! {0:f2} lv left.", total - prizeTrip);
            }
            else
            {
                Console.WriteLine("Not enough money! {0:f2} lv needed. ", prizeTrip - total);
            }
        }
    }
}
