using System;
class Program
{
    static void Main() // 100/100
    {
        int n = int.Parse(Console.ReadLine());

        int first = n / 100;
        int secound = n / 10 % 10;
        int third = n % 10;

        for (int i = 1; i <= third; i++)
        {
            for (int j = 1; j <= secound; j++)
            {
                for (int k = 1; k <= first; k++)
                {
                    Console.WriteLine("{0} * {1} * {2} = {3};", i, j, k, i * j * k);
                }
            }
        }
    }
}