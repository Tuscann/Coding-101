using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()    /*: , ; : . ! ( ) " ' / \ [ ] space*/
    {
        List<string> words = Console.ReadLine()
            .Split(new char[] { ',', ';', ':', '.', '!', '(', ')', '\"', '\'', '/', '\\', '[', ']', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

        List<string> upperCaseWords = new List<string>();
        List<string> lowerCaseWords = new List<string>();
        List<string> mixedCaseWords = new List<string>();

        foreach (var word in words)
        {
            bool isAllUppercase = true;
            bool isAllLowercase = true;
            for (int i = 0; i < word.Length; i++)
            {
                if (char.IsUpper(word[i])){isAllUppercase = false;}
                else if (char.IsLower(word[i])){isAllLowercase = false;}
                else
                { isAllUppercase = false;
                    isAllLowercase = false;}
            }
            if (isAllLowercase) { lowerCaseWords.Add(word); } 
            else if (isAllUppercase) { upperCaseWords.Add(word); }
            else { mixedCaseWords.Add(word); }
        }
        Console.WriteLine("Lower-case: {0}", string.Join(", ", upperCaseWords));
        Console.WriteLine("Mixed-case: {0}", string.Join(", ", mixedCaseWords));
        Console.WriteLine("Upper-case: {0}", string.Join(", ", lowerCaseWords));
    }

}

