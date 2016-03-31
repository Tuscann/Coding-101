using System;
using System.Linq;
class Program
{
    static void Main()
    {
        int [] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        while (nums.Length > 1)
        {
            int[] condensed = new int[nums.Length - 1];
            for (int i = 0; i < nums.Length - 1; i++)
                //condensed[i] =;
              nums = condensed;
        }
        Console.WriteLine(nums[0]);

    }
}

