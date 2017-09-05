using System;
class Program
{
    static void Main() // 100/100
    {
        int n = int.Parse(Console.ReadLine());

        int daljina = 5 * n;

        Console.WriteLine("{0}{1}{0}", new string('.', n), new string('*', daljina - 2 * n));
        int dots = n - 1;
        
        for (int i = 0; i < n - 1; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('.', dots), new string('.', daljina - 2 - 2 * dots));
            dots--;
        }
        Console.WriteLine("{0}", new string('*', daljina));
        
        dots = 1;
        for (int i = 2 * n; i > 0; i--)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('.', dots), new string('.', daljina - 2 - 2 * dots));
            dots++;
        }
        Console.WriteLine("{0}{1}{0}", new string('.', dots), new string('*', n - 2));
    }
}