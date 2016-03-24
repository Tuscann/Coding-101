using System;
class Problem03LocalElections
{
    static void Main()
    {
        int candidates = int.Parse(Console.ReadLine());
        int chosenOne = int.Parse(Console.ReadLine());
        string symbol = Console.ReadLine();
        Console.WriteLine(new string('.', 13));

        for (int i = 1; i <= candidates; i++)
        {
            Console.WriteLine("...+{0}+...", new string('-', 5));

            if (i == chosenOne)
            {
                if (symbol.ToLower() == "x")
                {
                    Console.WriteLine("...|.\\./.|...");
                    Console.WriteLine("{1}.|..{0}..|...", symbol.ToUpper(), i.ToString().PadLeft(2, '0'));
                    Console.WriteLine("...|./.\\.|...");
                }
                else
                {
                    Console.WriteLine("...|\\.../|...");
                    Console.WriteLine("{0}.|.\\./.|...", i.ToString().PadLeft(2, '0'));
                    Console.WriteLine("...|..V..|...");
                }
            }
            else
            {
                Console.WriteLine("...|.....|...");
                Console.WriteLine("{0}.|.....|...", i.ToString().PadLeft(2, '0'));
                Console.WriteLine("...|.....|...");
            }

            Console.WriteLine("...+{0}+...", new string('-', 5));
            Console.WriteLine(new string('.', 13));
        }
    }
}