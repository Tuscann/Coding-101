using System;
public class LargestProductofDigits
{
    public static void Main()
    {
        string input = Console.ReadLine();
        int bestProduct = 0;
        int currentProduct = 1;

        for (int currentNum = 0; currentNum < input.Length - 5; currentNum++)
        {
            for (int index = currentNum; index < currentNum + 6; index++)
            {
                currentProduct *= input[index] - '0';
            }
            if (currentProduct > bestProduct)
            {
                bestProduct = currentProduct;
            }
            currentProduct = 1;
        }
        Console.WriteLine(bestProduct);
    }
}