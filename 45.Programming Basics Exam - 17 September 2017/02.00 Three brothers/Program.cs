using System;
class Program
{
    static void Main() // 100/100
    {
        double first = double.Parse(Console.ReadLine());
        double secound = double.Parse(Console.ReadLine());
        double third = double.Parse(Console.ReadLine());
        double father = double.Parse(Console.ReadLine());

        double timeWithRest = 1 / (1 / first + 1 / secound + 1 / third) * 1.15;
        double time = father - timeWithRest;

        Console.WriteLine("Cleaning time: {0:f2}", timeWithRest);

        if (time > 0)
        {
            Console.WriteLine("Yes, there is a surprise - time left -> {0} hours.", Math.Floor(time));
        }
        else
        {
            Console.WriteLine("No, there isn't a surprise - shortage of time -> {0} hours.", Math.Abs(Math.Floor(time)));
        }
    }
}