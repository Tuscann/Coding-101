using System;
using System.Collections.Generic;

class LongestAlphabeticalWord
{
    static void Main()
    {
        string inputWord = Console.ReadLine();
        int n = int.Parse(Console.ReadLine());

        //// Print the matrix of letters
        //for (int row = 0; row < n; row++)
        //{
        //    for (int col = 0; col < n; col++)
        //    {
        //        Console.Write(GetLetterAtPosition(inputWord, n, row, col));
        //    }
        //    Console.WriteLine();
        //}

        // Find the longest alphabetical word in the matrix of letters
        string longestAlphaWord = "";
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                string strLeft = FindAlphabeticalWord(inputWord, n, row, col, -1, 0);
                longestAlphaWord = GetBetterWord(longestAlphaWord, strLeft);
                string strRight = FindAlphabeticalWord(inputWord, n, row, col, +1, 0);
                longestAlphaWord = GetBetterWord(longestAlphaWord, strRight);
                string strUp = FindAlphabeticalWord(inputWord, n, row, col, 0, -1);
                longestAlphaWord = GetBetterWord(longestAlphaWord, strUp);
                string strDown = FindAlphabeticalWord(inputWord, n, row, col, 0, +1);
                longestAlphaWord = GetBetterWord(longestAlphaWord, strDown);
            }
        }

        Console.WriteLine(longestAlphaWord);
    }

    private static string FindAlphabeticalWord(
        string inputWord, int n, int row, int col, int directionX, int directionY)
    {
        List<char> letters = new List<char>();
        char previousLetter = GetLetterAtPosition(inputWord, n, row, col);
        letters.Add(previousLetter);
        while (true)
        {
            col = col + directionX;
            row = row + directionY;
            if (row < 0 || row >= n || col < 0 || col >= n)
            {
                // We are of range --> stop appending letters
                break;
            }
            char nextLetter = GetLetterAtPosition(inputWord, n, row, col);
            if (nextLetter <= previousLetter)
            {
                // Non alphabetical order --> stop appending letters
                break;
            }
            letters.Add(nextLetter);
            previousLetter = nextLetter;
        }

        string alphaWord = new string(letters.ToArray());
        return alphaWord;
    }

    private static char GetLetterAtPosition(string inputWord, int n, int row, int col)
    {
        char ch = inputWord[(row * n + col) % inputWord.Length];
        return ch;
    }

    private static string GetBetterWord(string firstWord, string secondWord)
    {
        if ((firstWord.Length > secondWord.Length) ||
            ((firstWord.Length == secondWord.Length &&
             firstWord.CompareTo(secondWord) < 0)))
        {
            return firstWord;
        }

        return secondWord;
    }
}
