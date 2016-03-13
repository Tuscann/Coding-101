using System;

class DreamItem
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split('\\');
        string month = input[0];
        decimal moneyPerHour = decimal.Parse(input[1]);
        decimal hoursPerDay = decimal.Parse(input[2]);
        decimal itemPrice = decimal.Parse(input[3]);

        int days;
        switch (month)
        {
            case "Feb": days = 28; break;
            case "Apr":
            case "June":
            case "Sept":
            case "Nov": days = 30; break;
            default: days = 31; break;
        }
        //Holidays;
        days -= 10;
        //Total money;
        decimal totalMoney = days * moneyPerHour * hoursPerDay;
        //Bonus;
        if (totalMoney > 700)
        {
            totalMoney += totalMoney * 0.1M;
        }
        //Check if enough to buy the item;
        if (totalMoney - itemPrice >= 0)
        {
            Console.WriteLine("Money left = {0:F2} leva.", totalMoney - itemPrice);
        }
        else
        {
            Console.WriteLine("Not enough money. {0:F2} leva needed.", itemPrice - totalMoney);
        }
    }
}
