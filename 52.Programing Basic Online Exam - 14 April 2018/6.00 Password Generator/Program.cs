using System;
class Program
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        char b = Console.ReadLine().ToUpper()[0];
        char c = Console.ReadLine().ToLower()[0];
        int d = int.Parse(Console.ReadLine());
        int e = int.Parse(Console.ReadLine());
        int f = int.Parse(Console.ReadLine());

        int n = int.Parse(Console.ReadLine());

        long counter = 0;
        Boolean isfound = true;

        for (int i = 1; i <= a; i++)
        {
            for (char j = 'A'; j <= b; j++)
            {
                for (char k = 'a'; k <= c; k++)
                {
                    for (int z = 1; z <= d; z++)
                    {
                        for (int p = 1; p <= e; p++)
                        {
                            for (int l = 1; l <= f; l++)
                            {
                                counter++;

                                if (counter == n)
                                {
                                    Console.WriteLine(i + "" + j + "" + k + "" + z + "" + p + "" + l);
                                    isfound = false;
                                }
                            }
                        }
                    }
                }
            }
        }
        if (isfound)
        {
            Console.WriteLine("No password on this position");
        }
    }
}