using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        bool isNo = true;

        for (int i = 0; i < arr.Length; i++)
        {
            int a = arr[i];

            for (int j = i + 1; j < arr.Length; j++)
            {
                int b = arr[j];
                int sum = a + b;
                if (arr.Contains(sum))
                {
                    Console.WriteLine("{0} + {1} == {2}", a, b, sum);
                    isNo = false;
                }
            }
        }
        if (isNo)
        {
            Console.WriteLine("No");
        }

    }
}
