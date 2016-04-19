using System;
using System.Linq;
class Program
{
    static void Main()
    {
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        for (int currentPosition = 0; currentPosition < numbers.Length; currentPosition++)
        {
            int curentMin = numbers[currentPosition];
            int currentMinIndex = currentPosition;
            for (int i = currentPosition + 1; i < numbers.Length; i++)
            {
                if (curentMin > numbers[i])
                {
                    curentMin = numbers[i];
                    currentMinIndex = i;
                }
            }
            int temp = numbers[currentPosition];
            numbers[currentPosition] = curentMin;
            numbers[currentMinIndex] = temp;
        }
        Console.WriteLine(string.Join(" <= ",numbers));
    }
}

