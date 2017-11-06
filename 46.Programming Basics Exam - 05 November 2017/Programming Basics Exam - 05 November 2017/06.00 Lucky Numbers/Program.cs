using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int first = 1; first <= 9; first++)
        {
            for (int secound = 1; secound <= 9; secound++)
            {
                for (int third = 1; third <= 9; third++)
                {
                    for (int four = 1; four <= 9; four++)
                    {
                        if (first + secound == third + four && n % (first + secound) == 0)
                        {
                            Console.Write("{0}{1}{2}{3} ", first, secound, third, four);
                        }
                    }
                }
            }
        }
    }
}