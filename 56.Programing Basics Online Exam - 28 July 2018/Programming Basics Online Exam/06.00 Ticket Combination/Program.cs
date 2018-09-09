using System;
class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int counter = 0;

        for (char first = 'B'; first <= 'L'; first += (char)2)
        {
            for (char second = 'f'; second >= 'a'; second--)
            {
                for (char third = 'A'; third <= 'C'; third++)
                {
                    for (int forth = 1; forth <= 10; forth++)
                    {
                        for (int fifth = 10; fifth >= 1; fifth--)
                        {
                            counter++;
                            if (counter >= n)
                            {
                                Console.WriteLine($"Ticket combination: {first}{second}{third}{forth}{fifth}");
                                int sum = first + second + third + forth + fifth;
                                Console.WriteLine($"Prize: {sum} lv.");
                                Environment.Exit(0);
                            }
                        }
                    }
                }
            }
        }
    }
}