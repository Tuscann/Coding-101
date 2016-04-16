using System;
class BiggestTriple
{
    static void Main()
    {
        string inputLine = Console.ReadLine();
        string[] numbers = inputLine.Split(' ');
        int index = 0;
        int maxSum = Int32.MinValue;
        int start = 0;
        while (index < numbers.Length)
        {
            int num1 = int.Parse(numbers[index]);
            int num2 = 0;
            if (index + 1 < numbers.Length)
            {
                num2 = int.Parse(numbers[index + 1]);
            }
            int num3 = 0;
            if (index + 2 < numbers.Length)
            {
                num3 = int.Parse(numbers[index + 2]);
            }
            int sum = num1 + num2 + num3;
            if (sum > maxSum)
            {
                maxSum = sum;
                start = index;
            }
            index = index + 3;
        }
        while (maxSum != 0)
        {
            Console.Write(numbers[start]);
            maxSum = maxSum - int.Parse(numbers[start]);
            start++;
            if (maxSum != 0)
            {
                Console.Write(" ");
            }
        }
    }
}
