using System;
class Program
{
    static void Main()
    {
        double money = double.Parse(Console.ReadLine());
        int childrensCount = int.Parse(Console.ReadLine());
        double moneyPerChild = double.Parse(Console.ReadLine());
        double priceSkuter = double.Parse(Console.ReadLine())*1.05;

        double childrednsComing = Math.Ceiling(childrensCount * 0.85);
        double childrednsMoney = Math.Floor(childrednsComing * 0.8);

        double totalMoney = childrednsMoney * moneyPerChild + money - childrednsComing * 4.5;
        
        if (totalMoney >= priceSkuter)
        {
            Console.WriteLine("Asparuh will be driving a fast 49cc Scooter soon.");
            Console.WriteLine("Money left: {0:f2} BGN", totalMoney - priceSkuter);
        }
        else
        {
            Console.WriteLine("If only Asparuh had {0:f2} BGN more...", priceSkuter - totalMoney);
            Console.WriteLine("Guess he will be walking for now.");
        }
    }
}