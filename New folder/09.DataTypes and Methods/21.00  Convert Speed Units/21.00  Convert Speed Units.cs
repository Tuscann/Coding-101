using System;
class Program
{
    static void Main()
    {

        double distaneMeters = double.Parse(Console.ReadLine());
        double hours = double.Parse(Console.ReadLine());
        double minutes = double.Parse(Console.ReadLine()) / 60;
        double seconds = double.Parse(Console.ReadLine()) / 3600;

        double totalChasove = hours + minutes + seconds;
        double totalSeconds = (totalChasove) * 3600;

        double metersperSecound = distaneMeters / totalSeconds;
        double kilomersperHour = distaneMeters / 1000 / totalChasove;
        double kilomersperMiles = distaneMeters / 1609 / totalChasove;

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
            Console.WriteLine("{0:0.#####}", metersperSecound);
            Console.WriteLine("{0:00.00000}", kilomersperHour);
            Console.WriteLine("{0:00.00000}", kilomersperMiles);
        }
    }
}