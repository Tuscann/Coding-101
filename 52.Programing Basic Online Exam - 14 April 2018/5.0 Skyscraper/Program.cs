using System;
class Program
{
    static void Main()
    {
        int start = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());

        for (int first = start; first <= end; first++)
        {
            for (int second = start; second <= end; second++)
            {
                for (int third = start; third <= end; third++)
                {
                    for (int forth = start; forth <= end; forth++)
                    {
                        bool oddEven = first % 2 == 0 && forth % 2 != 0 || first % 2 != 0 && forth % 2 == 0;
                        bool biggerFirst = first > forth;
                        bool evenSum = (second + third) % 2 == 0;

                        if (oddEven && biggerFirst && evenSum)
                        {
                            Console.Write($"{first}{second}{third}{forth} ");
                        }
                    }
                }
            }
        }
    }
}