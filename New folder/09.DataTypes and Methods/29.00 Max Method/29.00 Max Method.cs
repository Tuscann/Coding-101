using System;
class Program
{
    static void Main()
    {
        int max = int.MinValue;

        for (int i = 0; i < 3; i++)
        {
            int n = int.Parse(Console.ReadLine());
            if (n > max)
            {
                max = n;
            }
        }
        Console.WriteLine("{0}", max);
    }
}