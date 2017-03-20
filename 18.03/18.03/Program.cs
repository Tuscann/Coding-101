using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18._03
{
    class Program
    {
        static void Main(string[] args)
        {
            double A = double.Parse(Console.ReadLine());
            double B = double.Parse(Console.ReadLine());
            
            double dveStranizi = A*(A/2)*2;
            double square = (A/2)*(A/2);
            double triangle = (A / 2 * (B - (A / 2)))/ 2; 
            double zadna = square + triangle;
            double pe = (A / 5) * (A / 5);
            //Console.WriteLine(dveStranizi);
            //Console.WriteLine(square);
           // Console.WriteLine(triangle);
           // Console.WriteLine(zadna);
            //Console.WriteLine(pe);

            double total = (dveStranizi + 2*zadna - pe)/3;
            
            Console.WriteLine("{0:F2}",total);
            Console.WriteLine("{0:F2}",dveStranizi/5);
        }
    }
}
