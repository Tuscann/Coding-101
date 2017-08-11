using System;
class Program
{
    static void Main()
    {
        double v = double.Parse(Console.ReadLine());
        double P1 = double.Parse(Console.ReadLine());
        double P2 = double.Parse(Console.ReadLine());
        double H = double.Parse(Console.ReadLine());

        double first = P1 * H;
        double secound = P2 * H;
        double total = first + secound;

        if (total <= v)
        {
            double prozent = total / (v / 100);
            double prozentfirst = first / (total / 100);
            double prozentsecound = secound / (total / 100);

            Console.WriteLine("The pool is {0}% full. Pipe 1: {1:f0}%. Pipe 2: {2:f0}%.", (int)prozent, (int)prozentfirst, (int)prozentsecound);
        }
        else if (total > v)
        {
            double more = total - v;

            Console.WriteLine("For {0} hours the pool overflows with {1:f1} liters.", H, more);
        }
    }
}