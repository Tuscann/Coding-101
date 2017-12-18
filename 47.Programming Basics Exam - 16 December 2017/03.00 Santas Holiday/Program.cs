using System;

class Program
{
    static void Main()   // 100/100
    {
        int restDays = int.Parse(Console.ReadLine());
        string typeOfRoom = Console.ReadLine();
        string positiveOrnegative = Console.ReadLine();

        double priceForRoom = 0;
        double sum = 0;

        if (typeOfRoom == "room for one person")
        {
            priceForRoom = 18.00;
            sum = (restDays - 1) * priceForRoom;
        }
        else if (typeOfRoom == "apartment")
        {
            priceForRoom = 25.00;
            sum = (restDays - 1) * priceForRoom;
            if (restDays < 10)
            {
                sum *= 0.7;
            }
            else if (restDays >= 10 && restDays <= 15)
            {
                sum *= 0.65;
            }
            else if (restDays > 15)
            {
                sum *= 0.5;
            }
        }
        else if (typeOfRoom == "president apartment")
        {
            priceForRoom = 35.00;
            sum = (restDays - 1) * priceForRoom;

            if (restDays < 10)
            {
                sum *= 0.9;
            }
            else if (restDays >= 10 && restDays <= 15)
            {
                sum *= 0.85;
            }
            else if (restDays > 15)
            {
                sum *= 0.8;
            }
        }
        if (positiveOrnegative == "positive")
        {
            sum *= 1.25;
        }
        else if (positiveOrnegative == "negative")
        {
            sum *= 0.9;
        }
        Console.WriteLine("{0:f2}", sum);
    }
}