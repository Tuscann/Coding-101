using System;

namespace _03._00_Energy_Booster
{
    class Program
    {
        static void Main()
        {
            string fruit = Console.ReadLine();
            string size = Console.ReadLine();
            int orderSets = Int32.Parse(Console.ReadLine());

            decimal fruitPrice = 0;
            decimal sizeNumber = 0;

            if (fruit == "Watermelon")
            {
                if (size == "small")
                {
                    sizeNumber = 2;
                    fruitPrice = 56;
                }
                else if (size == "big")
                {
                    sizeNumber = 5;
                    fruitPrice = 28.7m;
                }
            }
            else if (fruit == "Mango")
            {
                if (size == "small")
                {
                    sizeNumber = 2;
                    fruitPrice = 36.66m;
                }
                else if (size == "big")
                {
                    sizeNumber = 5;
                    fruitPrice = 19.6m;
                }
            }
            else if (fruit == "Pineapple")
            {
                if (size == "small")
                {
                    sizeNumber = 2;
                    fruitPrice = 42.1m;
                }
                else if (size == "big")
                {
                    sizeNumber = 5;
                    fruitPrice = 24.8m;
                }
            }
            else if (fruit == "Raspberry")
            {
                if (size == "small")
                {
                    sizeNumber = 2;
                    fruitPrice = 20;
                }
                else if (size == "big")
                {
                    sizeNumber = 5;
                    fruitPrice = 15.2m;
                }
            }
            decimal result = sizeNumber * fruitPrice * orderSets;

            if (result >= 400 && result <= 1000)
            {
                result *= (decimal)0.85;
            }
            else if (result > 1000)
            {
                result *= (decimal)0.5;
            }

            Console.WriteLine("{0:f2} lv.", result);
        }
    }
}
