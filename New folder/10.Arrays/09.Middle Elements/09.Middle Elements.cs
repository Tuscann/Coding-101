using System;
using System.Linq;
class Program
{
    static void Main()
    {
        int[] originalArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int finalResult = 0;
       for (int i = 0; i < originalArray.Length - 1; i++)
        {
            int[] modifiedArray = new int[originalArray.Length - 1];
            for (int j = 0; j < modifiedArray.Length; j++)
                modifiedArray[j] = originalArray[j] + originalArray[j + 1];
            originalArray = modifiedArray;
            finalResult = modifiedArray[0];
        }
        Console.WriteLine(finalResult);
    }
}