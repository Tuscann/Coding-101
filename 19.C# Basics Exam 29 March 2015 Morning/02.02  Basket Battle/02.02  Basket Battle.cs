using System;
class BasketBattle
{
    static void Main()
    {
        string F = Console.ReadLine();
        int N = int.Parse(Console.ReadLine());

        int NakovScore = 0;
        int SimeonScore = 0;
        for (int i = 0; i < N; i++)
        {
            int P1 = int.Parse(Console.ReadLine());
            string I1 = Console.ReadLine();

            switch (F)
            {
                case "Nakov":
                    {
                        NakovScore = Score(NakovScore, P1, I1);
                        if (NakovScore == 500 && SimeonScore != NakovScore)
                        {
                            NakovWins(SimeonScore, i);
                            return;
                        }
                        break;
                    }
                case "Simeon":
                    {
                        SimeonScore = Score(SimeonScore, P1, I1);
                        if (SimeonScore == 500 && SimeonScore != NakovScore)
                        {
                            SimeonWins(NakovScore, i);
                            return;
                        }
                        break;
                    }
            }

            int P2 = int.Parse(Console.ReadLine());
            string I2 = Console.ReadLine();

            switch (F)
            {
                case "Simeon":
                    {
                        NakovScore = Score(NakovScore, P2, I2);
                        if (NakovScore == 500 && SimeonScore != NakovScore)
                        {
                            NakovWins(SimeonScore, i);
                            return;
                        }
                        F = "Nakov";
                        break;
                    }
                case "Nakov":
                    {
                        SimeonScore = Score(SimeonScore, P2, I2);
                        if (SimeonScore == 500 && SimeonScore != NakovScore)
                        {
                            SimeonWins(NakovScore, i);
                            return;
                        }
                        F = "Simeon";
                        break;
                    }
            }
        }

        if (SimeonScore == NakovScore)
        {
            Console.WriteLine("DRAW\n{0}",NakovScore);
            
        }
        else
        {
            if (NakovScore > SimeonScore)
            {
                Console.WriteLine("Nakov");
            }
            else
            {
                Console.WriteLine("Simeon");
            }
            Console.WriteLine(Math.Abs(NakovScore - SimeonScore));
        }
    }

    private static void SimeonWins(int NakovScore, int i)
    {
        Console.WriteLine("Simeon");
        Console.WriteLine(i + 1);
        Console.WriteLine(NakovScore);
    }

    private static void NakovWins(int SimeonScore, int i)
    {
        Console.WriteLine("Nakov");
        Console.WriteLine(i + 1);
        Console.WriteLine(SimeonScore);
    }

    private static int Score(int Score, int P, string I)
    {
        if (I == "success")
        {
            int temp = Score;
            temp += P;
            if (temp <= 500)
            {
                Score = temp;
            }
        }
        return Score;
    }
}
