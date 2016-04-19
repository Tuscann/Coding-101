using System;

class SumOfElements
{
    static void Main()
    {
        string inputLine = Console.ReadLine();
        string[] numbers = inputLine.Split(' ');

        int max = int.MinValue;
        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            int element = int.Parse(numbers[i]);
            sum = sum + element;
            if (element > max)
            {
                max = element;
            }
        }

        if (sum == 2 * max)
        {
            Console.WriteLine("Yes, sum=" + max);
        }
        else
        {
            int diff = Math.Abs(sum - 2 * max);
            Console.WriteLine("No, diff=" + diff);
        }
    }
}
