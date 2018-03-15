using System;
class Program
{
    static void Main()  // 100/100
    {
        int n = int.Parse(Console.ReadLine());

        int numbers = 0;
        string numbersaa = "";
        int smallLetters = 0;
        string smallLettersaa = "";
        int bigLetters = 0;
        string bigLettersaa = "";
        int elsee = 0;
        string elseeaa = "";

        for (int i = 0; i < n; i++)
        {
            string current = Console.ReadLine();

            if (char.Parse(current) >= '0' && char.Parse(current) <= '9')
            {
                numbers += char.Parse(current);
                numbersaa += current;
            }
            else if (char.IsLower(char.Parse(current)))
            {
                smallLetters += char.Parse(current);
                smallLettersaa += current;
            }
            else if (char.IsUpper(char.Parse(current)))
            {
                bigLetters += char.Parse(current);
                bigLettersaa += current;
            }
            else
            {
                elsee += char.Parse(current);
                elseeaa += current;
            }
        }
        int max = Math.Max(numbers, Math.Max(smallLetters, Math.Max(bigLetters, elsee)));

        Console.WriteLine("Biggest ASCII sum is:" + max);
        string print = "";

        if (numbers >= smallLetters && numbers >= bigLetters && numbers >= elsee)
        {
            print = numbersaa;
        }
        else if (bigLetters >= smallLetters && bigLetters >= elsee)
        {
            print = bigLettersaa;
        }
        else if (smallLetters >= elsee)
        {
            print = smallLettersaa;
        }
        else
        {
            print = elseeaa;
        }
        Console.WriteLine("Combination of characters is:" + print);
    }
}