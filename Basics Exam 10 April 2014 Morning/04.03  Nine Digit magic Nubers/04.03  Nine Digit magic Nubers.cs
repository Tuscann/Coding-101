using System;
using System.Collections.Generic;
class NineDigitMagicNumbers
{
    static void Main()
    {
        int sum = int.Parse(Console.ReadLine());
        int diff = int.Parse(Console.ReadLine());

        List<int> list = new List<int>();
        for (int i = 1; i <= 7; i++)
        {
            for (int j = 1; j <= 7; j++)
            {
                for (int k = 1; k <= 7; k++)
                {
                    list.Add(i * 100 + j * 10 + k);
                }
            }
        }

        int count = 0;

        for (int i = 0; i < list.Count; i++)
        {
            for (int j = 0; j < list.Count; j++)
            {
                for (int k = 0; k < list.Count; k++)
                {
                    if (list[k] - list[j] == diff && list[j] - list[i] == diff
                        && (list[i] / 100 + (list[i] / 10) % 10 + list[i] % 10 + list[j] / 100
                        + (list[j] / 10) % 10 + list[j] % 10 + list[k] / 100 + (list[k] / 10) % 10 +
                        list[k] % 10 == sum) && (list[i] <= list[j]) && (list[j] <= list[k]))
                    {
                        count++;
                        Console.Write(list[i] + "" + list[j] + "" + list[k]+"\n");
                    }
                }
            }
        }

        if (count == 0)
        {
            Console.WriteLine("No");
        }
    }

}