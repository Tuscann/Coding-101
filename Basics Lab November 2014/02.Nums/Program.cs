using System;

class Program
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var m = int.Parse(Console.ReadLine());
        int c = 0;

        //Console.WriteLine("{0:f3}", n * n);

        //if (n % 2 == 0)
        //{
        for (int i = n; i <= m; i += 2)
        {
            
            Console.WriteLine("{0:f3}", i*i);
            Console.WriteLine("{0:f3}", Math.Sqrt(i));
            //n = n + 1;
            //m = m+1;

        }
        //}
        //if (n % 2 != 1)
        //{
        //    for (int i = n; i < m; i += 2)
        //    {
        //        Console.WriteLine("{0:f3}", Math.Sqrt(i));

        //    }
        //}


        //for (int i = n; i < m; i++)
        //{
        //    Console.WriteLine(i);

        //}
        //Console.WriteLine("{0:f3}", m * m);
        ////Console.WriteLine("{0:f3}",);

    }
}

