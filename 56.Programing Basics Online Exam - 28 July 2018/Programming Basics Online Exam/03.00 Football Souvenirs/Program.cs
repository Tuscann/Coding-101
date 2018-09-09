using System;

internal class Program
{
    public static void Main()
    {
        string team = Console.ReadLine();
        string souvenir = Console.ReadLine();
        int count = int.Parse(Console.ReadLine());

        bool isfalse1 = false;
        bool isfalse2 = false;

        if (souvenir.Equals("flags") || souvenir.Equals("caps") || souvenir.Equals("posters") ||
            souvenir.Equals("stickers"))
        {
        }
        else
        {
            isfalse1 = true;
            Console.WriteLine("Invalid stock!");
        }

        double price = 0.0;

        if (team.Equals("Argentina"))
        {
            if (souvenir.Equals("flags"))
            {
                price = 3.25;
            }
            else if (souvenir.Equals("caps"))
            {
                price = 7.20;
            }
            else if (souvenir.Equals("posters"))
            {
                price = 5.10;
            }
            else if (souvenir.Equals("stickers"))
            {
                price = 1.25;
            }
        }
        else if (team.Equals("Brazil"))
        {
            if (souvenir.Equals("flags"))
            {
                price = 4.2;
            }
            else if (souvenir.Equals("caps"))
            {
                price = 8.5;
            }
            else if (souvenir.Equals("posters"))
            {
                price = 5.35;
            }
            else if (souvenir.Equals("stickers"))
            {
                price = 1.20;
            }
        }
        else if (team.Equals("Croatia"))
        {
            if (souvenir.Equals("flags"))
            {
                price = 2.75;
            }
            else if (souvenir.Equals("caps"))
            {
                price = 6.9;
            }
            else if (souvenir.Equals("posters"))
            {
                price = 4.95;
            }
            else if (souvenir.Equals("stickers"))
            {
                price = 1.1;
            }
        }
        else if (team.Equals("Denmark"))
        {
            if (souvenir.Equals("flags"))
            {
                price = 3.1;
            }
            else if (souvenir.Equals("caps"))
            {
                price = 6.50;
            }
            else if (souvenir.Equals("posters"))
            {
                price = 4.8;
            }
            else if (souvenir.Equals("stickers"))
            {
                price = 0.9;
            }
        }
        else
        {
            if (isfalse1 == false)
            {
                isfalse2 = true;
                Console.WriteLine("Invalid country!");
            }
        }

        if (isfalse1 == false && isfalse2 == false)
        {
            Console.WriteLine("Pepi bought {0} {1} of {2} for {3:f2} lv.", count, souvenir, team, count * price);
        }
    }
}