using System;
class Program
{
    static void Main()
    {
        int first = int.Parse(Console.ReadLine());
        int secound = int.Parse(Console.ReadLine());
        int max = int.Parse(Console.ReadLine());
        int counter = 0;

        for (int j = 1; j <= first; j++)
        {
            for (int k = 1; k <= secound; k++)
            {
                Console.Write("(" + j + " <-> " + k + ") ");

                counter++;
                if (counter == max)
                {
                    break;
                }
            }
            if (counter == max)
            {
                break;
            }
        }
    }
}