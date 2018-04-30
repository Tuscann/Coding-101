using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int a = 1; a <= 9; a++)
        {
            for (int b = 9; b >= a; b--)
            {
                for (int c = 0; c <= 9; c++)
                {
                    for (int d = 9; d >= c; d--)
                    {
                        if (a + b + c + d == a * b * c * d && n % 10 == 5)
                        {
                            Console.WriteLine($"{a}{b}{c}{d}");
                            return;
                        }
                        if (a * b * c * d / (a + b + c + d) == 3 && n % 3 == 0)
                        {
                            Console.WriteLine($"{d}{c}{b}{a}");
                            return;
                        }
                    }
                }
            }
        }
        Console.WriteLine("Nothing found");
    }
}
