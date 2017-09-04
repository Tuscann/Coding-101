using System;
class Program
{
    static void Main() // 100/100
    {
        int count1Leva = int.Parse(Console.ReadLine());
        int count2Leva = int.Parse(Console.ReadLine());
        int count5Leva = int.Parse(Console.ReadLine());
        int sum = int.Parse(Console.ReadLine());

        for (int i = 0; i <= count1Leva; i++)
        {
            for (int j = 0; j <= count2Leva; j++)
            {
                for (int k = 0; k <= count5Leva; k++)
                {
                    if (i * 1 + j * 2 + k * 5 == sum)
                    {
                        Console.WriteLine("{0} * 1 lv. + {1} * 2 lv. + {2} * 5 lv. = {3} lv.", i, j, k, sum);
                    }
                }
            }
        }
    }
}