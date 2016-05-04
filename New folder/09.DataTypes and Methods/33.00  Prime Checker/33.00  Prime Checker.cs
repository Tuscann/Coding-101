using System;
class Program
{
    static void Main()
    {
        double n = double.Parse(Console.ReadLine()); ;
        int counter = (int)Math.Sqrt(n);
        bool isPrime = true;
        if (n > 1)
        {
            for (int cnt = 2; cnt <= counter; cnt++)
            {
                if (n % cnt == 0)
                {
                    isPrime = false;
                    break;
                }
            }
        }
        else
        {
            isPrime = false;
        }
        //if (isPrime) { Console.WriteLine("true"); }
        //else { Console.WriteLine("false"); }
        Console.WriteLine(isPrime ? "true" : "false", n);
    }
}