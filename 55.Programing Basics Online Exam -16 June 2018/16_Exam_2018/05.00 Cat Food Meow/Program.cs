using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.Write("{0}|", new string('.', n - 1));
        for (int i = 0; i < n; i++)
        {
            Console.Write("\\/");
        }
        Console.WriteLine("|{0}", new string('.', n - 1));
        Console.WriteLine("{0}|{1}|{0}", new string('.', n - 1), new string('~', 2*n));
       
        for (int i = 0; i < n; i++)
        {
            Console.Write("{0}|{1}", new string('.', n - 1), new string(' ', i));
            for (int j = 0; j < n-i; j++)
            {
                Console.Write("{}");
            }
            Console.WriteLine("{1}|{0}", new string('.', n - 1), new string(' ', i));
        }
        
        Console.WriteLine("{0}|{1}MEOW{1}|{0}", new string('.', n - 1), new string(' ', n - 2));
        Console.WriteLine("{0}|{1}FOOD{1}|{0}", new string('.', n - 1), new string(' ', n - 2));
        
        for (int i = 1; i <= n; i++)
        {
            Console.Write("{0}|{1}", new string('.', n - 1), new string(' ', n-i));
            for (int j = 1; j <= i; j++)
            {
                Console.Write("{}");
            }
            Console.WriteLine("{1}|{0}", new string('.', n - 1), new string(' ', n-i));
        }
        Console.WriteLine("{0}|{1}|{0}", new string('.', n - 1), new string('~', 2 * n));

        Console.Write("{0}|", new string('.', n - 1));
        for (int i = 1; i <= n; i++)
        {
            Console.Write("\\/");
        }
        Console.WriteLine("|{0}", new string('.', n - 1));
    }
}