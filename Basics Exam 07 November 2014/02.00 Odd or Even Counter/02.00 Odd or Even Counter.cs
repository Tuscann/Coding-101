using System;
class Program
{
    private static void Main()
    {
        int numberOfSets = int.Parse(Console.ReadLine());
        int numbersPerSet = int.Parse(Console.ReadLine());
        string oddOrEvenString = Console.ReadLine();
        int oddOrEven = oddOrEvenString == "odd" ? 1 : 0;

        int highestNumbersSet = 0;
        int highestNumberOfWords = 0;
        for (int set = 1; set <= numberOfSets; set++)
        {
            int oddOrEvenCounter = 0;
            for (int i = 0; i < numbersPerSet; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                if (currentNumber % 2 == oddOrEven)
                {
                    oddOrEvenCounter++;
                    if (oddOrEvenCounter > highestNumberOfWords)
                    {
                        highestNumberOfWords = oddOrEvenCounter;
                        highestNumbersSet = set;
                    }
                }
            }
        }

        string numberOfSetWord = "";
        switch (highestNumbersSet)
        {
            case 1: numberOfSetWord = "First"; break;
            case 2: numberOfSetWord = "Second"; break;
            case 3: numberOfSetWord = "Third"; break;
            case 4: numberOfSetWord = "Fourth"; break;
            case 5: numberOfSetWord = "Fifth"; break;
            case 6: numberOfSetWord = "Sixth"; break;
            case 7: numberOfSetWord = "Seventh"; break;
            case 8: numberOfSetWord = "Eight"; break;
            case 9: numberOfSetWord = "Ninth"; break;
            case 10: numberOfSetWord = "Tenth"; break;
        }

        if (numberOfSetWord != "")
        {
            Console.WriteLine("{0} set has the most {1} numbers: {2}",
                numberOfSetWord,
                oddOrEvenString,
                highestNumberOfWords);
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}



