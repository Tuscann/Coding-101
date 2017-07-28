using System;
class Program
{
    static void Main()
    {
        double youngBiker = double.Parse(Console.ReadLine());
        double oldBiker = double.Parse(Console.ReadLine());
        string typeTransport = Console.ReadLine();

        double total = 0.00;

        if (typeTransport == "trail")
        {
            total += (youngBiker * 5.50 + oldBiker * 7) * 0.95;
        }
        else if (typeTransport == "cross-country")
        {
            if (youngBiker + oldBiker >= 50)
            {
                total += (youngBiker * 8 + oldBiker * 9.50) * 0.75 * 0.95;
            }
            else
            {
                total += (youngBiker * 8 + oldBiker * 9.50) * 0.95;
            }
        }
        else if (typeTransport == "road")
        {
            total += (youngBiker * 20 + oldBiker * 21.50) * 0.95;
        }
        else if (typeTransport == "downhill")
        {
            total += (youngBiker * 12.25 + oldBiker * 13.75) * 0.95;

        }
        Console.WriteLine("{0:f2}", total);
    }
}