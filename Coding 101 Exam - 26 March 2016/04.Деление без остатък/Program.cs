using System;
class Program
{
    static void Main()
    {

        int n = int.Parse(Console.ReadLine());

        int p1 = 0;
        int p2 = 0;
        int p3 = 0;
        
        for (int i = 0; i < n; i++)
        {
            decimal k = decimal.Parse(Console.ReadLine());
            if (k % 2 == 0)
            {
                p1++;
            }
            else if (k % 3 == 0)
            {
                p2++;
            }
            else if (k % 4 == 0)
            {
                p3++;
            }
            k = decimal.Parse(Console.ReadLine());


        }
        Console.WriteLine("{0:f2}\n{1:f2}\n{2:f2}\n", p1 / 10 * 100, p2 / 10 * 100, p3 / 10 * 100);



    }
}

