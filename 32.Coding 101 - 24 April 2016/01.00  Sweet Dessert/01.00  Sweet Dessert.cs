using System;
class Program
{
    static void Main()
    {
        decimal money = decimal.Parse(Console.ReadLine());
        decimal guests = decimal.Parse(Console.ReadLine());
        decimal bananas = decimal.Parse(Console.ReadLine());
        decimal eggs = decimal.Parse(Console.ReadLine());
        decimal berries = decimal.Parse(Console.ReadLine());

        decimal portions = (int)guests / 6;

        if (guests % 6 != 0)
        {
            portions++;
        }

        decimal total = portions * (2 * bananas + 4 * eggs + (decimal)0.2 * berries);
        
        //Output

        if (total <= money)
        {
            Console.WriteLine("Ivancho has enough money - it would cost {0:f2}lv.", total);
        }
        else
        {
            Console.WriteLine("Ivancho will have to withdraw money - he will need {0:f2}lv more.", total - money);
        }
    }
}