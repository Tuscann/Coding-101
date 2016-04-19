using System;
class BitSwapper
{
    public static void Main()
    {
        uint[] numbers = new uint[4];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = uint.Parse(Console.ReadLine());
        }
        while (true)
        {
            string[] from = Console.ReadLine().Split(' ');
            if (from[0] == "End")
            {
                break;
            }
            string[] to = Console.ReadLine().Split(' ');

            int firstNumber = int.Parse(from[0]);
            int secondNumber = int.Parse(to[0]);
            int firstGroup = int.Parse(from[1]) * 4;
            int secondGroup = int.Parse(to[1]) * 4;

            uint fromMask = 15u << firstGroup;
            uint toMask = 15u << secondGroup;
            uint fromByte = (numbers[firstNumber] & fromMask) >> firstGroup;
            uint toByte = (numbers[secondNumber] & toMask) >> secondGroup;

            numbers[firstNumber] &= ~fromMask;
            numbers[secondNumber] &= ~toMask;

            numbers[firstNumber] |= toByte << firstGroup;
            numbers[secondNumber] |= fromByte << secondGroup;
        }

        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}