using System;
class Program
{
    static void Main() // 100/100
    {
        string dogovor = Console.ReadLine();
        string type = Console.ReadLine();
        string extraInternet = Console.ReadLine();
        int month = int.Parse(Console.ReadLine());

        double prize = 0.0;

        if (dogovor == "one")
        {
            if (type == "Small")
            {
                prize = 9.98;
            }
            else if (type == "Middle")
            {
                prize = 18.99;
            }
            else if (type == "Large")
            {
                prize = 25.98;
            }
            else if (type == "ExtraLarge")
            {
                prize = 35.99;
            }
            if (extraInternet == "yes")
            {
                if (prize <= 10.00)
                {
                    prize += 5.50;
                }
                else if (prize > 10.00 && prize <= 30.00)
                {
                    prize += 4.35;
                }
                else if (prize > 30.00)
                {
                    prize += 3.85;
                }
            }
        }
        else if (dogovor == "two")
        {
            if (type == "Small")
            {
                prize = 8.58;
            }
            else if (type == "Middle")
            {
                prize = 17.09;
            }
            else if (type == "Large")
            {
                prize = 23.59;
            }
            else if (type == "ExtraLarge")
            {
                prize = 31.79;
            }
            if (extraInternet == "yes")
            {
                if (prize <= 10.00)
                {
                    prize += 5.50;
                }
                else if (prize > 10.00 && prize <= 30.00)
                {
                    prize += 4.35;
                }
                else if (prize > 30.00)
                {
                    prize += 3.85;
                }
            }
            prize *= 1 - 0.0375;
        }
        Console.WriteLine("{0:f2} lv.", prize * month);
    }
}