using System;
using System.Collections.Generic;
class DigitMagic
{
    public static int sumDigits(int number)
    {
        int sameNumber = number;
        int sum = 0;
        for (int counter = 0; counter < 9; counter++)
        {
            sum += (sameNumber % 10);
            sameNumber /= 10;
        }
        return sum;
    }
    public static bool Digits(int number)
    {
        int sameNumber = number;
        bool isOk = true;
        for (int counter = 0; counter < 9; counter++)
        {
            if ((sameNumber % 10 == 0) || (sameNumber % 10 == 8) || (sameNumber % 10 == 9))
            {
                isOk = false;
            }
            sameNumber /= 10;
        }
        return isOk;
    }
    static void Main()
    {
        List<int> MagicNumbers = new List<int>();
        int firstThree = new int();
        int sum = int.Parse(Console.ReadLine());
        int diff = int.Parse(Console.ReadLine());
        int secondThree = new int();
        int thirdThree = new int();
        for (int first = 1; first <= 7; first++)
        {
            for (int second = 1; second <= 7; second++)
            {
                for (int third = 1; third <= 7; third++)
                {
                    firstThree = third + second * 10 + first * 100;
                    secondThree = firstThree + diff;
                    thirdThree = secondThree + diff;
                    int wholeNumber = firstThree * 1000000 + secondThree * 1000 + thirdThree;
                    if (sumDigits(wholeNumber) == sum && Digits(wholeNumber) && firstThree <= 777)
                    {
                        MagicNumbers.Add(wholeNumber);
                    }
                }
            }
        }
        foreach (var num in MagicNumbers)
        {
            Console.WriteLine(num);
        }
        if (MagicNumbers.Count == 0)
        {
            Console.WriteLine("No");
        }
    }
}