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
        if (isPrime == true)
        {
            Console.WriteLine("Prime");
        }
        else if (n < 2)
        {
            Console.WriteLine("Not Prime");
        }
        else
        {
            Console.WriteLine("Not Prime");
        }
    }
}