using System;
class Program
{
    static void Main() // 100/100
    {
        int n = int.Parse(Console.ReadLine());

        int chertichiki = 2;
        for (int i = 1; i <= n * 2; i++)
        {
            if (i == 1 || i == 3)
            {
                Console.Write('|');
                Console.Write(new string('-', n * 2));
                Console.WriteLine('|');
            }
            else if (i == 2)
            {
                Console.Write('|');
                Console.Write(new string('*', n * 2));
                Console.WriteLine('|');
            }
            else
            {
                Console.Write('|');
                Console.Write(new string('-', (n * 2 - chertichiki) / 2));
                Console.Write(new string('~', chertichiki));
                Console.Write(new string('-', (n * 2 - chertichiki) / 2));
                Console.WriteLine('|');
                if (i <= (n * 2 - 3) / 2 + 3)
                {
                    chertichiki += 2;
                }
                else
                {
                    chertichiki -= 2;
                }
            }
        }

        for (int i = 0; i < n + 3; i++)
        {
            if (i <= n + 1)
            {
                Console.Write(new string('-', i));
                Console.Write('\\');
                if (i == n / 2)
                {
                    Console.Write(new string('.', ((n * 2 + 1) - 5) / 2));
                    Console.Write("MERRY");
                    Console.Write(new string('.', ((n * 2 + 1) - 5) / 2));
                }
                else if (i == n / 2 + 2)
                {
                    Console.Write(new string('.', ((n * 2 + 1) - 5) / 2));
                    Console.Write("X-MAS");
                    Console.Write(new string('.', ((n * 2 + 1) - 5) / 2));
                }
                else
                {
                    Console.Write(new string('.', n * 2 + 1));
                }
                Console.WriteLine('\\');
            }
            else
            {
                Console.Write(new string('-', i));
                Console.Write('\\');
                Console.Write(new string('_', n * 2 + 1));
                Console.Write(')');
            }
        }
    }
}