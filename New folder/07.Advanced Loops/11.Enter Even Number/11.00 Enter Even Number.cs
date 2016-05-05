using System;
class Program
{
    static void Main()
    {
        var n = 0;
        while (true)
        {
            try
            {
                n = int.Parse(Console.ReadLine());
                if (n % 2 == 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("This is not even number!");
                }
            }
            catch
            {
                Console.WriteLine("Invalid number");
            }
        }
        Console.WriteLine(n);
    }
}