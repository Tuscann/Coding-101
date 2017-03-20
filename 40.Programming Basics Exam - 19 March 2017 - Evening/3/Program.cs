using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main()
        {
            string season = Console.ReadLine();
            double budjet = double.Parse(Console.ReadLine());

            double pricePerKM = 0;
            if (season == "Summer")
            {
                if (budjet <= 5000)
                {
                    pricePerKM = 0.9;

                }
                else if (budjet > 5000 && budjet <= 10000)
                {
                    pricePerKM = 1.1;
                }
                else if (budjet > 10000 && budjet <= 20000)
                {
                    pricePerKM = 1.45;
                }

            }
            else if (season == "Winter")
            {
                if (budjet <= 5000)
                {
                    pricePerKM = 1.05;
                }
                else if (budjet > 5000 && budjet <= 10000)
                {
                    pricePerKM = 1.25;
                }
                else if (budjet > 10000 && budjet <= 20000)
                {
                    pricePerKM = 1.45;
                }
            }
            else
            {
                if (budjet <= 5000)
                {
                    pricePerKM = 0.75;
                }
                else if (budjet > 5000 && budjet <= 10000)
                {
                    pricePerKM = 0.95;
                }
                else if (budjet > 10000 && budjet <= 20000)
                {
                    pricePerKM = 1.45;
                }
            }
            Console.WriteLine("{0:f2}", (pricePerKM * budjet * 4) * 0.9);
        }
    }
}
