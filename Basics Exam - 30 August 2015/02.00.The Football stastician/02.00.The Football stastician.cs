using System;
using System.Collections.Generic;

namespace Problem_02__Football_Statistician
{
    class FootballStatistician
    {
        public static void Main()
        {
            double eurosPaid = double.Parse(Console.ReadLine());
            int numberOfGames = 0;
            const string endMessage = "End of the league.";

            // Teams...
            Dictionary<string, Team> teams = new Dictionary<string, Team>()
            {
                {"Arsenal", new Team("Arsenal", 0)},
                {"Chelsea", new Team("Chelsea", 0)},
                {"Everton", new Team("Everton", 0)},
                {"Liverpool", new Team("Liverpool", 0)},
                {"ManchesterCity", new Team("Manchester City", 0)},
                {"ManchesterUnited", new Team("Manchester United", 0)},
                {"Southampton", new Team("Southampton", 0)},
                {"Tottenham", new Team("Tottenham", 0)}
            };

            string gamesInput = Console.ReadLine();
            while (!String.Equals(gamesInput, endMessage))
            {
                List<string> gameInfo = CleanInput(gamesInput.Split(' '));
                CalculateScore(teams, gameInfo[0], gameInfo[1], gameInfo[2]);

                numberOfGames++;

                gamesInput = Console.ReadLine();
            }

            Console.WriteLine("{0:0.00}lv.", (eurosPaid * numberOfGames) * 1.94);
            foreach (KeyValuePair<string, Team> team in teams)
            {
                Console.WriteLine(team.Value.PrintPoints());
            }
        }

        public static List<string> CleanInput(string[] input)
        {
            List<string> cleaned = new List<string>();

            foreach (string item in input)
            {
                if (!String.IsNullOrEmpty(item))
                {
                    cleaned.Add(item);
                }
            }

            return cleaned;
        }

        public static void CalculateScore(Dictionary<string, Team> teams, string team1, string result, string team2)
        {
            switch (result)
            {
                case "1":
                    teams[team1].points += 3;
                    break;
                case "X":
                    teams[team1].points += 1;
                    teams[team2].points += 1;
                    break;
                case "2":
                    teams[team2].points += 3;
                    break;
            }
        }
    }
    class Team
    {
        public string name { get; set; }
        public sbyte points { get; set; }

        public Team(string name, sbyte points)
        {
            this.name = name;
            this.points = points;
        }

        public string PrintPoints()
        {
            return name + " - " + points + " points.";
        }
    }
}