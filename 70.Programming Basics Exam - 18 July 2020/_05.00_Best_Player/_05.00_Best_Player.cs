using System;

namespace _05._00_Best_Player
{
    class Program
    {
        static void Main()
        {
            string nameBestPlayer = "";
            int bestPlayerGoals = 0;

            while (true)
            {
                string namePlayer = Console.ReadLine();
                if (namePlayer == "END")
                {
                    break;
                }
                int goals = int.Parse(Console.ReadLine());

                if (goals > bestPlayerGoals)
                {
                    bestPlayerGoals = goals;
                    nameBestPlayer = namePlayer;
                }
                
                if (goals >= 10)
                {
                    break;
                }
            }

            Console.WriteLine($"{nameBestPlayer} is the best player!");
            if (bestPlayerGoals >= 3)
            {
                Console.WriteLine($"He has scored {bestPlayerGoals} goals and made a hat-trick !!!");
            }
            else
            {
                Console.WriteLine($"He has scored {bestPlayerGoals} goals.");
            }
        }
    }
}