using System;

namespace _05._00_Care_of_Puppy
{
    class Program
    {
        static void Main()
        {
            decimal foodInGrams = Int32.Parse(Console.ReadLine()) * 1000;

            decimal needFood = 0;

            while (true)
            {
                string food = Console.ReadLine();

                if (food == "Adopted")
                {
                    break;
                }

                needFood += decimal.Parse(food);
            }

            if (foodInGrams >= needFood)
            {
                Console.WriteLine("Food is enough! Leftovers: {0} grams.", foodInGrams - needFood);
            }
            else
            {
                Console.WriteLine("Food is not enough. You need {0} grams more.", needFood - foodInGrams);
            }
        }
    }
}
