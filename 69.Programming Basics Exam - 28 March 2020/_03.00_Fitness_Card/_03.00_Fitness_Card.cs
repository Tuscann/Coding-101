using System;

namespace _03._00_Fitness_Card
{
    class Program
    {
        static void Main()
        {
            decimal sumMoney = Decimal.Parse(Console.ReadLine());
            string gender = Console.ReadLine();
            int age = Int32.Parse(Console.ReadLine());
            string sport = Console.ReadLine();

            decimal price = 0;

            if (gender == "m")
            {
                if (sport == "Gym")
                {
                    price = 42;
                }
                else if (sport == "Boxing")
                {
                    price = 41;
                }
                else if (sport == "Yoga")
                {
                    price = 45;
                }
                else if (sport == "Zumba")
                {
                    price = 34;
                }
                else if (sport == "Dances")
                {
                    price = 51;
                }
                else if (sport == "Pilates")
                {
                    price = 39;
                }

            }
            else if (gender == "f")
            {
                if (sport == "Gym")
                {
                    price = 35;
                }
                else if (sport == "Boxing")
                {
                    price = 37;
                }
                else if (sport == "Yoga")
                {
                    price = 42;
                }
                else if (sport == "Zumba")
                {
                    price = 31;
                }
                else if (sport == "Dances")
                {
                    price = 53;
                }
                else if (sport == "Pilates")
                {
                    price = 37;
                }
            }
            if (age <= 19)
            {
                price *= 0.8m;
            }

            if (price <= sumMoney)
            {
                Console.WriteLine("You purchased a 1 month pass for {0}.", sport);
            }
            else
            {
                Console.WriteLine("You don't have enough money! You need ${0:f2} more.", price - sumMoney);
            }
        }
    }
}
