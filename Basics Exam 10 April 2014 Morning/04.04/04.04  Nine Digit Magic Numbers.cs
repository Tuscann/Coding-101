using System;
class Program
{
    static void Main()
    {
        int sum = int.Parse(Console.ReadLine());
        int diff = int.Parse(Console.ReadLine());
        bool foundSolution = false;




        //for (int d1 = 1; d1 <= 7; d1++)
        //{
        //    for (int d2 = 1; d2 <= 7; d2++)
        //    {
        //        for (int d3 = 1; d3 <= 7; d3++)
        //        {
        //            for (int d4 = 1; d4 <= 7; d4++)
        //            {
        //                for (int d5 = 1; d5 <= 7; d5++)
        //                {
        //                    for (int d6 = 1; d6 <= 7; d6++)
        //                    {
        //                        for (int d7 = 1; d7 <= 7; d7++)
        //                        {
        //                            for (int d8 = 1; d8 <= 7; d8++)
        //                            {
        //                                for (int d9 = 1; d9 <= 7; d9++)
        //                                {
        //                                    if ((d4 * 100 + d5 * 100 + d6) - (d1 * 100 + d2 * 10 + d3) == diff &&
        //                                        (d7 * 100 + d8 * 100 + d9) - (d4 * 100 + d5 * 100 + d6) == diff)
        //                                    {
        //                                        Console.WriteLine("{0}",d1);
        //                                    }
        //                                }
        //                            }
        //                        }
        //                    }
        //                }
        //            }
        //        }
        //    }
        //}

        for (int i = 111; i <= 777; i++)
        {
            for (int j = 111; j <= 777; j++)
            {
                for (int k = 111; k <= 777; k++)
                {
                    if (j - i == diff && k - j == diff && k > j && j > i)
                    {

                        Console.WriteLine(""+ i + j + k);

                    }
                }
            }
        }

    }
}

