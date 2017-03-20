using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {

            double budjet = double.Parse(Console.ReadLine());
            double areaHouse = double.Parse(Console.ReadLine());
            double countWindows = double.Parse(Console.ReadLine());
            double areaSteriopor = double.Parse(Console.ReadLine());
            double priceSteriopor = double.Parse(Console.ReadLine());

            double areaWindows = 2.4;
            double fira = 1.1;

            double usebaleArea = fira * (areaHouse - countWindows * areaWindows);
            double needpackets = Math.Ceiling(usebaleArea / areaSteriopor);
            double neededMoneySteriopor = needpackets * priceSteriopor;

            if (neededMoneySteriopor < budjet)
            {
                Console.WriteLine("Spent: {0:f2}", neededMoneySteriopor);
                Console.WriteLine("Left: {0:f2}", budjet - neededMoneySteriopor);
            }
            else
            {
                Console.WriteLine("Need more: {0:f2}", neededMoneySteriopor - budjet);
            }
        }
    }
}
