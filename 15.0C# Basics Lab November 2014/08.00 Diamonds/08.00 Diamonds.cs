using System;
public class ConsoleGraphics
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int lineBefore = n / 2 - 1, lineInside = 1;

        Console.WriteLine("{0}*{0}", new String('-', n / 2));
        for (int i = 0; i < n / 2; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new String('-', lineBefore), new String('-', lineInside));
            lineBefore--;
            lineInside += 2;
        }
        lineBefore = 1;
        lineInside = n - 4;

        for (int i = n / 2 - 1; i > 0; i--)
        {
            Console.WriteLine("{0}*{1}*{0}", new String('-', lineBefore), new String('-', lineInside));
            lineBefore++;
            lineInside -= 2;
        }
        Console.WriteLine("{0}*{0}", new String('-', n / 2));
    }
}