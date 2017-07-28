using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        //Input & Variables
        var n = int.Parse(Console.ReadLine());
        string name = "";
        int points = 0;
        string winner = "";
        int winnerPoints = -100000;

        //Create a list of the students & student points
        List<string> students = new List<string>();
        List<int> studentPoints = new List<int>();

        //Split the entries into the lists
        for (int i = 0; i < n; i++)
        {
            students.Add(Console.ReadLine());
            studentPoints.Add(int.Parse(Console.ReadLine()));
        }
        for (int i = 0; i < n; i++)
        {
            //Use Current Student's name             
            name = students[i];
            points = 0;
            points = points + studentPoints[i];

            //Acquire Current Student's Points
            foreach (char c in name)
            {
                if ((int)c % 2 == 0)
                {
                    points += (int)c;
                }
                else
                {
                    points -= (int)c;
                }
            }
            //Check who has the highest number of points             
            if (points > winnerPoints)
            {
                winner = name;
                winnerPoints = points;
            }
        }
        //Output
        Console.WriteLine("The winner is {0} - {1} points", winner, winnerPoints);
    }
}