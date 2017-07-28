using System;
class Program
{
    static void Main()
    {
        int lilyAge = int.Parse(Console.ReadLine());
        double price = double.Parse(Console.ReadLine());
        int priceToy = int.Parse(Console.ReadLine());

        int moneyForBirthDay = 10;
        int total = 0;
        int counter = 0;
        int toy = 0;
        int pariBrat = lilyAge / 2;

        for (int i = 1; i <= lilyAge; i++)
        {
            if (i % 2 == 0)
            {
                moneyForBirthDay = i * 5;
                total = total + moneyForBirthDay;
            }
            else
            {
                counter++;
                toy = counter * priceToy;
            }
        }
        double totalSum = Math.Abs(total + toy - pariBrat);
        
        if (totalSum >= price)
        {
            Console.WriteLine("Yes! {0:F2}", totalSum);
        }
        else
        {
            Console.WriteLine("No! {0:F2}", totalSum);
        }
    }
}
