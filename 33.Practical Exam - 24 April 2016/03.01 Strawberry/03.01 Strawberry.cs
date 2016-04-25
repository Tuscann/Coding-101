using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        //Part #1 
        Console.WriteLine("{0}{1}{2}{1}{3}", new string('\\', 1), new string('-', n), new string('|', 1), new string('/', 1));

        //Part #2
        int dashPre = 2;
        int dash = n - 2;
        int center = 1;
        int left = 1;
        int right = 1;
        int counter = 1;

        for (int row = 0; row < n / 2 - 1; row++)
        {
            Console.Write("{0}{1}{2}{3}{2}{4}{0}",
                new string('-', dashPre), //0 - 2
                new string('\\', left),   //1 - 1
                new string('-', dash),    //2 - 7
                new string('|', center),  //3 - 1
                new string('/', right));   //4 - 1
            dash -= 2;
            dashPre += 2;
            counter++;
            Console.WriteLine();
        }

        ////Part #3
        int diaz = 1;
        int dot = 1;
        dash = n;

        for (int row = 0; row < n - counter; row++)
        {
            Console.Write("{0}{1}{2}{1}{0}",
                new string('-', dash), //0 - 9
                new string('#', diaz), //1 - 1
                new string('.', dot));   //2 - 1
                
            dash -= 2;
            dot += 4;
            Console.WriteLine();
        }

        //Part #4
        Console.WriteLine("{0}{1}{0}", new string('#', 1), new string('.', 2 * n + 1), new string('#', 1));

        ////Part #5
        dash = 1;
        diaz = 1;
        dot = 2 * n - 1;
        for (int row = 0; row < n; row++)
        {
            Console.Write("{0}{1}{2}{1}{0}",
                new string('-', dash), //0 - 9
                new string('#', diaz), //1 - 1
                new string('.', dot)); //2 - 1
               
            dash += 1;
            dot -= 2;
            Console.WriteLine();
        }
    }
}