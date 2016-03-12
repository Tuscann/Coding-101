using System;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Services;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number in the range [1...100]: ");
        var n = int.Parse(Console.ReadLine());

        while (n > 100 || n < 1)
        {
            Console.WriteLine("Invalid number!");
            Console.Write("Enter a number in the range [1...100]: ");
            n = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("The number is: {0}",n);

    }
}

