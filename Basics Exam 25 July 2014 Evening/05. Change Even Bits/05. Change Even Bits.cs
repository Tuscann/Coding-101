using System;
public class ChangeEvenBits
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] nums = new int[n];
        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = int.Parse(Console.ReadLine());
        }
        ulong lastInput = ulong.Parse(Console.ReadLine());
        const ulong one = 1;
        int changedBits = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            int num = nums[i];
            int len = 0;
            do
            {
                num = num / 2;
                len++;
            } while (num > 0);

            int bitPosition = 0;
            while (len > 0)
            {
                ulong mask = one << bitPosition;
                if ((lastInput & mask) == 0)
                {
                    changedBits++;
                }
                lastInput |= mask;
                bitPosition += 2;
                len--;
            }
        }
        Console.WriteLine(lastInput);
        Console.WriteLine(changedBits);
    }
}
