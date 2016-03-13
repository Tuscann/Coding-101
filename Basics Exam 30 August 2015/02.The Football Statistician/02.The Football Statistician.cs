using System;
using System.IO;

class Program
{
    static void Main()
    {
        decimal moneyPerMatch = decimal.Parse(Console.ReadLine());
        var result = int.Parse(Console.ReadLine().ToString());

        while (true)
        {
            string inputLine = Console.ReadLine();
            if (inputLine == "End of the league.")
            {
                break;
            }
            string[] arguments = inputLine.Split(new[] {' '},StringSplitOptions.RemoveEmptyEntries);
            string firstTeam = arguments[0];
            string secondTeam = arguments[2];
            string matchResult = arguments[1];


            if (matchResult == "1")
            {
                
            }
            else if (matchResult == "2")
            {
                
            }
            else
            {
                
            }
















        }
        Console.WriteLine("{0:f2} lv.",moneyPerMatch*1.94m*result);



    }


}

