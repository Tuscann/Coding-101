using System;
class Program
{
    static void Main()
    {
        var firstNumber = double.Parse(Console.ReadLine());
        var secondNumber = double.Parse(Console.ReadLine());
        var thrithNumber = double.Parse(Console.ReadLine());

        if ((firstNumber == secondNumber) && (firstNumber == thrithNumber))
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}

