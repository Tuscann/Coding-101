using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            double budjet = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            if (season == "Summer")
            {
                double cabrio = 0;

                if (budjet <= 100)
                {
                    Console.WriteLine("Economy class");
                    cabrio = 0.35 * budjet;
                    Console.WriteLine("Cabrio - {0:F2}", cabrio);
                }
                else if (budjet > 100 && budjet <= 500)
                {
                    Console.WriteLine("Compact class");
                    cabrio = 0.45 * budjet;
                    Console.WriteLine("Cabrio - {0:F2}", cabrio);
                }
                else if (budjet > 500)
                {
                    Console.WriteLine("Luxury class");
                    cabrio = 0.9 * budjet;
                    Console.WriteLine("Jeep - {0:F2}", cabrio);
                }

            }
            else if (season == "Winter")
            {
                double cabrio = 0;

                if (budjet <= 100)
                {
                    Console.WriteLine("Economy class");
                    cabrio = 0.65 * budjet;
                   
                }
                else if (budjet > 100 && budjet <= 500)
                {
                    Console.WriteLine("Compact class");
                    cabrio = 0.8 * budjet;
                }
                else if (budjet > 500)
                {
                    Console.WriteLine("Luxury class");
                    cabrio = 0.9 * budjet;
                }
                Console.WriteLine("Jeep - {0:F2}", cabrio);
            }
        }
    }
}
