using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int row = 0; row <= n / 2 - 1; row++)
        {
            string dots = new string('.', row);
            string stars = new string('*', n - 2 - row * 2);
            string chashka = new string('\\', n / n);
            string chashka2 = new string('/', n / n);
            Console.WriteLine("{0}{2}{1}{3}{0}", dots, stars, chashka, chashka2);
        }
        int stem;
        if (n >= 12){stem = n / 2 - 2;}
        else{stem = n / 2 - 1;}

        for (int row = 1; row <= stem; row += 1)
        {
            string dots = new string('.', n / 2 + 1 / n - 1);
            string stars = new string('|', n / n);
            Console.WriteLine("{0}{1}{1}{0}", dots, stars);
        }
        for (int row = 1; row <= n / 2 - stem; row += 1)
        {
            string dots = new string('-', n);
            Console.WriteLine("{0}", dots);
        }
    }
}