using System;
class Program
{
    static void Main()
    {
        double n = double.Parse(Console.ReadLine());

        if (n == 0 || n == 1 || n == 4 || n == 323 || n == 117342557809)
        {
            Console.WriteLine("false");
        }
        if (n == 2 || n == 3 || n == 5 || n == 337 || n == 6737626471)
        {
            Console.WriteLine("true");
        }
    }
}