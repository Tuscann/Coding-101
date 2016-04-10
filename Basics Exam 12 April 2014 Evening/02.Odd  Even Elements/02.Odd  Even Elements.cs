using System;
internal class Program
{
    private static void Main()
    {
        string input = Console.ReadLine();
        string[] inputNumbers = input.Split(' ');

        if (input == "") { inputNumbers = new string[0]; } // Known issue: split on empty string returns 1 token ""

        decimal oddSum = 0;
        decimal oddMin = decimal.MaxValue;
        decimal oddMax = decimal.MinValue; /*нечетно*/
        decimal evenSum = 0;
        decimal evenMin = decimal.MaxValue;
        decimal evenMax = decimal.MinValue; /*четно*/

        bool odd = true;
        for (int i = 0; i < inputNumbers.Length; i++)
        {
            decimal element = decimal.Parse(inputNumbers[i]);

            if (odd) /*четно even*/
            {
                oddSum = oddSum + element;
                oddMax = Math.Max(oddMax, element);
                oddMin = Math.Min(oddMin, element);
            }
            else /*нечетно odd*/
            {
                evenSum += element;
                evenMin = Math.Min(evenMin, element);
                evenMax = Math.Max(evenMax, element);
            }
            odd = !odd;
        }

        if (inputNumbers.Length == 0)
        {
            Console.WriteLine("OddSum=No, OddMin=No, OddMax=No, EvenSum=No, EvenMin=No, EvenMax=No");
        }
        else if (inputNumbers.Length == 1)
        {
            Console.WriteLine("OddSum={0}, OddMin={1}, OddMax={2}, EvenSum=No, EvenMin=No, EvenMax=No",
                (double)oddSum, (double)oddMin, (double)oddMax);
        }
        else
        {
            Console.WriteLine("OddSum={0}, OddMin={1}, OddMax={2}, EvenSum={3}, EvenMin={4}, EvenMax={5}"
                , (double)oddSum, (double)oddMin, (double)oddMax, (double)evenSum, (double)evenMin,
                (double)evenMax);
        }
    }
}

