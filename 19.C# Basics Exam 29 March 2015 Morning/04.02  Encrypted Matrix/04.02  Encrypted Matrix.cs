using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        string marker = Console.ReadLine();
        List<int> numbers = new List<int>();
        List<int> convertedNumbers = new List<int>();
        List<int> finalNumbers = new List<int>();
        int counter = 0;
        foreach (var letter in input)
        {
            int number = (int)letter;
            int lastNumber = number % 10;
            numbers.Add(lastNumber);
            counter++;
        }
        //foreach (var item in numbers)
        //{
        //    Console.Write(item + " ");
        //}
        if (counter <= 1)
        {
            Console.WriteLine(numbers[0]);
        }
        else
        {
            for (int i = 0; i < counter; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    int convertedDigit = numbers[i] * numbers[i];
                    convertedNumbers.Add(convertedDigit);
                }
                if (numbers[i] % 2 == 1 && i != 0 && i != counter - 1)
                {
                    int convertedDigit = numbers[i - 1] + numbers[i] + numbers[i + 1];
                    convertedNumbers.Add(convertedDigit);
                }
                if (numbers[i] % 2 == 1 && i == counter - 1)
                {
                    int convertedDigit = numbers[i - 1] + numbers[i];
                    convertedNumbers.Add(convertedDigit);
                }
                if (numbers[i] % 2 == 1 && i == 0)
                {
                    int convertedDigit = numbers[i + 1] + numbers[i];
                    convertedNumbers.Add(convertedDigit);
                }
            }
            foreach (var item in convertedNumbers)
            {
                if (item / 10 == 0)
                {
                    finalNumbers.Add(item);
                }
                if (item / 10 > 0)
                {
                    int helpAdd = item / 10;
                    int help = item % 10;
                    finalNumbers.Add(helpAdd);
                    finalNumbers.Add(help);
                    counter++;
                }
            }
            if (marker == "\\")
            {
                int[,] matrix = new int[counter, counter];

                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        if (j == i)
                        {
                            matrix[i, j] = finalNumbers[i];
                            Console.Write(matrix[i, j] + " ");
                        }
                        else
                        {
                            matrix[i, j] = 0;
                            Console.Write(matrix[i, j] + " ");
                        }

                    }
                    Console.WriteLine();
                }
            }
            int lastElement = counter - 1;
            int element = 0;
            if (marker == "/")
            {
                int[,] matrix = new int[counter, counter];
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        if (j == lastElement)
                        {
                            matrix[i, j] = finalNumbers[lastElement];
                            Console.Write(matrix[i, j] + " ");
                        }
                        else
                        {
                            matrix[i, j] = 0;
                            Console.Write(matrix[i, j] + " ");
                        }
                    }
                    Console.WriteLine();
                    lastElement--;
                }
            }
        }
    }
}