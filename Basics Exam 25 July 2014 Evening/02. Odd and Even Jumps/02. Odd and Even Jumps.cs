using System;
class Program
{
    static void Main()
    {
        string input = Console.ReadLine().ToLower().Replace(" ", "");
        int oddJump = int.Parse(Console.ReadLine());
        int evenJump = int.Parse(Console.ReadLine());

        int oddCounter = 0;  int evenCounter = 0;
        ulong evenSum = 0;   ulong oddSum = 0;
       
        for (int i = 0; i < input.Length; i++)
        {
            if (i % 2 == 0)
            {
                oddCounter++;
                if (oddCounter % oddJump == 0)
                {
                    oddSum = oddSum * input[i];
                }
                else
                {
                    oddSum = oddSum + input[i];
                }
            }
            if (i % 2 != 0)
            {
               evenCounter++;
                if (evenCounter % evenJump == 0)
                {
                    evenSum *= input[i];
                }
                else
                {
                    evenSum += input[i];
                }
            }
            
        }
        Console.WriteLine("Odd: {0}", oddSum.ToString("X"));
        Console.WriteLine("Even: {0}",evenSum.ToString("X"));
    }
}

