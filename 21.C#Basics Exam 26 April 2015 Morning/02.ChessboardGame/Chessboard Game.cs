using System;
class Program
{
    static void Main()
    {
        var boardSize = int.Parse(Console.ReadLine());
        string inputstrings = Console.ReadLine();

        var whiteTeamScore = 0;
        var blackTeamScore = 0;

        int cellsCount = boardSize * boardSize;

        if (cellsCount > inputstrings.Length)
        {
            string additionalCharacters = new string(' ', cellsCount - inputstrings.Length);
            inputstrings = inputstrings + additionalCharacters;
        }


        for (int letter = 0; letter < cellsCount; letter++)
        {
            char currentChar = inputstrings[letter];

            if ((currentChar >= 'a' && currentChar <= 'z') || (currentChar >= 'A' && currentChar <= 'Z') || (currentChar >= '0' && currentChar <= '9'))
            {
                if (letter % 2 == 0)
                {
                    if (currentChar >= 'A' && currentChar <= 'Z')
                    {
                        whiteTeamScore = whiteTeamScore + currentChar;
                    }
                    else
                    {
                        blackTeamScore = blackTeamScore + currentChar;
                    }

                }
                else
                {
                    if (currentChar >= 'A' && currentChar <= 'Z')
                    {

                        blackTeamScore = blackTeamScore + currentChar;
                    }
                    else
                    {
                        whiteTeamScore = whiteTeamScore + currentChar;
                    }

                }
            }

        }
        if (blackTeamScore < whiteTeamScore)
        {
            Console.WriteLine("The winner is: white team");
            Console.WriteLine(whiteTeamScore - blackTeamScore);
        }
        else if (blackTeamScore > whiteTeamScore)
        {
            Console.WriteLine("The winner is: black team");
            Console.WriteLine(blackTeamScore - whiteTeamScore);
        }


        else if (whiteTeamScore == blackTeamScore)
        {
            Console.WriteLine("Equal result: {0}", blackTeamScore);
        }
    }
}

