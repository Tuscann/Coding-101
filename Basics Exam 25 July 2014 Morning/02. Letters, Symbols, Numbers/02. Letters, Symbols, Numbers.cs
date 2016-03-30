using System;
using System.Text.RegularExpressions;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        long lettersSum = 0;
        long symbolsSum = 0;
        long numbersSum = 0;

        for (int i = 0; i < n; i++)
        {
            string inputLine = Console.ReadLine().ToUpper();   // Convert the input to upper-case

            inputLine = Regex.Replace(inputLine, "\\s+", "");

            for (int k = 0; k < inputLine.Length; k++)
            {
                char currentChar = inputLine[k];
                if (currentChar >= 'A' && currentChar <= 'Z')
                {
                    // Letters [a-zA-z]
                    lettersSum += (currentChar - 'A' + 1) * 10;
                }
                else if (currentChar >= '0' && currentChar <= '9')
                {
                    // Numbers [0-9]
                    numbersSum += (currentChar - '0') * 20;
                }
                else
                {
                    // Symbols
                    symbolsSum += 200;
                }
            }
        }
        Console.WriteLine("{0}\n{1}\n{2}",lettersSum,numbersSum,symbolsSum);
    }
}

