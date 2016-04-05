using System;

internal class Program
{
    private static void Main()
    {
        var input = Console.ReadLine().ToUpper();

        var numberOfVowels = 0;
        var sumOfLetters = 0;

        foreach (var letter in input)
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