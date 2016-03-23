using System;
class Program
{
    static void Main()
    {

        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("{0}{1}{0}", new string('.', n), new string('#', n));
        //Console.WriteLine("{0}###{0}###{0}", new string('.', n - 2));
        for (int i = 1; i <= n / 2; i++)
        {
            int edgespace = n - 2 * i;
            int middleSpace = n - 2;
            int sideSpace = (3 * n - 2 * edgespace - middleSpace - 6) / 2;
            Console.WriteLine("{0}##{1}#{2}#{1}##{0}",
                new string('.', edgespace), new string('.', sideSpace)
                , new string('.', middleSpace));
        }
        for (int i = n / 2; i > 0; i--)
        {
            int edgespace = n - 2 * i;
            int middleSpace = n - 2;
            int sideSpace = (3 * n - (2 * edgespace) - middleSpace - 6) / 2;
            Console.WriteLine("{0}##{1}#{2}#{1}##{0}",
                new string('.', edgespace), new string('.', sideSpace)
                , new string('.', middleSpace));
        }
        Console.WriteLine("{0}{1}{0}", new string('.', n), new string('#', n));
    }
}

