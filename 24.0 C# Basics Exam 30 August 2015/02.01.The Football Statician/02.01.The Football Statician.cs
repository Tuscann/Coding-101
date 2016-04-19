using System;
using System.IO;

public class TheFootballStatistician
{
    public static void Main()
    {
        const int PointsPerWin = 3;
        const int PointsPerDraw = 1;

        decimal paymentPerMatch = decimal.Parse(Console.ReadLine());

        int arsenalPoints = 0;
        int chelseaPoints = 0;
        int manchesterCityPoints = 0;
        int manchesterUnitedPoints = 0;
        int liverpoolPoints = 0;
        int evertonPoints = 0;
        int southamptonPoints = 0;
        int tottenhamPoints = 0;

        int matchesCounter = 0;
        while (true)
        {
            string inputLine = Console.ReadLine();
            if (inputLine == "End of the league.")
            {
                break;
            }

            string[] arguments = inputLine.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string firstTeam = arguments[0];
            string secondTeam = arguments[2];
            string matchResult = arguments[1];

            if (matchResult == "1")
            {
                arsenalPoints = AddingPointsToTeam(
                    firstTeam,
                    arsenalPoints,
                    PointsPerWin,
                    ref chelseaPoints,
                    ref manchesterCityPoints,
                    ref manchesterUnitedPoints,
                    ref liverpoolPoints,
                    ref evertonPoints,
                    ref southamptonPoints,
                    ref tottenhamPoints);
            }
            else if (matchResult == "2")
            {
                arsenalPoints = AddingPointsToTeam(
                    secondTeam,
                    arsenalPoints,
                    PointsPerWin,
                    ref chelseaPoints,
                    ref manchesterCityPoints,
                    ref manchesterUnitedPoints,
                    ref liverpoolPoints,
                    ref evertonPoints,
                    ref southamptonPoints,
                    ref tottenhamPoints);
            }
            else
            {
                arsenalPoints = AddingPointsToTeam(
                    firstTeam,
                    arsenalPoints,
                    PointsPerDraw,
                    ref chelseaPoints,
                    ref manchesterCityPoints,
                    ref manchesterUnitedPoints,
                    ref liverpoolPoints,
                    ref evertonPoints,
                    ref southamptonPoints,
                    ref tottenhamPoints);

                arsenalPoints = AddingPointsToTeam(
                    secondTeam,
                    arsenalPoints,
                    PointsPerDraw,
                    ref chelseaPoints,
                    ref manchesterCityPoints,
                    ref manchesterUnitedPoints,
                    ref liverpoolPoints,
                    ref evertonPoints,
                    ref southamptonPoints,
                    ref tottenhamPoints);
            }

            matchesCounter++;
        }

        decimal priceForAllMatchesInLeva = (matchesCounter * paymentPerMatch) * 1.94m;

        Console.WriteLine("{0:f2}lv.", priceForAllMatchesInLeva);
        Console.WriteLine("Arsenal - {0} points.", arsenalPoints);
        Console.WriteLine("Chelsea - {0} points.", chelseaPoints);
        Console.WriteLine("Everton - {0} points.", evertonPoints);
        Console.WriteLine("Liverpool - {0} points.", liverpoolPoints);
        Console.WriteLine("Manchester City - {0} points.", manchesterCityPoints);
        Console.WriteLine("Manchester United - {0} points.", manchesterUnitedPoints);
        Console.WriteLine("Southampton - {0} points.", southamptonPoints);
        Console.WriteLine("Tottenham - {0} points.", tottenhamPoints);
    }

    private static int AddingPointsToTeam(
        string team,
        int arsenalPoints,
        int pointsToAdd,
        ref int chelseaPoints,
        ref int manchesterCityPoints,
        ref int manchesterUnitedPoints,
        ref int liverpoolPoints,
        ref int evertonPoints,
        ref int southamptonPoints,
        ref int tottenhamPoints)
    {
        switch (team)
        {
            case "Arsenal":
                arsenalPoints += pointsToAdd;
                break;
            case "Chelsea":
                chelseaPoints += pointsToAdd;
                break;
            case "ManchesterCity":
                manchesterCityPoints += pointsToAdd;
                break;
            case "ManchesterUnited":
                manchesterUnitedPoints += pointsToAdd;
                break;
            case "Liverpool":
                liverpoolPoints += pointsToAdd;
                break;
            case "Everton":
                evertonPoints += pointsToAdd;
                break;
            case "Southampton":
                southamptonPoints += pointsToAdd;
                break;
            case "Tottenham":
                tottenhamPoints += pointsToAdd;
                break;
        }

        return arsenalPoints;
    }
}