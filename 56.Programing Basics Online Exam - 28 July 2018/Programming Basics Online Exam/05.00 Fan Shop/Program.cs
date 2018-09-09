using System;

internal class Program
{
    public static void Main()
    {
        int budjet = int.Parse(Console.ReadLine());
        int predmeti = int.Parse(Console.ReadLine());

        int sum = 0;

        for (int i = 0; i < predmeti; i++)
        {
            string az = Console.ReadLine();

            if (az.Equals("hoodie"))
            {
                sum += 30;
            }
            else if (az.Equals("keychain"))
            {
                sum += 4;
            }
            else if (az.Equals("T-shirt"))
            {
                sum += 20;
            }
            else if (az.Equals("flag"))
            {
                sum += 15;
            }
            else if (az.Equals("sticker"))
            {
                sum += 1;
            }
        }

        if (budjet >= sum)
        {
            Console.WriteLine("You bought {0} items and left with {1} lv.", predmeti, budjet - sum);
        }
        else
        {
            Console.WriteLine("Not enough money, you need {0} more lv.", sum - budjet);
        }
    }
}