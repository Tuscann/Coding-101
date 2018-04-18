using System;
class MainClass
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("{0}^{0}", new string('_', n / 2 + 2));
        Console.WriteLine("{0}/|\\{0}", new string('_', n / 2 + 1));

        for (int i = 0; i < n / 2; i++)
        {
            Console.WriteLine("{0}/{1}|||{1}\\{0}", new string('_', n / 2 - i), new string('.', i));
        }
        Console.WriteLine("{0}/..|||..\\{0}", new string('_', (n - 4) / 2));
        Console.WriteLine("{0}/.|||.\\{0}", new string('_', (n - 2) / 2));

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("{0}_|||_{0}", new string('_', n / 2 ));
        }
        Console.WriteLine("{0}_~~~_{0}", new string('_', n / 2));
       
        for (int i = 0; i < n / 2; i++)
        {
            Console.WriteLine("{0}//{1}!{1}\\\\{0}", new string('_', n / 2 - i), new string('.', i));
        }
    }
}