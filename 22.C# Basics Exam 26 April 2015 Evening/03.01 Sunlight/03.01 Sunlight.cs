using System;
public class Sunlight
{
    public static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        int width = size * 3;

        Console.WriteLine("{0}*{0}", new string('.', width / 2));

        int outerDots = 1;
        int innerDots = width / 2 - 2;

        for (int i = 0; i < size - 1; i++)
        {
            Console.WriteLine("{0}*{1}*{1}*{0}", new string('.', outerDots), new string('.', innerDots));

            outerDots++;
            innerDots--;
        }
        for (int i = 0; i < size / 2; i++)
        {
            Console.WriteLine("{0}{1}{0}", new string('.', size), new string('*', size));
        }
        Console.WriteLine(new string('*', width));

        for (int i = 0; i < size / 2; i++)
        {
            Console.WriteLine("{0}{1}{0}", new string('.', size), new string('*', size));
        }
        for (int i = 0; i < size - 1; i++)
        {
            outerDots--;
            innerDots++;

            Console.WriteLine("{0}*{1}*{1}*{0}", new string('.', outerDots), new string('.', innerDots));
        }
        Console.WriteLine("{0}*{0}", new string('.', width / 2));
    }
}