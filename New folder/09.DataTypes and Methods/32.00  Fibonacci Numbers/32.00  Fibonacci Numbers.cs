using System;
class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int fib0 = 1;
        int fib1 = 1;
        for (int i = 0; i < n-1; i++)
        {
            int nextFib = fib0 + fib1;
            fib0 = fib1;
            fib1 = nextFib;
        }
        Console.WriteLine(fib1);
    }
}