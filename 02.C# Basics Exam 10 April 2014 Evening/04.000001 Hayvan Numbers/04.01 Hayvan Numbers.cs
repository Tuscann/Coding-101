using System;
using System.Text.RegularExpressions;
class HayvanNumbers
{
    static void Main()
    {
        int sum = int.Parse(Console.ReadLine());
        int diff = int.Parse(Console.ReadLine());

        int a;   int b;    int c;
        string num;
        int counter = 0;

        for (int i = 555; i <= 999; i++)
        {
            int tempSum = 0;
            a = i;
            b = a + diff;
            c = b + diff;

            num = a.ToString() + b + c;
            Regex r = new Regex("0|1|2|3|4");
            if (!r.IsMatch(num))
            {
                for (int j = 0; j < num.Length; j++)
                {
                    tempSum += Convert.ToInt32(num[j].ToString());
                }

                if (tempSum == sum && num.Length == 9)
                {
                    Console.WriteLine(num);
                    counter++;
                }
            }
        }

        if (counter == 0)
        {
            Console.WriteLine("No");
        }
    }
}