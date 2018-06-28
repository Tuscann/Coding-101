using System;
class Program
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        int counter = 0;
        int m = 33;
        int n = 58;

        for (int k = 1; k <= a; k++)
        {
            for (int i = 1; i <= b; i++)
            {
                if (counter >= c)
                {
                    break;
                }
                if (m > 47)
                {
                    m = 33;
                }
                if (n > 64)
                {
                    n = 58;
                }
                String newCode = (char)m + "" + (char)n + "" + k + "" + i + (char)n + "" + (char)m;
                Console.Write(newCode + "|");
                m++;
                n++;
                counter++;
            }
        }
    }
}