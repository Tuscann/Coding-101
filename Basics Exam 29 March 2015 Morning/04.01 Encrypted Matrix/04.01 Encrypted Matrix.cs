using System;
using System.Collections.Generic;
using System.Text;
class EM
{
    public static void Main()
    {
        string input = Console.ReadLine();
        byte[] array = Encoding.ASCII.GetBytes(input);

        List<int> numbers = new List<int>();
        foreach (char ch in array)
        {
            numbers.Add(ch % 10);

        }

        List<int> cryptedNumbers = new List<int>();
        for (int i = 0; i < numbers.Count; i++)
        {
            int currentDigit = numbers[i];
            int result;

            if (currentDigit % 2 == 0)
            {
                result = currentDigit * currentDigit;

                if (result >= 10)
                {
                    cryptedNumbers.Add(result / 10);
                    cryptedNumbers.Add(result % 10);
                }
                else
                {
                    cryptedNumbers.Add(result);
                }
            }
            else
            {
                int previousDigit = i == 0 ? 0 : numbers[i - 1];
                int nextDigit = i == numbers.Count - 1 ? 0 : numbers[i + 1];
                result = currentDigit + previousDigit + nextDigit;
                if (result >= 10)
                {
                    cryptedNumbers.Add(result / 10);
                    cryptedNumbers.Add(result % 10);
                }
                else
                {
                    cryptedNumbers.Add(result);
                }
            }
        }
        string diagonal = Console.ReadLine();
        int position;
        int update;

        if (diagonal == "\\")
        {
            position = 0;
            update = 1;
        }
        else
        {
            position = cryptedNumbers.Count - 1;
            update = -1;
        }

        for (int i = 0; i < cryptedNumbers.Count; i++)
        {
            for (int j = 0; j < cryptedNumbers.Count; j++)
            {
                if (j == position)
                {
                    Console.Write(cryptedNumbers[position] + " ");
                }
                else
                {
                    Console.Write("0 ");
                }
            }

            Console.WriteLine();

            position += update;
        }
    }
}