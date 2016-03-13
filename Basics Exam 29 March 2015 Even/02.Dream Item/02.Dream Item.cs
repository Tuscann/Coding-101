using System;
using System.Linq;

class Program
{
    static void Main()
    {

        string[] input = Console.ReadLine().Split('\\');

        string month = input[0];
        var moneyPerHour = decimal.Parse(input[1]);
        int hourPerDay = int.Parse(input[2]);
        var priceOfItem = decimal.Parse(input[3]);
        int workingDays = 30 - 10;
        //Console.WriteLine(moounth);
        //Console.WriteLine(moneyPerHour);
        //Console.WriteLine(hourPerDay);
        //Console.WriteLine(priceOfItem);

        if (month == "Feb")
        {
            workingDays = 28 - 10;
        }
        else if (month == "Jan" || month == "March" || month == "May" || month == "July" || month == "Aug" || month == "Oct" || month == "Dec")
        {
            workingDays = 31 - 10;
        }
        decimal moneyForMounht = workingDays * moneyPerHour * hourPerDay;
        if (moneyForMounht >= 700) { moneyForMounht = 1.1m * moneyForMounht; }

        //Console.WriteLine(moneyForMounht);
        var restMoney = moneyForMounht - priceOfItem;
        //Console.WriteLine(restMoney);

        if (moneyForMounht < priceOfItem)
        {

            Console.WriteLine("Not enough money. {0:f2} leva needed.", priceOfItem - moneyForMounht);
        }
        else
        {
            Console.WriteLine("Money left = {0:f2} leva.",restMoney );
        }
    }
}

