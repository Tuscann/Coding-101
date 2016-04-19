using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static void Main()
    {
        var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        var counterOfEachNumber = new int[numbers.Max() + 1];

        foreach (var number in numbers)
        {
            counterOfEachNumber[number]++;
        }
        for (int i = 0; i < counterOfEachNumber.Length; i++)
        {
            if (counterOfEachNumber[i] > 0)
            {
                Console.WriteLine("{0} -> {1}", i, counterOfEachNumber[i]);
            }
        }
    }
}

