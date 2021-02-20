using System;

namespace _01._Supplies_for_School
{
    class Program
    {
        static void Main()
        {
            int pens = Int32.Parse(Console.ReadLine());
            int markers = Int32.Parse(Console.ReadLine());
            decimal clearLiquid = decimal.Parse(Console.ReadLine());
            int commnision = Int32.Parse(Console.ReadLine());

            decimal sum = (pens * (decimal)5.80 + markers * (decimal)7.2 + clearLiquid * (decimal)1.2) * (1 - commnision / (decimal)100.0);

            Console.WriteLine("{0:F3}", sum);
        }
    }
}
