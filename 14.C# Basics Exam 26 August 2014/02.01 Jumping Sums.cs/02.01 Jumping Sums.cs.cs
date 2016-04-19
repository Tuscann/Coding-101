using System;
public class JumpingSums
{
    public static void Main()
    {
        string[] inputLine = Console.ReadLine().Split();
        int[] nums = new int[inputLine.Length];

        for (int i = 0; i < inputLine.Length; i++)
        {
            nums[i] = int.Parse(inputLine[i]);
        }
        int jumpsCount = int.Parse(Console.ReadLine());

        int maxSum = 0;
        for (int index = 0; index < nums.Length; index++)
        {
            int currSum = 0;
            int currIndex = index;

            for (int currJump = 0; currJump <= jumpsCount; currJump++)
            {
                currSum += nums[currIndex];
                currIndex = (currIndex + nums[currIndex]) % nums.Length;
            }

            if (currSum > maxSum)
            {
                maxSum = currSum;
            }
        }
        Console.WriteLine("max sum = " + maxSum);
    }
}