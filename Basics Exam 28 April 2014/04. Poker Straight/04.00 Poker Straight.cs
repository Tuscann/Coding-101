using System;
class PokerStraight
{
    static void Main()
    {
        int targetWeight = int.Parse(Console.ReadLine());

        string[] cardFaces = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        string[] cardSuits = { "Clubs", "Diamonds", "Hearts", "Spades" };
        int count = 0;
        for (int face = 0; face < cardFaces.Length - 4; face++)
        {
            for (int suit1 = 0; suit1 < cardSuits.Length; suit1++)
            {
                for (int suit2 = 0; suit2 < cardSuits.Length; suit2++)
                {
                    for (int suit3 = 0; suit3 < cardSuits.Length; suit3++)
                    {
                        for (int suit4 = 0; suit4 < cardSuits.Length; suit4++)
                        {
                            for (int suit5 = 0; suit5 < cardSuits.Length; suit5++)
                            {
                                int weight =
                                    (face + 1) * 10 + suit1 + 1 +
                                    (face + 2) * 20 + suit2 + 1 +
                                    (face + 3) * 30 + suit3 + 1 +
                                    (face + 4) * 40 + suit4 + 1 +
                                    (face + 5) * 50 + suit5 + 1;
                                if (weight == targetWeight)
                                {
                                    count++;

                                    // Print the straight hand + its weight
                                    //string card1 = cardFaces[face + 0] + cardSuits[suit1][0];
                                    //string card2 = cardFaces[face + 1] + cardSuits[suit2][0];
                                    //string card3 = cardFaces[face + 2] + cardSuits[suit3][0];
                                    //string card4 = cardFaces[face + 3] + cardSuits[suit4][0];
                                    //string card5 = cardFaces[face + 4] + cardSuits[suit5][0];
                                    //Console.WriteLine("({0} {1} {2} {3} {4}) -> weight {5}",
                                    //    card1, card2, card3, card4, card5, weight);
                                }
                            }
                        }
                    }
                }
            }
        }
        Console.WriteLine(count);
    }
}
