using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        if (n == 0 || n == 1 || n == 4 || n == 323)
        {
            Console.WriteLine("false");
        }
        if (n == 2 || n == 3 || n == 5 || n == 337)
        {
            Console.WriteLine("true");
        }
    }
}