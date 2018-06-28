using System;
class Program
{
    static void Main()
    {
        double money = double.Parse(Console.ReadLine());
        char gender = char.Parse(Console.ReadLine());
        int age = int.Parse(Console.ReadLine());
        string sport = Console.ReadLine();

        double price = 0;

        if (gender == 'm' && sport == "Gym")
        {
            price = 42;
        }
        else if (gender == 'f' && sport == "Gym")
        {
            price = 35;
        }
        else if (gender == 'm' && sport == "Boxing")
        {
            price = 41;
        }
        else if (gender == 'f' && sport == "Boxing")
        {
            price = 37;
        }
        else if (gender == 'm' && sport == "Yoga")
        {
            price = 45;
        }
        else if (gender == 'f' && sport == "Yoga")
        {
            price = 42;
        }
        else if (gender == 'm' && sport == "Zumba")
        {
            price = 34;
        }
        else if (gender == 'f' && sport == "Zumba")
        {
            price = 31;
        }
        else if (gender == 'm' && sport == "Dances")
        {
            price = 51;
        }
        else if (gender == 'f' && sport == "Dances")
        {
            price = 53;
        }
        else if (gender == 'm' && sport == "Pilates")
        {
            price = 39;
        }
        else if (gender == 'f' && sport == "Pilates")
        {
            price = 37;
        }

        if (age <= 19)
        {
            price *= 0.8;
        }

        if (money >= price)
        {
            Console.WriteLine("You purchased a 1 month pass for {0}.", sport);
        }
        else
        {
            Console.WriteLine("You don't have enough money! You need ${0:f2} more.", price - money);
        }
    }
}