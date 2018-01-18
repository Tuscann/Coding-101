using System;
class Program
{
    static void Main()  // 100/100
    {
        int n = int.Parse(Console.ReadLine());

        Console.Write(new string('-', n * 2));
        Console.Write(new string('*', n));
        Console.WriteLine(new string('-', n * 2));

        int terence = n * 2 - 2;
        int nqkviSiTam = n + 2;
        for (int i = 1; i <= n / 2; i++)
        {
            Console.Write(new string('-', terence));
            Console.Write(new string('*', ((5 * n) - (terence * 2) - nqkviSiTam) / 2));
            Console.Write(new string('&', nqkviSiTam));
            Console.Write(new string('*', ((5 * n) - (terence * 2) - nqkviSiTam) / 2));
            Console.WriteLine(new string('-', terence));
            terence -= 2;
            nqkviSiTam += 2;
        }

        int terenca2 = n - 1;
        int nqkviSiTam2 = n * 3 - 2;
        for (int i = 1; i <= n / 2; i++)
        {
            Console.Write(new string('-', terenca2));
            Console.Write(new string('*', (n * 5 - terenca2 * 2 - nqkviSiTam2) / 2));
            Console.Write(new string('~', nqkviSiTam2));
            Console.Write(new string('*', (n * 5 - terenca2 * 2 - nqkviSiTam2) / 2));
            Console.WriteLine(new string('-', terenca2));
            terenca2--;
            nqkviSiTam2 += 2;
        }

        int terence3 = n / 2;
        int nqkviSiTam3 = n * 4 - 2;
        Console.Write(new string('-', terence3));
        Console.Write(new string('*', (n * 5 - terence3 * 2 - nqkviSiTam3) / 2));
        Console.Write(new string('|', nqkviSiTam3));
        Console.Write(new string('*', (n * 5 - terence3 * 2 - nqkviSiTam3) / 2));
        Console.WriteLine(new string('-', terence3));

        for (int i = 1; i <= n / 2; i++)
        {
            nqkviSiTam3 -= 2;
            Console.Write(new string('-', terence3));
            Console.Write(new string('*', (n * 5 - terence3 * 2 - nqkviSiTam3) / 2));
            Console.Write(new string('~', nqkviSiTam3));
            Console.Write(new string('*', (n * 5 - terence3 * 2 - nqkviSiTam3) / 2));
            Console.WriteLine(new string('-', terence3));
            terence3++;
        }

        int nqkviSiTam4 = n * 2;

        for (int i = 1; i <= n / 2; i++)
        {
            Console.Write(new string('-', terence3));
            Console.Write(new string('*', (n * 5 - terence3 * 2 - nqkviSiTam4) / 2));
            Console.Write(new string('&', nqkviSiTam4));
            Console.Write(new string('*', (n * 5 - terence3 * 2 - nqkviSiTam4) / 2));
            Console.WriteLine(new string('-', terence3));
            terence3 += 2;
            nqkviSiTam4 -= 2;
        }
        Console.Write(new string('-', n * 2));
        Console.Write(new string('*', n));
        Console.WriteLine(new string('-', n * 2));
    }
}