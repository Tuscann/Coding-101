using System;
class JumpingSums
{
    static void Main()
    {
        string inputStrs = Console.ReadLine();
        int jumpLenght = int.Parse(Console.ReadLine());
        string[] strArray = inputStrs.Split(' ');
        int[] intArray = new int[strArray.Length];
        int lenght = intArray.Length;
        for (int i = 0; i < lenght; i++)
        {
            intArray[i] = int.Parse(strArray[i]);
        }
        int maxSum = Int32.MinValue;
        for (int i = 0; i < lenght; i++)
        {
            int value = intArray[i];
            int currentIndex = i;
            int nextIndex = (currentIndex + value) % lenght;
            int sum = 0;

            for (int j = 0; j <= jumpLenght; j++)
            {
                sum += value;
                value = intArray[nextIndex];
                currentIndex = nextIndex;
                nextIndex = (currentIndex + value) % lenght;
            }
            if (sum > maxSum)
            {
                maxSum = sum;
            }
        }
        Console.WriteLine("max sum = {0}", maxSum);
    }
}