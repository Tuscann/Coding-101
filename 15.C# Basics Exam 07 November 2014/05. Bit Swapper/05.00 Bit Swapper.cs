using System;
class BitSwapper
{
    static void Main()
    {
        uint[] numbers = new uint[4];
        for (int i = 0; i < 4; i++)
        {
            numbers[i] = uint.Parse(Console.ReadLine());
        }
        while (true)
        {
            string command = Console.ReadLine();
            if (command == "End")
            {
                break;
            }
            int[] firstNumCommand = Array.ConvertAll(command.Split(' '), int.Parse);
            command = Console.ReadLine();
            int[] secondNumCommand = Array.ConvertAll(command.Split(' '), int.Parse);
            uint firstNum = numbers[firstNumCommand[0]];
            uint secondNum = numbers[secondNumCommand[0]];
            int firstSwapSet = firstNumCommand[1];
            int secondSwapSet = secondNumCommand[1];
            uint mask = 15u;
            int firstNumPosition = firstSwapSet * 4;
            int secondNumPosition = secondSwapSet * 4;

            uint firstNumBits = (firstNum >> firstNumPosition) & mask;
            uint secondNumBits = (secondNum >> secondNumPosition) & mask;

            if (firstNumCommand[0] == secondNumCommand[0])
            {
                firstNum = firstNum & ~(mask << firstNumPosition);
                firstNum = firstNum & ~(mask << secondNumPosition);

                firstNum = firstNum | (secondNumBits << firstNumPosition);
                firstNum = firstNum | (firstNumBits << secondNumPosition);

                numbers[firstNumCommand[0]] = firstNum;
            }
            else
            {
                firstNum = firstNum & ~(mask << firstNumPosition);
                secondNum = secondNum & ~(mask << secondNumPosition);
                firstNum = firstNum | (secondNumBits << firstNumPosition);
                secondNum = secondNum | (firstNumBits << secondNumPosition);
                numbers[firstNumCommand[0]] = firstNum;
                numbers[secondNumCommand[0]] = secondNum;
            }
        }
        foreach (uint number in numbers)
        {
            Console.WriteLine(number);
        }

    }
}