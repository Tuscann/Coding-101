using System;

namespace _02._00_Cat_Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutesPerDay = Int32.Parse(Console.ReadLine());
            int count = Int32.Parse(Console.ReadLine());
            int calories = Int32.Parse(Console.ReadLine());

            int result = minutesPerDay * count * 5;

            if (result >= calories / 2)
            {
                Console.WriteLine("Yes, the walk for your cat is enough. Burned calories per day: {0:f0}.", result);
            }
            else
            {
                Console.WriteLine("No, the walk for your cat is not enough. Burned calories per day: {0:f0}.", result);
            }
        }
    }
}
