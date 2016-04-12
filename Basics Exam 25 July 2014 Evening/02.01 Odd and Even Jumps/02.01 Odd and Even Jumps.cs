using System;
namespace _02.Odd_And_Even_Jumps
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine().ToLower();
            input = string.Join("", input.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries));
            int oddJump = int.Parse(Console.ReadLine());
            int evenJump = int.Parse(Console.ReadLine());
            string oddLetter = string.Empty;
            string evenLetter = string.Empty;

            long oddSum = 0;
            long evenSum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (i % 2 == 0)
                {

                    oddLetter += input[i];
                }
                else
                {
                    evenLetter += input[i];
                }
            }
            for (int i = 0; i < oddLetter.Length; i++)
            {
                if ((i + 1) % oddJump == 0 && i != 0)
                {
                    oddSum = oddLetter[i] * oddSum;
                }
                else
                {
                    oddSum += oddLetter[i];
                }

            }

            for (int i = 0; i < evenLetter.Length; i++)
            {
                if ((i + 1) % evenJump == 0)
                {
                    evenSum *= evenLetter[i];
                }
                else
                {
                    evenSum += evenLetter[i];
                }
            }
            Console.WriteLine("Odd: {0}", oddSum.ToString("X"));
            Console.WriteLine("Even: {0}", evenSum.ToString("X"));
        }
    }
}