using System;
using System.Linq;
using System.Text;

class WiggleWiggle
{
    static StringBuilder bits = new StringBuilder();

    static void Main()
    {
        long[] inputNumbers = Console.ReadLine().Split().Select(long.Parse).ToArray();

        for (int i = 0; i < inputNumbers.Length; i += 2)
        {
            char[] firstNumber = Convert.ToString(inputNumbers[i], 2).PadLeft(64, '0').ToCharArray();
            char[] secondNumber = Convert.ToString(inputNumbers[i + 1], 2).PadLeft(64, '0').ToCharArray();

            for (int j = firstNumber.Length - 1; j > 0; j -= 2)
            {
                char swap = new char();

                if (firstNumber[j] != secondNumber[j])
                {
                    swap = firstNumber[j];
                    firstNumber[j] = secondNumber[j];
                    secondNumber[j] = swap;
                }
            }
            long first = ConvertToDecimal(firstNumber);
            Console.WriteLine("{0} {1}", first, bits);
            bits.Clear();

            long second = ConvertToDecimal(secondNumber);
            Console.WriteLine("{0} {1}", second, bits);
            bits.Clear();
        }
    }

    static long ConvertToDecimal(char[] currentNumber)
    {
        for (int i = 0; i < currentNumber.Length; i++)
        {
            char currentBit = currentNumber[i];

            if (currentBit == '1')
            {
                bits.Append('0');
            }
            else
            {
                bits.Append('1');
            }
        }

        bits.Remove(0, 1);
        long number = Convert.ToInt64(bits.ToString(), 2);
        return number;
    }
}