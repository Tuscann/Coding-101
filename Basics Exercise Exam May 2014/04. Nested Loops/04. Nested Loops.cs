using System;

class Problem_4_Bulls_and_Cows
{
    static void Main()
    {
        int guessNum = int.Parse(Console.ReadLine());
        int targetBulls = int.Parse(Console.ReadLine());
        int targetCows = int.Parse(Console.ReadLine());

        bool solutionFound = false;

        // Check all possible sequences of 4 digits
        for (int d1 = 1; d1 <= 9; d1++)
        {
            for (int d2 = 1; d2 <= 9; d2++)
            {
                for (int d3 = 1; d3 <= 9; d3++)
                {
                    for (int d4 = 1; d4 <= 9; d4++)
                    {
                        int guess1 = (guessNum / 1000) % 10;
                        int guess2 = (guessNum / 100) % 10;
                        int guess3 = (guessNum / 10) % 10;
                        int guess4 = (guessNum / 1) % 10;

                        int oldD1 = d1;
                        int oldD2 = d2;
                        int oldD3 = d3;
                        int oldD4 = d4;

                        // Calculate the number of bulls and cows between the numbers
                        // (d1, d2, d3, d4) and (guess1, guess2, guess3, guess4)

                        int bulls = 0;
                        int cows = 0;

                        // Find all bulls, count them and remove them (assign -1 and -2)
                        if (d1 == guess1)
                        {
                            // Bull at position #1 found -> count it and remove it
                            bulls++;
                            guess1 = -1;
                            d1 = -2;
                        }
                        if (d2 == guess2)
                        {
                            // Bull at position #2 found -> count it and remove it
                            bulls++;
                            guess2 = -1;
                            d2 = -2;
                        }
                        if (d3 == guess3)
                        {
                            // Bull at position #3 found -> count it and remove it
                            bulls++;
                            guess3 = -1;
                            d3 = -2;
                        }
                        if (d4 == guess4)
                        {
                            // Bull at position #4 found -> count it and remove it
                            bulls++;
                            guess4 = -1;
                            d4 = -2;
                        }

                        // Find all cows for d1, count them and remove them (assign -1)
                        if (d1 == guess2)
                        {
                            // Cow at position #2 found -> count it and remove it
                            cows++;
                            guess2 = -1;
                        }
                        else if (d1 == guess3)
                        {
                            // Cow at position #3 found -> count it and remove it
                            cows++;
                            guess3 = -1;
                        }
                        else if (d1 == guess4)
                        {
                            // Cow at position #4 found -> count it and remove it
                            cows++;
                            guess4 = -1;
                        }

                        // Find all cows for d2, count them and remove them (assign -1)
                        if (d2 == guess1)
                        {
                            // Cow at position #1 found -> count it and remove it
                            cows++;
                            guess1 = -1;
                        }
                        else if (d2 == guess3)
                        {
                            // Cow at position #3 found -> count it and remove it
                            cows++;
                            guess3 = -1;
                        }
                        else if (d2 == guess4)
                        {
                            // Cow at position #4 found -> count it and remove it
                            cows++;
                            guess4 = -1;
                        }

                        // Find all cows for d3, count them and remove them (assign -1)
                        if (d3 == guess1)
                        {
                            // Cows at position #1 found -> count it and remove it
                            cows++;
                            guess1 = -1;
                        }
                        else if (d3 == guess2)
                        {
                            // Cow at position #2 found -> count it and remove it
                            cows++;
                            guess2 = -1;
                        }
                        else if (d3 == guess4)
                        {
                            // Cow at position #4 found -> count it and remove it
                            cows++;
                            guess4 = -1;
                        }

                        // Find all cows for d4, count them and remove them (assign -1)
                        if (d4 == guess1)
                        {
                            // Cows at position #1 found -> count it and remove it
                            cows++;
                            guess1 = -1;
                        }
                        else if (d4 == guess2)
                        {
                            // Cow at position #2 found -> count it and remove it
                            cows++;
                            guess2 = -1;
                        }
                        else if (d4 == guess3)
                        {
                            // Cow at position #3 found -> count it and remove it
                            cows++;
                            guess3 = -1;
                        }

                        d1 = oldD1;
                        d2 = oldD2;
                        d3 = oldD3;
                        d4 = oldD4;

                        // Print the configuration if the bulls and cows match the target
                        if (bulls == targetBulls && cows == targetCows)
                        {
                            if (solutionFound)
                            {
                                Console.Write(" ");
                            }
                            Console.Write("" + d1 + d2 + d3 + d4);
                            solutionFound = true;
                        }
                    }
                }
            }
        }

        if (!solutionFound)
        {
            Console.WriteLine("No");
        }
    }
}
