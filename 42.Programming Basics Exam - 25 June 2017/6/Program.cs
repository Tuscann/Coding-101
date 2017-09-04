using System;
class Program
{
    static void Main() // 100/100
    {
        int sum = int.Parse(Console.ReadLine());
        int flag = 0;

        for (int first = 1; first <= 30; first++)
        {
            for (int secound = 1; secound <= 30; secound++)
            {
                for (int third = 1; third <= 30; third++)
                {
                    if (first < secound && secound < third && first + secound + third == sum)
                    {
                        Console.WriteLine("{0} + {1} + {2} = {3}", first, secound, third, sum);
                        flag = 1;
                    }
                    if (first > secound && secound > third && first * secound * third == sum)
                    {
                        Console.WriteLine("{0} * {1} * {2} = {3}", first, secound, third, sum);
                        flag = 1;
                    }
                }
            }
        }
        if (flag == 0)
        {
            Console.WriteLine("No!");
        }
    }
}