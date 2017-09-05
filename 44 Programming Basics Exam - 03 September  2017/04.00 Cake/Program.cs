using System;
class Program
{
    static void Main() // 100/100
    {
        int weight = int.Parse(Console.ReadLine());
        int lenght = int.Parse(Console.ReadLine());
        long cakeSize = weight * lenght;
        bool finished = true;

        while (true)
        {
            string current = Console.ReadLine();
            if (current == "STOP")
            {
                break;
            }
            cakeSize -= int.Parse(current);
            if (cakeSize < 0)
            {
                finished = false;
                break;
            }
        }
        if (finished == false)
        {
            Console.WriteLine("No more cake left! You need {0} pieces more.", Math.Abs(cakeSize));
        }
        else
        {
            Console.WriteLine("{0} pieces are left.", cakeSize);
        }
    }
}