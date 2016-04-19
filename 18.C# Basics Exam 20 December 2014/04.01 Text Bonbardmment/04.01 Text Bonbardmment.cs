using System;

class Program
{
    static void Main()
    {

        string inputText = Console.ReadLine();
        string tableWightString = Console.ReadLine();
        int tableWidth = int.Parse(tableWightString);
        string columnNumberString = Console.ReadLine();
        string[] columnNumbersStingArray = columnNumberString.Split();
        int[] columnNumberIntArray = new int[columnNumbersStingArray.Length];

        for (int i = 0; i < columnNumbersStingArray.Length; i++)
        {
            columnNumberIntArray[i] = int.Parse(columnNumbersStingArray[i]);
        }
        string outputText = inputText;

        for (int i = 0; i < columnNumberIntArray.Length; i++)
        {
            int currentBombNumber = columnNumberIntArray[i];
            //int currentOutputPositon = currentBombNumber;
            bool isCharForchange = false;

            for (int j = currentBombNumber; j < outputText.Length; j += tableWidth)
            {
                if (isCharForchange && outputText[j] == ' ')
                {
                    break;
                }
                if (outputText[j] != ' ')
                {
                    isCharForchange = true;
                }
                outputText = outputText.Substring(0, j) + " " + outputText.Substring(j + 1);
            }
        }
        Console.WriteLine(outputText);
    }
}

