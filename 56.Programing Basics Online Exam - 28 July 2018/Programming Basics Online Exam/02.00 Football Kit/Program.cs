using System;

internal class Program
{
    public static void Main()
    {
        double priceTishrt = double.Parse(Console.ReadLine());
        double winBall = double.Parse(Console.ReadLine());

        double total = (priceTishrt * 0.75 * 0.2 + priceTishrt * 1.75 * 3) * 0.85;

        if (total >= winBall)
        {
            Console.WriteLine("Yes, he will earn the world-cup replica ball!\nHis sum is {0:f2} lv."
                , total);
        }
        else
        {
            Console.WriteLine("No, he will not earn the world-cup replica ball.\nHe needs {0:f2} lv. more.",
                winBall - total);
        }
    }
}