using System;
class Largest_Product_Of_Digits
{
    static void Main()
    {
        string input = Console.ReadLine();
        int Product = 0;
        int currentProduct = 1;

        for (int i = 0; i < input.Length - 5; i++)
        {
            for (int j = i; j < i + 6; j++)
            {
                currentProduct *= Convert.ToInt32(input[j] - 48);
            }
            if (currentProduct > Product)
            {
                Product = currentProduct;
            }
            currentProduct = 1;
        }
        Console.WriteLine(Product);
    }
}