using System;
using System.Collections.Generic;
using System.Linq;
class SumOfElements
{
    static void Main()
    {
        string sequence = Console.ReadLine();
        List<string> input = sequence.Split(' ').ToList();
        List<long> numbers = new List<long>();
        long currentNum = 0;

        for (int i = 0; i < input.Count; i++)
        {
            numbers.Add(long.Parse(input[i]));
        }
        for (int i = 0; i < numbers.Count; i++)
        {
            if (currentNum < numbers[i])
            {
                currentNum = numbers[i];
            }
        }
        numbers.Remove(currentNum);
        if (numbers.Sum() == currentNum)
        {
            Console.WriteLine("Yes, sum={0}", Math.Abs(currentNum));
        }
        else
        {
            Console.WriteLine("No, diff={0}", Math.Abs(numbers.Sum() - currentNum));
        }
    }
}
