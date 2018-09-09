using System;

internal class Program
{
    public static void Main()
    {
        int k = int.Parse(Console.ReadLine());
        int l = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());

        int counter = 0;

        for (int i = k; i <= 8; i++)
        {
            for (int j = 9; j >= l; j--)
            {
                for (int o = m; o <= 8; o++)
                {
                    for (int p = 9; p >= n; p--)
                    {
                        if (i % 2 == 0 && j % 2 != 0 && o % 2 == 0 && p % 2 != 0)
                        {
                            if (i * 10 + j == o * 10 + p)
                            {
                                Console.WriteLine("Cannot change the same player.");
                            }
                            else
                            {
                                Console.WriteLine("{0}{1} - {2}{3}", i, j, o, p);
                                counter++;
                            }

                            if (counter == 6)
                            {
                                Environment.Exit(0);
                            }
                        }
                    }
                }
            }
        }
    }
}