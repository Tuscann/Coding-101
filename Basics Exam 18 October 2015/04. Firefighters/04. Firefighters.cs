using System;
class Program
{
    static void Main()
    {
        int savedKids = 0;
        int savedAdults = 0;
        int savedSeniors = 0;

        int numberOfFighers = int.Parse(Console.ReadLine());
        string inputLine = Console.ReadLine();

        while (inputLine != "rain")
        {
            int remainingFirefighters = numberOfFighers;
            int priorityPerson = 1;

            while (remainingFirefighters > 0 && priorityPerson <= 3)
            {
                foreach (char t in inputLine)
                {
                    if (remainingFirefighters <= 0) { break; }
                    switch (priorityPerson)
                    {
                        case 1: if (t == 'K') { savedKids++; remainingFirefighters--; } break;
                        case 2: if (t == 'A') { savedAdults++; remainingFirefighters--; } break;
                        case 3: if (t == 'S') { savedSeniors++; remainingFirefighters--; } break;
                    }
                }
                priorityPerson++;
            }
            inputLine = Console.ReadLine();
        }
        Console.WriteLine("Kids: {0}", savedKids);
        Console.WriteLine("Adults: {0}", savedAdults);
        Console.WriteLine("Seniors: {0}", savedSeniors);
    }
}

