using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        bool[] primes = new bool[n + 1];
        for (int i = 0; i < n; i++)
        {
            primes[i] = true;
        }
        primes[0] = primes[1] = false;
        
        for (int p = 2; p < n; p++)
        {
            if (primes[p])
            {
                Fillprimes(primes, p);
            }
        }
        Console.WriteLine();

        


    }
    static void Fillprimes(bool[] primes, int step)
    {
        for (int i = 2 * step; i < primes.Length; i += step)
        {
            primes[i] = false;
        }
    }
}

