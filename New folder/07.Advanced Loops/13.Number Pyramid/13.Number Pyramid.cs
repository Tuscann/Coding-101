using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        var num = 1;

        for (int row = 1; row <= n; row++)
        {
            for (int col = 1; col <= row; col++)
            {
                if (col > 1) Console.Write(" ");
                Console.Write(num);
                num++;
                if (num > n)
                { break; }
            }
            Console.WriteLine();
            if (num > n) { break; }
        }
    }
}