using System;
class Program
{
    static void Main()
    {
        int first = int.Parse(Console.ReadLine());
        int secound = int.Parse(Console.ReadLine());
        int max = int.Parse(Console.ReadLine());
        int counter = 0;

        for (int x = first; x <= secound; x++)
        {
            for (int y = first; y <= secound; y++)
            {
                Console.Write("<" + x + "-" + y + ">");
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