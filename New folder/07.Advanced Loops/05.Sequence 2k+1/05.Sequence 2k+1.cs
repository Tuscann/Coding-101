using System;
class Program
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        int num = 1;

        while (num<=n)
        {
            Console.WriteLine(num);
            num = num * 2 + 1;
        }
    }
}

