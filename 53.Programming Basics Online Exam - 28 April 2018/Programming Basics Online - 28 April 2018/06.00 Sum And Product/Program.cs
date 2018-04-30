using System;
class Program
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        char b = char.Parse(Console.ReadLine());
        char c = char.Parse(Console.ReadLine());
        char d = char.Parse(Console.ReadLine());
        int e = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());

        int counter = 0;

        for (int j = a; j <= 99; j++)
        {
            for (char k = b; k <= 'Z'; k++)
            {
                for (char l = c; l <= 'z'; l++)
                {
                    for (char o = d; o <= 'Z'; o++)
                    {
                        for (int p = e; p >= 10; p--)
                        {
                            if (j % 10 == 2 && p % 10 == 5)
                            {
                                counter += 1;
                            }
                            if (counter == n)
                            {
                                Console.WriteLine($"{j}{k}{l}{o}{p}");
                                return;
                            }
                        }
                    }
                }
            }
        }
    }
}