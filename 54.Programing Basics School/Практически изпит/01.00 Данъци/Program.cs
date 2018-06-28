using System;
    class Program
    {
        static void Main()
        {
            double moneyStoqn = double.Parse(Console.ReadLine());
            double moneyStoqnafter = double.Parse(Console.ReadLine());
            double danak = double.Parse(Console.ReadLine());

            double sum = moneyStoqnafter - moneyStoqn;
           
            double f1 = sum * 0.4;
            double f2 = f1 * 0.5;
            double x = (sum - f1 - f2) * danak / 100.0;

            Console.WriteLine("Capital at the end of the year: EUR {0:f2}", moneyStoqn + (sum - f1 - f2) - x);
            Console.WriteLine("Taxes Paid: EUR {0:f2}", x);
        }
    }