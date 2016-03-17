using System;
class Program
{
    static void Main()
    {
        string[] firstClass = Console.ReadLine().Split();
        int firstClassPassengers = int.Parse(firstClass[0]);
        int firstClassFrequent = int.Parse(firstClass[1]);
        int firstClassMeals = int.Parse(firstClass[2]);

        string[] businessClass = Console.ReadLine().Split();
        int businessClassPassengers = int.Parse(businessClass[0]);
        int businessClassFrequent = int.Parse(businessClass[1]);
        int businessClassMeals = int.Parse(businessClass[2]);

        string[] thirdClass = Console.ReadLine().Split();
        decimal thirdtClassPassengers = int.Parse(thirdClass[0]);
        decimal thirdtClassFrequent = int.Parse(thirdClass[1]);
        decimal thirdtClassMeals = int.Parse(thirdClass[2]);

        decimal priceFirst = 7000m;
        decimal priceBusiness = 3500m;
        decimal priceEconomy = 1000m;
        decimal discount = 0.3m;
        decimal meal = 0.005m;

        decimal income = 0m;
        income = income + (firstClassPassengers - firstClassFrequent) * priceFirst;
        income = income + firstClassFrequent * priceFirst * discount;
        income = income + firstClassMeals * priceFirst * meal;

        income = income + (businessClassPassengers - businessClassFrequent) * priceBusiness;
        income = income + businessClassFrequent * priceBusiness * discount;
        income = income + businessClassMeals * priceBusiness * meal;

        income = income + (thirdtClassPassengers - thirdtClassFrequent) * priceEconomy;
        income = income + thirdtClassFrequent * priceEconomy * discount;
        income = income + thirdtClassMeals * priceEconomy * meal;

        int result = (int)income;

        decimal MaxIncome = (12 * priceFirst + 12 * (meal * priceFirst)) + (28 * priceBusiness + 28 * (meal * priceBusiness)) + (50 * priceEconomy + 50 * (meal * priceEconomy));
        //233160

        Console.WriteLine(result);
        Console.WriteLine((int)MaxIncome - result);
    }
}

