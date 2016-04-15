using System;
class PokerStraight
{
    static void Main()
    {
        int targetWeight = int.Parse(Console.ReadLine());
        int[] faces = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
        int[] suits = { 1, 2, 3, 4 };
        int weight = 0;
        int counter = 0;

        for (int i = 0; i < faces.Length - 4; i++)
        {
            for (int s1 = 0; s1 < 4; s1++)
            {
                for (int s2 = 0; s2 < 4; s2++)
                {
                    for (int s3 = 0; s3 < 4; s3++)
                    {
                        for (int s4 = 0; s4 < 4; s4++)
                        {
                            for (int s5 = 0; s5 < 4; s5++)
                            {
                                weight = (10 * faces[i] + suits[s1]) + (20 * faces[i + 1] + suits[s2])
                                   + (30 * faces[i + 2] + suits[s3]) + (40 * faces[i + 3] + suits[s4])
                                   + (50 * faces[i + 4] + suits[s5]);

                                if (weight == targetWeight)
                                {
                                    counter++;
                                }
                            }
                        }
                    }
                }
            }
        }
        Console.WriteLine(counter);
    }
}