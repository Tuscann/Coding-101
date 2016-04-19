using System;
class Program
{
    static void Main()
    {
        decimal cash = decimal.Parse(Console.ReadLine());
        string[] houseHand = Console.ReadLine().Split();

        int housesStrength = 0;

        foreach (var card in houseHand)
        {
            switch (card)
            {
                case "J": housesStrength = housesStrength + 11; break;
                case "Q": housesStrength = housesStrength + 12; break;
                case "K": housesStrength = housesStrength + 13; break;
                case "A": housesStrength = housesStrength + 14; break;
                default: housesStrength += int.Parse(card); break;
            }
        }

        int countWinning = 0;
        int totalHands = 0;

        for (int card1 = 2; card1 < 15; card1++)
        {
            for (int card2 = 2; card2 < 15; card2++)
            {
                for (int card3 = 2; card3 < 15; card3++)
                {
                    for (int card4 = 2; card4 < 15; card4++)
                    {
                        int myPower = card1 + card2 + card3 + card4;

                        if (myPower > housesStrength)
                        {
                            countWinning++;

                        }
                        totalHands++;
                    }
                }
            }
        }
        double probability = (double)countWinning / totalHands;
        if (probability < 0.5)
        {
            Console.WriteLine("FOLD");
        }
        else
        {
            Console.WriteLine("DRAW");
        }
        decimal expectedWinning = (decimal)probability * 2 * cash;
        Console.WriteLine("{0:f2}", expectedWinning);
    }
}

