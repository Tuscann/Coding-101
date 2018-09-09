using System;

internal class Program
{
    public static void Main()
    {
        string bestPleyerName = "";
        int bestGols = 0;

        string namePleayer = Console.ReadLine();

        while (true)
        {
            if (namePleayer.Equals("END"))
            {
                break;
            }
            int goals = int.Parse(Console.ReadLine());

            if (goals >= 10)
            {
                bestGols = goals;
                bestPleyerName = namePleayer;
                break;
            }

            if (goals > bestGols)
            {
                bestGols = goals;
                bestPleyerName = namePleayer;

            }
            namePleayer = Console.ReadLine();
        }

        Console.WriteLine(bestPleyerName + " is the best player!");

        if (bestGols >= 3)
        {
            Console.WriteLine("{0} has scored {1} goals and made a hat-trick !!!", "He", bestGols);
        }
        else if (bestGols <= 10)
        {
            Console.WriteLine("{0} has scored {1} goals.", "He", bestGols);
        }
    }
}