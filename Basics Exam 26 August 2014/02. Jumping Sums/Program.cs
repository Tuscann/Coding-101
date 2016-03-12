using System;

class Program
{
    static void Main()
    {
        string[] numbersAsStrings = Console.ReadLine().Split();
        int jumps = int.Parse(Console.ReadLine());
        
        int[] numbers = new int[numbersAsStrings.Length];
        for (int i = 0; i < numbersAsStrings.Length; i++)
        {
            numbers[i] = int.Parse(numbersAsStrings[i]);
        }

        int maxSum = int.MinValue;
        for (int i = 0; i < numbers.Length; i++)
        {
            int curentSum = 0;
            int currentNumber = numbers[i];
            int nextNumberIndex = i;
            for (int j = 0; j < jumps; j++)
            {
               
                curentSum += currentNumber;
                
                currentNumber = numbers[nextNumberIndex];
                Console.WriteLine(nextNumberIndex);
            }
        }c







        Console.WriteLine(numbers);
    }
}

