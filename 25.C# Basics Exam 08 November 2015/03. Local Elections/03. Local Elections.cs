using System;
class Program
{
    static void Main()
    {
        int totalCandidate = int.Parse(Console.ReadLine());
        int voteelector = int.Parse(Console.ReadLine());
        string votingSymbol = Console.ReadLine();
        
        for (int i = 1; i <= totalCandidate; i++)
        {
            Console.WriteLine(".............");
            Console.WriteLine("...+-----+...");
            if (i == voteelector && (votingSymbol == "x" || votingSymbol == "X"))
            {
                Console.WriteLine("...|.\\./.|...");
                Console.WriteLine("{0:00}.|..X..|...", i);
                Console.WriteLine("...|./.\\.|...");
            }
            else if (i == voteelector && (votingSymbol == "v" || votingSymbol == "V"))
            {
                Console.WriteLine("...|\\.../|...");
                Console.WriteLine("{0:00}.|.\\./.|...", i);
                Console.WriteLine("...|..V..|...");

            }
            else
            {
                Console.WriteLine("...|.....|...");
                Console.WriteLine("{0:00}.|.....|...", i);
                Console.WriteLine("...|.....|...");
            }
            Console.WriteLine("...+-----+...");
        }
        
        Console.WriteLine(".............");
    }
}

