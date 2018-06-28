using System;
class Program
{
    static void Main()
    {
        double width = double.Parse(Console.ReadLine());
        double length = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());
        double middleHeight = double.Parse(Console.ReadLine());

        double x = Math.Floor(width * length * height / ((middleHeight + 0.4) * 4));

        if (x >= 3 && x <= 10)
        {
            Console.WriteLine("The spacecraft holds {0} astronauts.", x);
        }
        if (x < 3)
        {
            Console.WriteLine("The spacecraft is too small.");
        }
        if (x > 10)
        {
            Console.WriteLine("The spacecraft is too big.");
        }
    }
}