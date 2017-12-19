using System;
class Program
{
    static void Main() //100/100
    {
        int countNifght = int.Parse(Console.ReadLine());
        string destination = Console.ReadLine();
        string typeTransport = Console.ReadLine();

        double priceParents = 0;
        double priceKids = 0;

        if (countNifght >= 1 && countNifght <= 10)
        {
            if (destination == "Miami")
            {
                priceParents = 24.99;
                priceKids = 14.99;
            }
            else if (destination == "Canary Islands")
            {
                priceParents = 32.5;
                priceKids = 28.5;
            }
            else if (destination == "Philippines")
            {
                priceParents = 42.99;
                priceKids = 39.99;
            }
        }
        else if (countNifght >= 11 && countNifght <= 15)
        {
            if (destination == "Miami")
            {
                priceParents = 22.99;
                priceKids = 11.99;
            }
            else if (destination == "Canary Islands")
            {
                priceParents = 30.50;
                priceKids = 25.60;
            }
            else if (destination == "Philippines")
            {
                priceParents = 41.00;
                priceKids = 36.00;
            }
        }
        else if (countNifght >= 16)
        {
            if (destination == "Miami")
            {
                priceParents = 20.00;
                priceKids = 10.00;
            }
            else if (destination == "Canary Islands")
            {
                priceParents = 28.00;
                priceKids = 22.00;
            }
            else if (destination == "Philippines")
            {
                priceParents = 38.50;
                priceKids = 32.40;
            }
        }
        double parentsTrnasport = 0;
        double kidsTrnasport = 0;

        if (typeTransport == "train")
        {
            parentsTrnasport = 22.30;
            kidsTrnasport = 12.50;
        }
        else if (typeTransport == "bus")
        {
            parentsTrnasport = 45.00;
            kidsTrnasport = 37.00;
        }
        else if (typeTransport == "airplane")
        {
            parentsTrnasport = 90.00;
            kidsTrnasport = 68.50;
        }
        double sum = countNifght * (2 * priceParents + 3 * priceKids) * 1.25;
        double sum2 = 2 * parentsTrnasport + 3 * kidsTrnasport;

        Console.WriteLine("{0:f3}", sum + sum2);
    }
}