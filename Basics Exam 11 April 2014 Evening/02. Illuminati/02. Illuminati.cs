using System;
class Program
{
    private static void Main()
    {
        string input = Console.ReadLine().ToUpper();

        int numberOfVowels = 0;
        int sumOfLetters = 0;

        foreach (char letter in input)
        {
            if (letter == 'A')
            {
                numberOfVowels++;
                sumOfLetters = sumOfLetters + letter;
            }
            if (letter == 'E')
            {
                numberOfVowels++;
                sumOfLetters = sumOfLetters + letter;
            }
            if (letter == 'I')
            {
                numberOfVowels++;
                sumOfLetters = sumOfLetters + letter;
            }
            if (letter == 'O')
            {
                numberOfVowels++;
                sumOfLetters = sumOfLetters + letter;
            }
            if (letter == 'U')
            {
                numberOfVowels++;
                sumOfLetters = sumOfLetters + letter;
            }
        }
        Console.WriteLine("{0}\n{1}", numberOfVowels, sumOfLetters);
    }
}

