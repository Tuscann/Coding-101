using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int sumFirst = 0; int sumSecond = 0;

        for (int i = 0; i < n; i++)
        {
            int k = int.Parse(Console.ReadLine());

            sumFirst += k;
        }
        for (int r = 0; r < n; r++)
        {
            int k = int.Parse(Console.ReadLine());

            sumSecond += k;
        }

        if (sumFirst == sumSecond)
        {
            Console.WriteLine("Yes, sum = {0}", sumFirst);
        }
        else
        {
            Console.WriteLine("No, diff = {0}", Math.Abs(sumFirst - sumSecond));
        }

    }
}

