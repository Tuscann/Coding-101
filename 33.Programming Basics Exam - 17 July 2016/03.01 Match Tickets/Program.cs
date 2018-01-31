using System;
class Program
{
    static void Main() // 100/100
    {
        double inputBudget = double.Parse(Console.ReadLine());
        string inputCathegory = Console.ReadLine();
        double inputPeople = double.Parse(Console.ReadLine());

        double moneyTickets = 0.00;
        double moneyTransport = 0.00;
        double ticketsNumber = 0.00;
        double moneyLeftover = 0.00;

        if (inputPeople >= 1 && inputPeople <= 4)
        {
            moneyTickets = 0.25 * inputBudget;
            moneyTransport = 0.75 * inputBudget;
        }
        else if (inputPeople >= 5 && inputPeople <= 9)
        {
            moneyTickets = 0.40 * inputBudget;
            moneyTransport = 0.60 * inputBudget;
        }
        else if (inputPeople >= 10 && inputPeople <= 24)
        {
            moneyTickets = 0.50 * inputBudget;
            moneyTransport = 0.50 * inputBudget;
        }
        else if (inputPeople >= 25 && inputPeople <= 49)
        {
            moneyTickets = 0.6 * inputBudget;
            moneyTransport = 0.40 * inputBudget;

        }
        else if (inputPeople >= 50)
        {
            moneyTickets = 0.75 * inputBudget;
            moneyTransport = 0.25 * inputBudget;

        }
        else
        {
            Console.WriteLine("error with people");
        }
        switch (inputCathegory)
        {
            case "Normal":
                ticketsNumber = moneyTickets / 249.99;
                moneyLeftover = inputBudget - moneyTransport - inputPeople * 249.99;
                break;
            case "VIP":
                ticketsNumber = moneyTickets / 499.99;
                moneyLeftover = inputBudget - moneyTransport - inputPeople * 499.99;
                break;
            default:
                Console.WriteLine("error with cathegory");
                break;
        }
        if (ticketsNumber >= inputPeople)
        {
            Console.WriteLine("Yes! You have {0:f2} leva left.", moneyLeftover);
        }
        else if (ticketsNumber <= inputPeople)
        {
            Console.WriteLine("Not enough money! You need {0:f2} leva.", Math.Abs(moneyLeftover));
        }
        else
        {
            Console.WriteLine("error ticket calculation");
        }

    }
}