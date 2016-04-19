using System;
class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split('.', ' ');

        int day = Convert.ToInt32(input[0]);
        int mounth = Convert.ToInt32(input[1]);
        int year = Convert.ToInt32(input[2]);
        string username = input[3];

        double total = day * mounth * year;
        //Console.WriteLine("{0}*{1}*{2}={3}", day, mounth, year, total);

        if (mounth % 2 == 1) { total = total * total; }

        Console.WriteLine(total);

        for (int i = 0; i < username.Length; i++)
        {
            char currentChar = username[i];

            if (currentChar >= '0' && currentChar <= '9'){total += currentChar - '0';}
            else if (currentChar >= 'a' && currentChar <= 'z'){total += currentChar - 'a' + 1;}
            else if (currentChar >= 'A' && currentChar <= 'Z'){total += 2 * (currentChar - 'A' + 1);
            }
        }
        while (total > 13)
        {
            int digitSum = 0;

            while (total > 0)
            {
                digitSum += (int)(total % 10);
                total /= 10;
            }

            total = digitSum;
        }

        Console.WriteLine(total);
    }
}


