using System;

namespace _05._00_Suitcases_Load
{
    class Program
    {
        static void Main()
        {
            decimal totalCapacity = Decimal.Parse(Console.ReadLine());

            int counter = 0;
            int counterLagauge = 0;

            while (true)
            {
                string capacityLugage = Console.ReadLine();
                if (capacityLugage == "End")
                {
                    Console.WriteLine("Congratulations! All suitcases are loaded!");
                    break;
                }
                counter += 1;

                decimal currentWeight = decimal.Parse(capacityLugage);

                if (counter % 3 == 0)
                {
                    currentWeight *= 1.1m;
                }

                if (totalCapacity - currentWeight >= 0)
                {
                    totalCapacity -= currentWeight;
                    counterLagauge += 1;
                }
                else
                {
                    Console.WriteLine("No more space!");

                    break;
                }
            }
            Console.WriteLine("Statistic: {0} suitcases loaded.", counterLagauge);
        }
    }
}
