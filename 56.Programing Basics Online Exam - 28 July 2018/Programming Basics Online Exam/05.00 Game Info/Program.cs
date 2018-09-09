using System;

internal class Program
{
    public static void Main()
    {
        string name = Console.ReadLine();
        int predmeti = int.Parse(Console.ReadLine());

        int matcheWithextra = 0;
        int duzpi = 0;

        double total = 0;

        for (int i = 0; i < predmeti; i++)
        {
            int continie = int.Parse(Console.ReadLine());
            total += continie;

            if (continie >= 91 && continie <= 120)
            {
                matcheWithextra++;
            }
            else if (continie >= 121)
            {
                duzpi++;
            }
        }

        Console.Write("{0} has played {1} minutes.", name, total);
        Console.WriteLine(" Average minutes per game: {0:f2}", total / predmeti);
        Console.WriteLine("Games with penalties: {0}", duzpi);
        Console.WriteLine("Games with additional time: {0}", matcheWithextra);
    }
}