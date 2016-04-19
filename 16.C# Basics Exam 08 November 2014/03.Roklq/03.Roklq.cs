using System;
class Program
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());

        int outerDots = size;
        int innerDots = size - 2;
        Console.WriteLine("{0}*{1}*{0}", new string('.', outerDots), new string('*', innerDots));

        for (int i = 0; i < size / 2; i++)
        {
            outerDots -= 2;
            innerDots += 4;
            Console.WriteLine("{0}*{1}*{0}", new string('.', outerDots), new string('.', innerDots));

        }
        Console.WriteLine("*{0}*{1}*{0}*", new string('.', size - 2), new string('.', size));

        innerDots = 1;
        outerDots = size - 4;

        for (int i = 0; i < size / 2-1; i++)
        {
            Console.WriteLine("*{0}*{1}*{2}*{1}*{0}*",new string('.',outerDots),new string('.', innerDots),new string('.',size));

            innerDots += 2;
            outerDots -= 2;
        }
       outerDots = size - 1;
        innerDots = size;

        for (int i = 0; i < size - 1; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('.', outerDots), new string('.', innerDots));
            outerDots--;
            innerDots += 2;
        }
        Console.WriteLine("{0}", new string('*', 3 * size));
    }
}

