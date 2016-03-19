using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("{0}",new string('*',n));
        for (int i = 0; i <= n / 2; i++)
        { Console.WriteLine("{0}{1}{0}", new string('.', n - 2*i),new string('*',i)); }

        Console.WriteLine("{0}*{0}",new string('.',n/2));

        //for (int i = 1; i < n / 2; i++)
        //{ Console.WriteLine(".{0}.", new string('*', n - 2)); }
        //Console.WriteLine("{0}", new string('*', n));


    }
}

