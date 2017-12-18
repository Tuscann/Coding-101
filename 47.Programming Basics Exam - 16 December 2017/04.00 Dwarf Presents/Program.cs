using System;
class Program
{
    static void Main()  // 100/100
    {
        int countDworfs = int.Parse(Console.ReadLine());
        int money = int.Parse(Console.ReadLine());
        double sum = 0;

        for (int i = 0; i < countDworfs; i++)
        {
            string gift = Console.ReadLine();
            if (gift == "sand clock")
            {
                sum += 2.2;
            }
            else if (gift == "magnet")
            {
                sum += 1.5;
            }
            else if (gift == "cup")
            {
                sum += 5;
            }
            else if (gift == "t-shirt")
            {
                sum += 10;
            }
        }
        if (money >= sum)
        {
            Console.WriteLine("Santa Claus has {0:f2} more leva left!", money - sum);
        }
        else
        {
            Console.WriteLine("Santa Claus will need {0:f2} more leva.", sum - money);
        }
    }
}