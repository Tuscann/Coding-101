using System;
class Program
{
    static void Main()
    {
        decimal money = decimal.Parse(Console.ReadLine());
        decimal rate = decimal.Parse(Console.ReadLine());
        decimal pizzaPrice = decimal.Parse(Console.ReadLine());
        decimal lasagnaPrice = decimal.Parse(Console.ReadLine());
        decimal sandwichPrice = decimal.Parse(Console.ReadLine());
        decimal pizzaQuantity = decimal.Parse(Console.ReadLine());
        decimal lasagnaQuantity = decimal.Parse(Console.ReadLine());
        decimal sandwichQuantity = decimal.Parse(Console.ReadLine());

        decimal spentForPizza = (pizzaPrice / rate) * pizzaQuantity;
        decimal spentForLasagna = (lasagnaPrice / rate) * lasagnaQuantity;
        decimal spentForSandwich = (sandwichPrice / rate) * sandwichQuantity;
        decimal x = spentForLasagna + spentForPizza + spentForSandwich;

        if (x <= money)
        {
            Console.WriteLine("Garfield is well fed, John is awesome. Money left: ${0:0.00}.", money - x);
        }
        else if (x > money)
        {
            Console.WriteLine("Garfield is hungry. John is a badass. Money needed: ${0:0.00}.", Math.Abs(money - x));
        }
    }
}