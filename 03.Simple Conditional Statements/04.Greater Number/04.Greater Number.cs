using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter two integers: ");
        var firstNumber = double.Parse(Console.ReadLine());
        var SecondNumber = double.Parse(Console.ReadLine());

        if (firstNumber > SecondNumber)
        {
            Console.WriteLine("Greater number: {0}", firstNumber);
        }
        else
        {
            Console.WriteLine("Greater number: {0}", SecondNumber);
        }
    }
}

