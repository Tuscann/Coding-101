using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int sum1 = 0;
        for (int i = 0; i < n; i++)
        {
            int a = int.Parse(Console.ReadLine());
            sum1 = sum1 + a;
        }
        int sum2 = 0;
        for (int i = n; i < 2 * n; i++)
        {
            int a = int.Parse(Console.ReadLine());
            sum2 = sum2 + a;
        }
        if (sum1 == sum2)
        {
            Console.WriteLine("Yes, sum={0}", sum1);
        }
        else if (sum1 > sum2)
        {
            Console.WriteLine("No, diff={0}", sum1 - sum2);
        }
        else
        {
            Console.WriteLine("No, diff={0}", sum2 - sum1);
        }
    }
}