using System;
class WeirdCombinations
{
    static void Main()
    {
        string sequence = Console.ReadLine();
        int num = int.Parse(Console.ReadLine());
        char[] digits = new char[5];
        for (int i = 0; i < 5; i++)
        {
            digits[i] = sequence[i];
        }
        int count = 0;
        for (int d1 = 0; d1 < 5; d1++)
        {
            for (int d2 = 0; d2 < 5; d2++)
            {
                for (int d3 = 0; d3 < 5; d3++)
                {
                    for (int d4 = 0; d4 < 5; d4++)
                    {
                        for (int d5 = 0; d5 < 5; d5++)
                        {
                            if (count == num)
                            {
                                Console.WriteLine("" +
                                    digits[d1] + digits[d2] +
                                    digits[d3] + digits[d4] +
                                    digits[d5]);
                                return;
                            }
                            count++;
                        }
                    }
                }
            }
        }
        Console.WriteLine("No");
    }
}