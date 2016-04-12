using System;
class Program
{
    static void Main()
    {
        decimal workHours = decimal.Parse(Console.ReadLine());
        decimal daysToFinish = decimal.Parse(Console.ReadLine());
        decimal productivity = decimal.Parse(Console.ReadLine());
        
        decimal total = Math.Floor((daysToFinish * (decimal)0.90 * (decimal)12) * (decimal)productivity / (decimal)100);
        
        if (workHours > total)
        {
            Console.WriteLine("No\n-{0}", workHours - total);
        }
        else if (total >= workHours)
        {
            Console.WriteLine("Yes\n{0}", total - workHours);
        }


    }
}

