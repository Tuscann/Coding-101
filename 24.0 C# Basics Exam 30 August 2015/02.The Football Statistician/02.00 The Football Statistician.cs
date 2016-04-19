using System;
using System.Collections.Generic;
class TheFootballStatistician
{
    static void Main()
    {
        decimal payment = decimal.Parse(Console.ReadLine());
        int multiply = 0;
        var table = new Dictionary<string, int>();
        table.Add("Arsenal", 0);
        table.Add("Chelsea", 0);
        table.Add("Everton", 0);
        table.Add("Liverpool", 0);
        table.Add("Manchester City", 0);
        table.Add("Manchester United", 0);
        table.Add("Southampton", 0);
        table.Add("Tottenham", 0);

        while (true)
        {
            string game = Console.ReadLine();
            string[] match = game.Split(new string[] { }, StringSplitOptions.RemoveEmptyEntries);
            if (game != "End of the league.")
            {
                for (int i = 0; i <= 2; i += 2)
                {
                    for (int j = 1; j < match[i].Length; j++)
                    {
                        if (Char.IsUpper(match[i][j]))
                        {
                            match[i] = match[i].Insert(j, " ");
                            break;
                        }
                    }
                }

                int gameResult = 0;
                table[match[0]] += gameResult = match[1] == "1" ? 3 : (match[1] == "X" ? 1 : 0);
                table[match[2]] += gameResult = match[1] == "1" ? 0 : (match[1] == "X" ? 1 : 3);
                multiply++;
            }
            else
            {
                break;
            }
        }

        Console.WriteLine("{0:F2}lv.", payment * multiply * 1.94M);
        foreach (var pair in table)
        {
            Console.WriteLine("{0} - {1} points.", pair.Key, pair.Value);
        }
    }
}