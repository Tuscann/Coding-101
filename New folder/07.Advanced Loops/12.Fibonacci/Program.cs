using System;
class Program
{
    static void Main()
    {

        int n = int.Parse(Console.ReadLine());

        if (n < 2)
        {
            Console.WriteLine(1);
        }
        else
        {
            int fib0 = 1;
            int fib1 = 1;
            for (int i = 0; i < n - 1; i++)
            {
                int nextFib = fib0 + fib1;
                fib0 = fib1;
                fib1 = nextFib;
            }
            Console.WriteLine(fib1);
        }
    }
}