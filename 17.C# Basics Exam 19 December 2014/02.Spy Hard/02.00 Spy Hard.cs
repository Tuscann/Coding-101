using System;
using System.ComponentModel.Design;
using System.Linq;

class Program
{
    static void Main()
    {
        int numeralSystem = int.Parse(Console.ReadLine());
        string input = Console.ReadLine();

        int totalvalue = 0;
        string convertedValue = null;

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] >= 'A' && input[i] <= 'Z')
            {
                totalvalue += input[i ] - 64;
            }
            else if (input[i] >= 'a' && input[i] <= 'z')
            {
                totalvalue += input[i]-96;
            }
            else
            {
                totalvalue = totalvalue + input[i];
            }
        }
        do
        {
            convertedValue = (totalvalue % numeralSystem) + convertedValue;
            totalvalue /= numeralSystem;

        } while (totalvalue != 0);

        Console.WriteLine(numeralSystem.ToString() + input.Length + convertedValue);
        //convertedValue.ToCharArray().Reverse().ToList().ForEach(c => Console.Write(c));

    }
}

