using System;
class Program
{
    static void Main()
    {

        string word = Console.ReadLine();
        string message = Console.ReadLine();

        int wordSum = 0;

        for (int i = 0; i < word.Length; i++)
        {
            wordSum += (char)word[i];
        }
        int mask = 0;
        int otherWordSum = wordSum;

        while (otherWordSum > 0)
        {
            while (otherWordSum != 0)
            {
                mask += otherWordSum % 10;
                otherWordSum /= 10;
            }
          otherWordSum = mask;
            if (mask > 9)
            {
                mask = 0;
            }
        }
        string final = string.Empty;
        int currentSymbol = 0;
        for (int i = 0; i < message.Length; i++)
        {
            if ((char)message[i] % mask == 0)
            {
                currentSymbol = (char)message[i] + mask;
                char symbol = (char)currentSymbol;
                final += symbol;
            }
            else
            {
                currentSymbol = (char)message[i] - mask;
                char symbol = (char)currentSymbol;
                final += symbol;
            }
        }
        char[] array = final.ToCharArray();
        Array.Reverse(array);
        Console.WriteLine(array);
    }
}