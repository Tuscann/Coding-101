using System;

class Program
{
    static void Main()
    {

        var city = Console.ReadLine().ToLower();
        var quantity = double.Parse(Console.ReadLine());
        double commisction = 0;

        if (city != "sofia" && city != "varna" && city != "plovdiv" || quantity < 0)
        {
            Console.WriteLine("error");
        }
        else if ((city == "sofia") || (city == "varna") || (city == "plovdiv"))
        {
            if (city == "sofia")
            {
                if (quantity >= 0 && quantity <= 500) { commisction = 0.05; }
                else if (quantity >= 500 && quantity <= 1000) { commisction = 0.07; }
                else if (quantity >= 1000 && quantity <= 10000) { commisction = 0.08; }
                else { commisction = 0.12; }
            }
            else if (city == "varna")
            {
                if (quantity >= 0 && quantity <= 500) { commisction = 0.045; }
                else if (quantity >= 500 && quantity <= 1000) { commisction = 0.075; }
                else if (quantity >= 1000 && quantity <= 10000) { commisction = 0.1; }
                else { commisction = 0.13; }

            }
            else if (city == "plovdiv")
            {
                if (quantity >= 0 && quantity <= 500) { commisction = 0.055; }
                else if (quantity >= 500 && quantity <= 1000) { commisction = 0.08; }
                else if (quantity >= 1000 && quantity <= 10000) { commisction = 0.12; }
                else { commisction = 0.145; }

            }
            Console.WriteLine("{0:0.00}", quantity * commisction);
        }

    }

}

