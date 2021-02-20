using System;

namespace _04._00_Food_for_Pets
{
    class Program
    {
        static void Main()
        {
            int days = Int32.Parse(Console.ReadLine());
            double LeftFood = double.Parse(Console.ReadLine());

            double totalFoodEatenByDog = 0;
            double totalFoodEatenByCat = 0;

            double biscuits = 0;

            for (int i = 1; i <= days; i++)
            {
                double foodForDog = Int32.Parse(Console.ReadLine());
                double foodForCat = Int32.Parse(Console.ReadLine());

                totalFoodEatenByDog += foodForDog;
                totalFoodEatenByCat += foodForCat;

                if (i % 3 == 0)
                {
                    biscuits += (foodForDog + foodForCat) * 0.1;
                }
            }

            double totalEaten = totalFoodEatenByDog + totalFoodEatenByCat;

            Console.WriteLine("Total eaten biscuits: {0}gr.", Math.Round(biscuits));
            Console.WriteLine("{0:f2}% of the food has been eaten.", totalEaten / LeftFood * 100);
            Console.WriteLine("{0:f2}% eaten from the dog.", 100 - totalFoodEatenByCat / totalEaten * 100.0);
            Console.WriteLine("{0:f2}% eaten from the cat.", 100 - totalFoodEatenByDog / totalEaten * 100.0);
        }
    }
}
