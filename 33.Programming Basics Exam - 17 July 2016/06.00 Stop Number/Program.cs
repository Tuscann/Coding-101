using System;
class Program
{
    static void Main() // 100/100
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        int s = int.Parse(Console.ReadLine());

        for (int i = m; i >= n; i--)
        {
            if (i % 6 == 0)
            {
                if (s % 6 == 0 && i == s)
                {
                    break;
                }
                Console.Write("{0} ", i);
            }
        }
    }
}