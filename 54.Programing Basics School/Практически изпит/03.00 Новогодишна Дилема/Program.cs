using System;
class Program
{
    static void Main()
    {
        string cityName = Console.ReadLine();
        string transport = Console.ReadLine();
        string laggage = Console.ReadLine();
        double hours = double.Parse(Console.ReadLine());

        double time = 0;

        if (cityName == "Sofia")
        {
            if (transport == "Car")
            {
                time = 3;
            }
            else if (transport == "Train")
            {
                time = 4.5;
            }
            else if (transport == "Foot")
            {
                time = 55.5;
            }
            else if (transport == "Bus")
            {
                time = 3.7;
            }
        }
        else if (cityName == "Plovdiv")
        {
            if (transport == "Car")
            {
                time = 4.8;
            }
            else if (transport == "Train")
            {
                time = 7;
            }
            else if (transport == "Foot")
            {
                time = 85;
            }
            else if (transport == "Bus")
            {
                time = 6.5;
            }
        }
        else if (cityName == "Bansko")
        {
            if (transport == "Car")
            {
                time = 2.5;
            }
            else if (transport == "Train")
            {
                time = 4;
            }
            else if (transport == "Foot")
            {
                time = 43;
            }
            else if (transport == "Bus")
            {
                time = 3.2;
            }
        }
        if (laggage == "Backpack")
        {
            time *= 1.03;
        }
        else if (laggage == "Sack")
        {
            time *= 1.1;
        }
        else if (laggage == "None")
        {
            time *= 0.92;
        }


        if (hours >= time)
        {
            Console.WriteLine("{0:f1} Hours left until New Year's evening.", hours - time);
        }
        else
        {
            Console.WriteLine("Oh no, Stoyan is late. New year's evening started {0:f1} hours ago.", time - hours);
        }
    }
}