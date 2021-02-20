using System;

namespace Exam
{
    class Program
    {
        static void Main()
        {
            int bitcoin = Int32.Parse(Console.ReadLine());
            decimal chinsUna = decimal.Parse(Console.ReadLine());
            decimal commission = decimal.Parse(Console.ReadLine());
            
            decimal sum = (bitcoin * 1168 + chinsUna * (decimal)0.15 * (decimal)1.76) / (decimal)1.95 * (1 - commission / 100);

            Console.WriteLine("{0:F2}", sum);
        }
    }
}