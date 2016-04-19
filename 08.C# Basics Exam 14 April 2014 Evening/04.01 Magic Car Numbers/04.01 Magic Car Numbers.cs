using System;
class Program
{
    static void Main()
    {
        char[] arr = { 'A', 'B', 'C', 'E', 'H', 'K', 'M', 'P', 'T', 'X' };
        int magicWeight = int.Parse(Console.ReadLine());
        int weight = 0;
        int count = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            for (int k = 0; k < arr.Length; k++)
            {
                weight = ((int)arr[i] + (int)arr[k] - 128) * 10;
                for (int a = 0; a < 10; a++)
                {
                    if (4 * a + 40 + weight == magicWeight)
                    {
                        count++;
                    }

                    for (int b = 0; b < 10; b++)
                    {
                        if (a != b)
                        {
                            if (3 * b + a + 40 + weight == magicWeight)
                            {
                                count++;
                            }
                            if (3 * a + b + 40 + weight == magicWeight)
                            {
                                count++;
                            }
                            if (2 * a + 2 * b + 40 + weight == magicWeight)
                            {
                                count += 3;
                            }
                        }
                    }
                }
            }
        }
        Console.WriteLine(count);
    }
}
