using System;
class Program
{
    static void Main()  // 100/100
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        int n1 = n / 1000 % 10;
        int n2 = n / 100 % 10;
        int n3 = n / 10 % 10;
        int n4 = n % 10;

        int m1 = m / 1000 % 10;
        int m2 = m / 100 % 10;
        int m3 = m / 10 % 10;
        int m4 = m % 10;

        for (int j = n1; j <= m1; j++)
        {
            for (int k = n2; k <= m2; k++)
            {
                for (int l = n3; l <= m3; l++)
                {
                    for (int p = n4; p <= m4; p++)
                    {
                        if (j % 2 != 0 && k % 2 != 0 && l % 2 != 0 && p % 2 != 0)
                        {
                            int barcode = j * 1000 + k * 100 + l * 10 + p;

                            Console.Write("{0} ", barcode);
                        }
                    }
                }
            }
        }
    }
}