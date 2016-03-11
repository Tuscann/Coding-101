using System;

class Program
{
    static void Main()
    {
        int dayOfWeek = int.Parse(Console.ReadLine());
        double money = double.Parse(Console.ReadLine());
        double quantityAlchoholWant = double.Parse(Console.ReadLine());

        double alchoolPrize = 0;

        if (dayOfWeek == 0) { alchoolPrize = 25.0; }
        else if (dayOfWeek == 1) { alchoolPrize = 21.0; }
        else if (dayOfWeek == 2) { alchoolPrize = 14.0; }
        else if (dayOfWeek == 3) { alchoolPrize = 17.0; }
        else if (dayOfWeek == 4) { alchoolPrize = 45.0; }
        else if (dayOfWeek == 5) { alchoolPrize = 59.0; }
        else if (dayOfWeek == 6) { alchoolPrize = 42.0; }

        var boughtAlchol = money / alchoolPrize;
        if (boughtAlchol > quantityAlchoholWant)
        {
            string drink = "a";
            string m1 = "a";

            if (boughtAlchol < 1) { drink = "sober"; }
            else if (boughtAlchol >= 1 && boughtAlchol <= 1.5) { drink = "drunk"; }
            else if (boughtAlchol > 1.5) { drink = "very drunk"; }


            Console.WriteLine("Bai Ivan is {0} and very happy and he shared {1:f2} l. of alcohol with his friends", drink, boughtAlchol - quantityAlchoholWant);
        }
        else if (boughtAlchol == quantityAlchoholWant)
        {
            string drink = "a";
            string m1 = "a";

            if (boughtAlchol < 1) { drink = "sober"; }
            else if (boughtAlchol >= 1 && boughtAlchol <= 1.5) { drink = "drunk"; }
            else if (boughtAlchol > 1.5) { drink = "very drunk"; }

            Console.WriteLine("Bai Ivan is {0} and happy. He is as drunk as he wanted", drink, boughtAlchol - quantityAlchoholWant);
        }
        else
        {

            string drink = "a";
            string m1 = "a";

            if (boughtAlchol < 1) { drink = "sober"; }
            else if (boughtAlchol >= 1 && boughtAlchol <= 1.5) { drink = "drunk"; }
            else if (boughtAlchol > 1.5) { drink = "very drunk"; }


            Console.WriteLine("Bai Ivan is {0} and quite sad. He wanted to drink another {1:f2} l. of alcohol", drink, quantityAlchoholWant - boughtAlchol);
        }


    }
}

