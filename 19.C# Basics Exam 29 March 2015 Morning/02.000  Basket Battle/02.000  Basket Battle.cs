using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        string firstPlayer = Console.ReadLine();
        string secondPlayer = "";
        int rounds = int.Parse(Console.ReadLine());

        bool win = false;
        Dictionary<string, int> playerPoints = new Dictionary<string, int>();
        playerPoints.Add("Simeon", 0);
        playerPoints.Add("Nakov", 0);

        if (firstPlayer == "Nakov"){secondPlayer = "Simeon";}
        else{secondPlayer = "Nakov";}

        for (int i = 1; i <= rounds; i++)
        {
            int points = int.Parse(Console.ReadLine());
            string result = Console.ReadLine();

            if (result == "success" && playerPoints[firstPlayer] + points <= 500)
            {
                playerPoints[firstPlayer] += points;

                if (playerPoints[firstPlayer] == 500)
                {
                    win = true;
                    Console.WriteLine("{0}\n{1}\n{2}",firstPlayer,i, playerPoints[secondPlayer]);
                    break;
                }
            }
            points = int.Parse(Console.ReadLine());
            result = Console.ReadLine();

            if (result == "success" && playerPoints[secondPlayer] + points <= 500)
            {
                playerPoints[secondPlayer] += points;

                if (playerPoints[secondPlayer] == 500)
                {
                    win = true;
                    Console.WriteLine("{0}\n{1}\n{2}", secondPlayer, i, playerPoints[firstPlayer]);
                    break;
                }
            }
            if (firstPlayer == "Nakov")
            {
                firstPlayer = "Simeon";
                secondPlayer = "Nakov";
            }
            else
            {
                firstPlayer = "Nakov";
                secondPlayer = "Simeon";
            }
        }
        if (!win)
        {
            if (playerPoints[secondPlayer] == playerPoints[firstPlayer])
            {
                Console.WriteLine("DRAW");
                Console.WriteLine(playerPoints[secondPlayer]);
            }
            else if (playerPoints[secondPlayer] < playerPoints[firstPlayer])
            {
                Console.WriteLine(firstPlayer);
                Console.WriteLine(playerPoints[firstPlayer] - playerPoints[secondPlayer]);
            }
            else
            {
                Console.WriteLine(secondPlayer);
                Console.WriteLine(playerPoints[secondPlayer] - playerPoints[firstPlayer]);
            }

        }

    }
}