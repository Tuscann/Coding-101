using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        decimal sumOdd = 0;
        decimal sumEven = 0;
        for (int i = 0; i < 2 * n; i++)
        {
            int a = int.Parse(Console.ReadLine());

            if (i % 2 == 0)
            {
                sumOdd = sumOdd + a;
            }
            else
            {
                sumEven = sumEven + a;
            }
        }
        if (sumOdd == sumEven)
        {
            Console.WriteLine("Yes, sum={0}", sumOdd);
        }
        if (sumOdd > sumEven)
        {
            Console.WriteLine("No, diff={0}", sumOdd - sumEven);
        }
        if (sumEven > sumOdd)
        {
            Console.WriteLine("No, diff={0}", sumEven - sumOdd);
        }
    }
}