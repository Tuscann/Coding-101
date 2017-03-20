using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            double area = double.Parse(Console.ReadLine());
            double kilograms = double.Parse(Console.ReadLine());
            double garbuage = double.Parse(Console.ReadLine());

            double weightGrapes = 7.5;
            double priceGrapes = 9.8;
            double priceRakiya = 1.5;

            double grapes = (area * kilograms) - garbuage;
            double rakia = 0.45* grapes;
            double income = (rakia/weightGrapes)*priceGrapes;
            Console.WriteLine("{0:F2}", income);
            Console.WriteLine("{0:F2}", 0.55 * grapes * priceRakiya);

        }
    }
}
