using System;
using System.Collections.Generic;
using System.Linq;

class Four
{
    static void Main()
    {
        string input = Console.ReadLine();

        string[] stringArray = input.Split(new Char[] { '\\' });

        string firstString = stringArray[0];
        string secondString = stringArray[1];
        string command = stringArray[2];

        //input is valid
        List<char> result = new List<char>();

        //JOIN command
        if (command == "join")
        {
            for (int first = 0; first < firstString.Length; first++)
            {
                for (int second = 0; second < secondString.Length; second++)
                {
                    if (firstString[first] == secondString[second])
                    {
                        result.Add(firstString[first]);
                    }
                }
            }



        }
        //LEFT EXLUDE
        else if (command == "left exclude")
        {
            for (int i = 0; i < secondString.Length; i++)
            {
                result.Add(secondString[i]);
            }

            for (int first = 0; first < secondString.Length; first++)
            {
                for (int second = 0; second < firstString.Length; second++)
                {
                    if (secondString[first] == firstString[second])
                    {
                        result.Remove(secondString[first]);
                    }
                }
            }


        }
        //RIGHT EXCLUDE
        else if (command == "right exclude")
        {
            for (int i = 0; i < firstString.Length; i++)
            {
                result.Add(firstString[i]);
            }

            for (int first = 0; first < firstString.Length; first++)
            {
                for (int second = 0; second < secondString.Length; second++)
                {
                    if (firstString[first] == secondString[second])
                    {
                        result.Remove(firstString[first]);
                    }
                }
            }
        }

        //remove duplicates
        List<char> finalResult = result.Distinct().ToList();
        finalResult.Sort();

        for (int i = 0; i < finalResult.Count; i++)
        {
            Console.Write(finalResult[i]);
        }

    }
}