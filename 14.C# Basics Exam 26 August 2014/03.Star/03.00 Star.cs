using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.Write(new string('.', n));
        Console.Write("*");
        Console.WriteLine(new string('.', n));

        int dotsBefore = n;
        int middleDots = 1;
        int partsHeight = n/2 - 1;

        for (int i = 0; i < partsHeight; i++)
        {
            dotsBefore--;
            Console.WriteLine("{0}*{1}*{0}", new string('.', dotsBefore), new string('.', middleDots));
            middleDots = middleDots + 2;
        }
        Console.WriteLine("{0}{1}{0}",new string('*', dotsBefore),new string('.', middleDots));
        dotsBefore = 1;
        middleDots = 2 * n - 3;
        for (int i = 0; i < partsHeight; i++)
        {
            Console.WriteLine("{0}*{1}*{0}",new string('.', dotsBefore),new string('.', middleDots));
            dotsBefore++;
            middleDots -= 2;
        }
        middleDots = n / 2 - 1;
        Console.WriteLine("{0}*{1}*{1}*{0}",new string('.', dotsBefore),new string('.', middleDots));

        int betweeDots = 1;

        for (int i = 0; i < partsHeight; i++)
        {
            dotsBefore--;
            Console.WriteLine("{0}*{1}*{2}*{1}*{0}",new string('.', dotsBefore),new string('.', middleDots),new string('.', betweeDots));
            betweeDots += 2;
        }
        Console.WriteLine("{0}{1}{0}", new string('*', middleDots + 2), new string('.', betweeDots));
    }
}



