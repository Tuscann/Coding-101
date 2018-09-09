using System;

class Programs
{
    static void Main()
    {
        int firstNumberLimit = int.Parse(Console.ReadLine());
        int secondNumberLimit = int.Parse(Console.ReadLine());
        int thirdNumberLimit = int.Parse(Console.ReadLine());

        for (int firstNumber = 1; firstNumber <= firstNumberLimit; firstNumber++)
        {
            for (int secondNumber = 1; secondNumber <= secondNumberLimit; secondNumber++)
            {
                for (int thirdNumber = 1; thirdNumber <= thirdNumberLimit; thirdNumber++)
                {
                    switch (secondNumber)
                    {
                        case 2:
                        case 3:
                        case 5:
                        case 7:
                            if (firstNumber % 2 == 0 && thirdNumber % 2 == 0)
                            {
                                Console.WriteLine($"{firstNumber} {secondNumber} {thirdNumber}");
                            }
                            break;
                    }
                }
            }
        }
    }
}