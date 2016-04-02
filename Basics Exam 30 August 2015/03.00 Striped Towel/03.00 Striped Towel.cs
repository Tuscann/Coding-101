using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        if (n == 3)
        {
            Console.WriteLine("#..");
            Console.WriteLine("..#");
            Console.WriteLine(".#.");
            Console.WriteLine("#..");
        }


        for (int i = 0; i < n + n / 2; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("k");
            }
            Console.WriteLine();
        }



        //int x = 2;
        //int y = 1;


        //string dasd = "..#";
        //if (n == 5)
        //{
        //    Console.WriteLine("#{0}{1}",new string('.',x),new string('#',y));
        //}



    }
}

