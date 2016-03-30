using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        var seq =new long[n];
        seq[0] = 1;
        
        for (int current = 1; current < n; current++)
        {
            var start = Math.Max(0, current - k);
            var end = current - 1;
            long sum =;


            Console.WriteLine(start);


            //Console.WriteLine(current);
        }

    }
}

