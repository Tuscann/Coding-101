using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] arr = Console.ReadLine().Split(' ').Select(a => int.Parse(a)).ToArray();
        int[] arrFoldA = new int[arr.Length / 2];
        int[] arrFoldB = new int[arr.Length / 2];
        int n = 0;
        for (int i = arr.Length / 4 - 1; i >= 0; i--)
        {
            arrFoldA[n] = arr[i];
            n++;
        }
        n = arr.Length / 2 - 1;
        for (int i = arr.Length - arr.Length / 4; i < arr.Length; i++)
        {
            arrFoldA[n] = arr[i];
            n--;
        }
        n = 0;
        int start = arr.Length / 4;
        int end = arr.Length - arr.Length / 4;
        for (int i = start; i < end; i++)
        {
            arrFoldB[n] = arr[i];
            n++;
        }
        int[] sum = new int[arrFoldA.Length];
        for (int i = 0; i < arrFoldA.Length; i++)
        {
            sum[i] = arrFoldA[i] + arrFoldB[i];
        }
        Console.WriteLine(string.Join(" ", sum));
    }
}