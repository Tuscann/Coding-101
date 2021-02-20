using System;

namespace _70.Programming_Basics_Exam___18_July_2020
{
    class Program
    {
        static void Main()
        {
            string nameCompany = Console.ReadLine();
            int countAdultPassengers = int.Parse(Console.ReadLine());
            int countChuildPassengers = int.Parse(Console.ReadLine());
            double priceTicketAdult = double.Parse(Console.ReadLine());
            double serviceFeeMoney = double.Parse(Console.ReadLine());

            double priceTicketChuild = priceTicketAdult * 0.3;

            double totalMoney = 0.2 * (countAdultPassengers * (priceTicketAdult + serviceFeeMoney) +
                                       countChuildPassengers * (priceTicketChuild + serviceFeeMoney));
            Console.WriteLine("The profit of your agency from {0} tickets is {1:0.00} lv.",nameCompany, totalMoney);
        }
    }
}