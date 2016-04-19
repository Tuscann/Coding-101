using System;
public class FallenInLove
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        char symbol = '#';
        int leafSpace = 0;
        int insideSpace = 2 * n;
        int middleSpace = 0;

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("{0}{1}{0}{2}{0}{3}{0}{2}{0}{1}{0}", symbol, new string('~', leafSpace), new string('.', insideSpace), new string('.', middleSpace));

            leafSpace++;
            insideSpace -= 2;
            middleSpace += 2;
        }

        int outsideSpace = 1;

        for (int i = 0; i <= n; i++)
        {
            Console.WriteLine("{0}{1}{2}{1}{3}{1}{2}{1}{0}", new string('.', outsideSpace), symbol, new string('~', leafSpace), new string('.', middleSpace));

            middleSpace -= 2;
            leafSpace--;
            outsideSpace += 2;
        }

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("{0}{1}{1}{0}", new string('.', 2 * n + 2), symbol);
        }

    }
}