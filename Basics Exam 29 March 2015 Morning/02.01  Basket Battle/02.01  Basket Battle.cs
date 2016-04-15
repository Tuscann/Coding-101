using System;

class BasketBattle
{
    static void Main()
    {
        string first = Console.ReadLine();
        int rounds = int.Parse(Console.ReadLine());
        bool simeonFirst = false;    bool nakovFirst = false;
        int simeonPoints = 0;       int nakovPoints = 0;
        string winner = "";     int winningRound = 0;

        if (first == "Simeon")
        {
            simeonFirst = true;
        }
        else if (first == "Nakov")
        {
            nakovFirst = true;
        }

        for (int round = 1; round <= rounds; round++)
        {
            int firstPoints = int.Parse(Console.ReadLine());
            string firstSuccessfulShot = Console.ReadLine();

            if (simeonFirst)
            {
                if (firstSuccessfulShot == "success" && simeonPoints + firstPoints <= 500)
                {
                    simeonPoints += firstPoints;
                }
                if (simeonPoints == 500)
                {
                    winner = "Simeon";
                    winningRound = round;
                    break;
                }

                int secondPoints = int.Parse(Console.ReadLine());
                string secondSuccessfulShot = Console.ReadLine();

                if (secondSuccessfulShot == "success" && nakovPoints + secondPoints <= 500)
                {
                    nakovPoints += secondPoints;
                    if (nakovPoints == 500)
                    {
                        winner = "Nakov";
                        winningRound = round;
                        break;
                    }
                }
            }

            if (nakovFirst)
            {
                if (firstSuccessfulShot == "success" && nakovPoints + firstPoints <= 500)
                {
                    nakovPoints += firstPoints;
                }

                if (nakovPoints == 500)
                {
                    winner = "Nakov";
                    winningRound = round;
                    break;
                }

                int secondPoints = int.Parse(Console.ReadLine());
                string secondSuccessfulShot = Console.ReadLine();

                if (secondSuccessfulShot == "success" && simeonPoints + secondPoints <= 500)
                {
                    simeonPoints += secondPoints;
                    if (simeonPoints == 500)
                    {
                        winner = "Simeon";
                        winningRound = round;
                        break;
                    }
                }
            }

            simeonFirst = !simeonFirst;
            nakovFirst = !nakovFirst;
        }


        if (winner == "Simeon")
        {
            Console.WriteLine("{0}\n{1}\n{2}",winner, winningRound, nakovPoints);
        }
        else if (winner == "Nakov")
        {
            Console.WriteLine("{0}\n{1}\n{2}", winner, winningRound, simeonPoints);
            
        }
        else if (simeonPoints == nakovPoints)
        {
            Console.WriteLine("DRAW\n{0}", simeonPoints);
        }
        else
        {
            if (simeonPoints > nakovPoints)
            {
                Console.WriteLine("Simeon");
                Console.WriteLine(simeonPoints - nakovPoints);
            }
            else
            {
                Console.WriteLine("Nakov");
                Console.WriteLine(nakovPoints - simeonPoints);
            }
        }
    }
}