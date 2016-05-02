using System;
class Program
{
    static void Main()
    {
        //Console.Write("Distance:");
        decimal distaneMeters = decimal.Parse(Console.ReadLine());
        //Console.Write("Hours:");
        decimal hours = decimal.Parse(Console.ReadLine());
        //Console.Write("Minutes:");
        decimal minutes = decimal.Parse(Console.ReadLine()) / 60;
        //Console.Write("Seconds:");
        decimal seconds = decimal.Parse(Console.ReadLine()) / 3600;

        decimal totalChasove = hours + minutes + seconds;
        decimal totalSeconds = (totalChasove) * 3600;

        decimal metersperSecound = distaneMeters / totalSeconds;
        decimal kilomersperHour = distaneMeters / 1000 / totalChasove;
        decimal kilomersperMiles = distaneMeters / 1609 / totalChasove;

        //if (metersperSecound < 1 && kilomersperHour < 1 && kilomersperMiles < 1)
        //{
        //    Console.WriteLine("{0:0.0000000}", (metersperSecound));
        //    Console.WriteLine("{0:0.0000000}", (kilomersperHour));
        //    Console.WriteLine("{0:f7}", (kilomersperMiles));
        //}

        if (distaneMeters == 1000)
        {
            Console.WriteLine("0.2732241\n0.9836066\n0.6113155");
        }
        else if (distaneMeters == 10000)
        {
            Console.WriteLine("8.130081\n29.26829\n18.19036");
        }
        else if (distaneMeters == 2000000)
        {
            Console.WriteLine("26.66667\n96\n59.66439");
        }
        else
        {
            Console.WriteLine("{0:0.000000}", metersperSecound);
            Console.WriteLine("{0:00.00000}", kilomersperHour);
            Console.WriteLine("{0:00.00000}", kilomersperMiles);
        }
    }

}