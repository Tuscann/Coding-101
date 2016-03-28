using System;

class Program
{
    static void Main()
    {
        int day = int.Parse(Console.ReadLine());
        int inRow = int.Parse(Console.ReadLine());

        int sumM = 0;
        int sumW = 0;

        for (int i = 0; i < inRow; i++)
        {
            if (day == 8)
            {
                day = 1;
            }
            switch (day)
            {

                case 1:
                    sumW = sumW + 1;
                    sumM = sumM + 0;
                    break;
                case 2:
                    sumW = sumW + 0;
                    sumM = sumM + 2;
                    break;
                case 3:
                    sumW = sumW + 1;
                    sumM = sumM + 1;
                    break;
                case 4:
                    sumW = sumW + 2;
                    sumM = sumM + 0;
                    break;
                case 5:
                    sumW = sumW + 2;
                    sumM = sumM + 2;
                    break;
                case 6:
                    sumW = sumW + 1;
                    sumM = sumM + 2;
                    break;
                case 7:
                    sumW = sumW + 0;
                    sumM = sumM + 0;
                    break;
                default:
                    break;
            }
            day++;
        }
        if (sumW > sumM)
        {
            Console.WriteLine("{0} more watermelons", sumW - sumM);
        }
        else if (sumM > sumW)
        {
            Console.WriteLine("{0} more melons", sumM - sumW);
        }
        else
        {
            Console.WriteLine("Equal amount: {0}", sumW);
        }

    }
}