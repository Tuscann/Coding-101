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

                if (budjet <= 1000)
                {
                    Console.WriteLine("Alaska - Camp - {0:f2}",0.65*budjet);
                }
                else if (budjet > 1000 && budjet <= 3000)
                {
                    Console.WriteLine("Alaska - Hut - {0:f2}", 0.80 * budjet);
                }
                else if (budjet > 3000)
                {
                    Console.WriteLine("Alaska - Hotel - {0:f2}", 0.90 * budjet);
                }

            }
            else if (season == "Winter")
            {
                if (budjet <= 1000)
                {
                    Console.WriteLine("Morocco - Camp - {0:f2}", 0.45 * budjet);
                }
                else if (budjet > 1000 && budjet <= 3000)
                {
                    Console.WriteLine("Morocco - Hut - {0:f2}", 0.60 * budjet);
                }
                else if (budjet > 3000)
                {
                    Console.WriteLine("Morocco - Hotel - {0:f2}", 0.90 * budjet);
                }
            }

        }
    }
}
