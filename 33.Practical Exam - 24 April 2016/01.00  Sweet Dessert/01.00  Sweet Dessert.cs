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
        //Console.WriteLine(portion);
        //Console.WriteLine("{0}", portion * (2 * bananas));
        //Console.WriteLine("{0}", portion * (4 * eggs));
        //Console.WriteLine("{0}", portion * (decimal)0.2 * (decimal)berries);

        decimal total = portions * (2 * bananas) + (portions * (4 * eggs)) + (portions * ((decimal)0.2 * berries));
        
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