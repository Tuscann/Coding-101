using System;
class CupJava
{
    static void Main()  // 100/100
    {
        int n = int.Parse(Console.ReadLine());
        int width = 3 * n + 6;

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(new string(' ', n) + "~" + " " + "~" + " " + "~");
        }
        Console.WriteLine(new string('=', width - 1));

        if (n <= 3)
        {
            Console.WriteLine("|" + new string('~', n) + "JAVA" + new string('~', n) + "|" + new string(' ', n - 1) + "|");
        }
        else
        {
            for (int i = 0; i < n - 2; i++) // ~~~~~~~~~~
            {
                if (i == (n - 2) / 2)
                {
                    Console.WriteLine("|" + new string('~', n) + "JAVA" + new string('~', n) + "|" + new string(' ', n - 1) + "|");
                }
                else
                    Console.WriteLine("|" + new string('~', n * 2 + 4) + "|" + new string(' ', n - 1) + "|");
            }
        }
        Console.WriteLine(new string('=', width - 1)); //=========

        int spaces = 0;
        int kliomba = n * 2 + 4;
        for (int i = 0; i < n; i++) //down part \@@@@@/
        {
            Console.WriteLine(new string(' ', spaces) + "\\" + new string('@', kliomba) + "/");
            spaces++;
            kliomba -= 2;
        }
        Console.WriteLine(new string('=', n * 2 + 6));
    }
}