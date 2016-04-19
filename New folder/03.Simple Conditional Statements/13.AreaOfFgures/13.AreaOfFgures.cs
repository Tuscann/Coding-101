using System;
class Program
{
    static void Main()
    {
        var figure = Console.ReadLine();

        if (figure == "square")
        {
            var firstNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:0.000}", firstNumber * firstNumber);
        }
        else if (figure == "rectangle")
        {
            var firstNumber = double.Parse(Console.ReadLine());
            var secondNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:0.000}", firstNumber * secondNumber);
        }
        else if (figure == "circle")
        {
            var firstNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:0.000}", Math.PI * firstNumber * firstNumber);
        }
        else if (figure == "triangle")
        {
            var firstNumber = double.Parse(Console.ReadLine());
            var secondNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:0.000}", firstNumber * secondNumber * 0.5);
        }
    }
}

