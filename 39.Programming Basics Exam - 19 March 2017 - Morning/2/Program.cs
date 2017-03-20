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

            double glasses = double.Parse(Console.ReadLine());
            double workers = double.Parse(Console.ReadLine());
            double workdays = double.Parse(Console.ReadLine());

            double hours = 8;
            double moneyForGlass = 4.2;

            double total = workers*workdays*hours;
            double madeGlasses = Math.Floor(total/5);

            

            if (madeGlasses < glasses)
            {
                Console.WriteLine("Losses: {0:f2}", (glasses - madeGlasses)*moneyForGlass);
            }
            else
            {
                Console.WriteLine("{0:f2} extra money", (madeGlasses-glasses) * moneyForGlass);
            }

        }
    }
}
