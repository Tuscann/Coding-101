using System;
class Program
{
    static void Main()
    {
        int countProssors = int.Parse(Console.ReadLine());
        int countWorkers = int.Parse(Console.ReadLine());
        int workingDay = int.Parse(Console.ReadLine());

        double sum = workingDay * countWorkers * 8;
        double midle = Math.Floor(sum / 3);

        if (midle < countProssors)
        {
            Console.WriteLine("Losses: -> {0:f2} BGN", (countProssors - midle) * 110.1);
        }
        else
        {
            Console.WriteLine("Profit: -> {0:f2} BGN", (midle - countProssors) * 110.1);
        }
    }
}