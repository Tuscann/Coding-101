using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("##{0}##{0}##", new string('.', 2 * n));

        int a = 1;
        int b = ((2 * (2 * n + 2)) + 2 - 10)/2;
        int c = 2;

        for (int i = 0; i < n - 1; i++)
        {
            Console.WriteLine("#{0}#{1}#{2}#{1}#{0}#",
                new string('~', a), new string('.', b), new string('.', c));
            a++;
            b -= 2;
            c += 2;
        }

        int aa = n;
        int bb = 2*n;
        int cc = 0;

        for (int i = 0; i <n; i++)
        {
            Console.WriteLine(".{0}#{1}#{2}#{1}#{0}.",
                new string('.',cc),new string('~',aa),new string('.',bb));
            aa--;
            bb -= 2;
            cc += 2;
        }
        Console.WriteLine("{0}####{0}", new string('.', 2 * n + 1));
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("{0}##{0}", new string('.', 2 * n + 2));
        }
    }
}

