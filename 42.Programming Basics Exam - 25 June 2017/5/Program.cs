using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int height = (2 * n) + 1;
        int weight = (4 * n) + 1;

        Console.WriteLine("{0}", new string('#', weight));

        int before = 0;
        int after = (weight - 1 - 2) / 2;
        int space = 0;

        for (int i = 0; i < n / 2; i++)
        {
            Console.WriteLine(".{0}{1}{2} {2}{1}{0}.", new string('.', before), new string('#', after), new string(' ', space));
            before++;
            after -= 2;
            space++;
        }
        space--;
        Console.WriteLine(".{0}{1}{2}(@){2}{1}{0}.", new string('.', before), new string('#', after), new string(' ', space));
        space += 2;
        after -= 2;
        before++;

        if (n % 2 == 0)
        {
            for (int i = 0; i < (n / 2) - 1; i++)
            {
                Console.WriteLine(".{0}{1}{2} {2}{1}{0}.", new string('.', before), new string('#', after), new string(' ', space));
                before++;
                after -= 2;
                space++;
            }
        }
        else if (n % 2 == 1)
        {
            for (int i = 0; i <= (n / 2) - 1; i++)
            {
                Console.WriteLine(".{0}{1}{2} {2}{1}{0}.", new string('.', before), new string('#', after), new string(' ', space));
                before++;
                after -= 2;
                space++;
            }
        }
        int k = n + 1;
        after = n - 1;
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("{0}{1}#{1}{0}", new string('.', k), new string('#', after));
            after--;
            k++;
        }
    }
}