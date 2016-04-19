using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split('\\');

        string leftArray = input[0];
        string rightdArray = input[1];
        string command = input[2];

        List<char> result = new List<char>();
        switch (command)
        {
            case "join":

                for (var i = 0; i < leftArray.Length; i++)
                {
                    for (var j = 0; j < rightdArray.Length; j++)
                    {
                        if (leftArray[i] == rightdArray[j])
                        {
                            result.Add(leftArray[i]);
                        }
                    }
                }
                break;
            case "right exclude":
                for (var i = 0; i < leftArray.Length; i++)
                {
                    bool isMatched = false;
                    for (var j = 0; j < rightdArray.Length; j++)
                    {
                        if (leftArray[i] == rightdArray[j])
                        {
                            isMatched = true;
                            break;
                        }
                    }
                    if (!isMatched)
                    {
                        result.Add(leftArray[i]);
                    }
                }
                break;

            case "left exclude":

                for (var i = 0; i < rightdArray.Length; i++)
                {
                    bool isMatched = false;
                    for (var j = 0; j < leftArray.Length; j++)
                    {
                        if (leftArray[j] == rightdArray[i])
                        {
                            isMatched = true;
                            break;
                        }
                    }
                    if (!isMatched)
                    {
                        result.Add(rightdArray[i]);
                    }
                }
                break;
        }
        result.Sort();
        Console.WriteLine(string.Join("", result));
    }
}

