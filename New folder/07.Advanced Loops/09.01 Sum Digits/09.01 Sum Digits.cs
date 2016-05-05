using System;
class Program
{
    static void Main()
    {
        int sum = 0;
        int n = int.Parse(Console.ReadLine());

        while (n > 0)
        {
            sum = sum + n % 10;
            n = n / 10;
        }
        Console.WriteLine(sum);
    }
}