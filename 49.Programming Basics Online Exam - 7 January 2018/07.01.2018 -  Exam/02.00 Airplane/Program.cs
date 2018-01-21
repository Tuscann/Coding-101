using System;
class Program
{
    static void Main() // 100/100
    {
        int time = int.Parse(Console.ReadLine());
        int minutes = int.Parse(Console.ReadLine());
        int timeFlightLenght = int.Parse(Console.ReadLine());

        long total = time * 60 + minutes + timeFlightLenght;

        if (total / 60 >= 24)
        {
            Console.WriteLine("{0}h {1}m", (total / 60)-24, total % 60);
        }
        else
        {
            Console.WriteLine("{0}h {1}m", total / 60, total % 60);
        }
    }
}