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
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double z = double.Parse(Console.ReadLine());


            double straniza = x * y;
            double window = 1.5 * 1.5;
            double dveStranizi = 2 * straniza - 2 * window;
            double back = x * x;
            double entrance = 1.2 * 2;
            double frontEnd = 2 * back - entrance;

            double total = dveStranizi + frontEnd;
            double greenPaint = total / 3.4;

            Console.WriteLine("{0:F2}", greenPaint);
            double rectangleRoof = 2 * x * y;
            double twoTriangle = 2 * (x * z / 2);

            double redpaint = (rectangleRoof + twoTriangle) / 4.3;
            Console.WriteLine("{0:F2}", redpaint);

        }
    }
}
