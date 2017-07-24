using System;
class Program
{
    static void Main()
    {
        char bigChar = char.Parse(Console.ReadLine());
        char firstSmallChar = char.Parse(Console.ReadLine());
        char secoundSmallChar = char.Parse(Console.ReadLine());
        char thirdSmallChar = char.Parse(Console.ReadLine());
        int number = int.Parse(Console.ReadLine());

        int counter = 0;

        for (char big = 'A'; big <= bigChar; big++)
        {
            for (char first = 'a'; first <= firstSmallChar; first++)
            {
                for (char secound = 'a'; secound <= secoundSmallChar; secound++)
                {
                    for (char third = 'a'; third <= thirdSmallChar; third++)
                    {
                        for (int m = 0; m <= number; m++)
                        {
                            if (big == bigChar && first == firstSmallChar && secound == secoundSmallChar && third == thirdSmallChar && m == number)
                            {
                                break;
                            }
                            counter++;
                        }
                    }
                }
            }
        }
        Console.WriteLine(counter);
    }
}