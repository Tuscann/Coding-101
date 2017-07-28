using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int a1 = n / 100;
        int a2 = (n / 10) % 10;
        int a3 = n % 10;

        int red = a1 + a2;
        int coloum = a1 + a3;

        for (int i = 0; i < red; i++)
        {
            for (int j = 0; j < coloum; j++)
            {
                if (n % 5 == 0)
                {
                    n = n - a1;
                }
                else if (n % 3 == 0)
                {
                    n = n - a2;
                }
                else
                {
                    n = n + a3;
                }
                Console.Write("{0} ", n);
            }
            Console.WriteLine();
        }
    }
}