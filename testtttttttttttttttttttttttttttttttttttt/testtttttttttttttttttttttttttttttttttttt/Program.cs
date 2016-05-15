using System;
using System.Collections.Generic;

public class SortingArrays
{
    static string userInput;
    static string val;
    static string key;

    static Dictionary<string, string> dict = new Dictionary<string, string>();
    private static void Main()
    {
        string rotate = Console.ReadLine();

       string x = null;
        while (rotate!="exam")
        {
            userInput = Console.ReadLine();
            string[] wordbits = userInput.Split(' ');

            for (int i = 0; i < wordbits.Length; i++)
            {
                key = wordbits[i];
                for (int j = 0; j < wordbits.Length; j++)
                {
                    val = wordbits[(j + 1)];
                }

                dict.Add(key, val);
            }


            if (rotate=="Rotate(0)")
            {
                Console.WriteLine(userInput);
            }
           
            
        }

    }
}