using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._00_Коледна_Статистика
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int Beverages = 0;
            int Sweets = 0;
            int Presents = 0;
            int other = 0;

            double total = 0;

            for (int i = 0; i < n; i++)
            {
                var product = Console.ReadLine();
                double priceProduct = double.Parse(Console.ReadLine());
                int quantity = int.Parse(Console.ReadLine());

                total += priceProduct * quantity;

                if (product == "cola" || product == "wine")
                {
                    Beverages++;
                }
                else if (product == "baklavichka" || product == "cupcake")
                {
                    Sweets++;
                }
                else if (product == "flower" || product == "chocolates" || product == "book")
                {
                    Presents++;
                }
                else
                {
                    other++;
                }
            }
            double swetss = 0;
            double beveragesCount = 0;
            double presentsCount = 0;
            double otherss = 0;


            if (Sweets != 0)
            {
                swetss = 100.0 / (n * 1.0 / Sweets);
            }
            if (Beverages != 0)
            {
                beveragesCount = 100.0 / (n * 1.0 / Beverages);
            }
            if (Presents != 0)
            {
                presentsCount = 100.0 / (n * 1.0 / Presents);
            }
            if (other != 0)
            {
                otherss = 100.0 / ((double)n / other);
            }

            Console.WriteLine("Total money spent: {0:f2}", total);
            Console.WriteLine("Money spent on: Sweets - {0:f2}%; Beverages - {1:f2}%; Presents - {2:f2}%;", swetss, beveragesCount, presentsCount);
            Console.WriteLine("Money spent on other products: {0:f2} or {1:f2}%", otherss / 100 * total, otherss);
        }
    }
}
