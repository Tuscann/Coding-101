using System;
class MainClass
{
    public static void Main() // 100/100
    {
        double budget = double.Parse(Console.ReadLine());
        string typeOfTickets = Console.ReadLine().ToLower();
        double quantityOfPeople = double.Parse(Console.ReadLine());

        double vipBudget = quantityOfPeople * 499.99;
        double normalBudget = quantityOfPeople * 249.99;

        double transportBudged = 0.0;


        if (quantityOfPeople >= 1 && quantityOfPeople <= 4)
        {
            transportBudged = budget * 0.75;
            budget = budget - transportBudged;
            if (typeOfTickets == "vip")
            {

                if (budget > vipBudget)
                {
                    budget = budget - vipBudget;
                    Console.WriteLine("Yes! You have {0:0.00} leva left.", budget);

                }
                else if (budget < vipBudget)
                {
                    budget = budget - vipBudget;
                    budget = Math.Abs(budget);
                    Console.WriteLine("Not enough money! You need {0:0.00} leva.", budget);

                }
            }
            else if (typeOfTickets == "normal")
            {

                if (budget > normalBudget)
                {
                    budget = budget - normalBudget;
                    Console.WriteLine("Yes! You have {0:0.00} leva left.", budget);
                }
                else if (budget < normalBudget)
                {
                    budget = budget - normalBudget;
                    budget = Math.Abs(budget);
                    Console.WriteLine("Not enough money! You need {0:0.00} leva.", budget);
                }
            }
        }
        else if (quantityOfPeople >= 5 && quantityOfPeople <= 9)
        {
            transportBudged = budget * 0.60;
            budget = budget - transportBudged;
            if (typeOfTickets == "vip")
            {

                if (budget >= vipBudget)
                {
                    budget = budget - vipBudget;
                    Console.WriteLine("Yes! You have {0:0.00} leva left.", budget);

                }
                else if (budget < vipBudget)
                {
                    budget = budget - vipBudget;
                    budget = Math.Abs(budget);
                    Console.WriteLine("Not enough money! You need {0:0.00} leva.", budget);

                }
            }
            else if (typeOfTickets == "normal")
            {

                if (budget >= normalBudget)
                {
                    budget = budget - normalBudget;
                    Console.WriteLine("Yes! You have {0:0.00} leva left.", budget);
                }
                else if (budget < normalBudget)
                {
                    budget = budget - normalBudget;
                    budget = Math.Abs(budget);
                    Console.WriteLine("Not enough money! You need {0:0.00} leva.", budget);
                }
            }
        }
        else if (quantityOfPeople >= 10 && quantityOfPeople <= 24)
        {
            transportBudged = budget * 0.50;
            budget = budget - transportBudged;
            if (typeOfTickets == "vip")
            {

                if (budget >= vipBudget)
                {
                    budget = budget - vipBudget;
                    Console.WriteLine("Yes! You have {0:0.00} leva left.", budget);

                }
                else if (budget < vipBudget)
                {
                    budget = budget - vipBudget;
                    budget = Math.Abs(budget);
                    Console.WriteLine("Not enough money! You need {0:0.00} leva.", budget);

                }
            }
            else if (typeOfTickets == "normal")
            {

                if (budget >= normalBudget)
                {
                    budget = budget - normalBudget;
                    Console.WriteLine("Yes! You have {0:0.00} leva left.", budget);
                }
                else if (budget < normalBudget)
                {
                    budget = budget - normalBudget;
                    budget = Math.Abs(budget);
                    Console.WriteLine("Not enough money! You need {0:0.00} leva.", budget);
                }
            }
        }
        else if (quantityOfPeople >= 25 && quantityOfPeople <= 49)
        {
            transportBudged = budget * 0.40;
            budget = budget - transportBudged;
            if (typeOfTickets == "vip")
            {

                if (budget >= vipBudget)
                {
                    budget = budget - vipBudget;
                    Console.WriteLine("Yes! You have {0:0.00} leva left.", budget);

                }
                else if (budget < vipBudget)
                {
                    budget = budget - vipBudget;
                    budget = Math.Abs(budget);
                    Console.WriteLine("Not enough money! You need {0:0.00} leva.", budget);

                }
            }
            else if (typeOfTickets == "normal")
            {

                if (budget >= normalBudget)
                {
                    budget = budget - normalBudget;
                    Console.WriteLine("Yes! You have {0:0.00} leva left.", budget);
                }
                else if (budget < normalBudget)
                {
                    budget = budget - normalBudget;
                    budget = Math.Abs(budget);
                    Console.WriteLine("Not enough money! You need {0:0.00} leva.", budget);
                }
            }
        }
        else if (quantityOfPeople >= 50 && quantityOfPeople <= 200)
        {
            transportBudged = budget * 0.25;
            budget = budget - transportBudged;
            if (typeOfTickets == "vip")
            {

                if (budget >= vipBudget)
                {
                    budget = budget - vipBudget;
                    Console.WriteLine("Yes! You have {0:0.00} leva left.", budget);
                    return;
                }
                else if (budget < vipBudget)
                {
                    budget = budget - vipBudget;
                    budget = Math.Abs(budget);
                    Console.WriteLine("Not enough money! You need {0:0.00} leva.", budget);
                    return;
                }
            }
            else if (typeOfTickets == "normal")
            {

                if (budget >= normalBudget)
                {
                    budget = budget - normalBudget;
                    Console.WriteLine("Yes! You have {0:0.00} leva left.", budget);
                }
                else if (budget < normalBudget)
                {
                    budget = budget - normalBudget;
                    budget = Math.Abs(budget);
                    Console.WriteLine("Not enough money! You need {0:0.00} leva.", budget);
                }
            }
        }
    }
}