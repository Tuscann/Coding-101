using System;
class Program
{
    static void Main()
    {
        double steps = double.Parse(Console.ReadLine());
        double dancers = double.Parse(Console.ReadLine());
        double days = double.Parse(Console.ReadLine());
        
        double stepsPerDay = Math.Ceiling(1 * 100 / days);
        double procent = stepsPerDay / dancers;
        
        if (stepsPerDay <= 13)
        {
            Console.WriteLine("Yes, they will succeed in that goal! {0:f2}%.", procent);
        }
        else
        {
            Console.WriteLine("No, They will not succeed in that goal! Required {0:f2}% steps to be learned per day.", procent);
        }
    }
}