using System;
class PerfectGirlfriend
{
    static void Main()
    {
        int perfectCount = 0;

        while (true)
        {
            string line = Console.ReadLine();

            if (line == "Enough dates!")
            {
                break;
            }
            else
            {
                string[] split = line.Split('\\');

                int dayNumber = GetDayNumberFromWord(split[0]);
                long sumOfTelNumber = GetTelefonNumberSum(split[1]);
                int braSum = GetTheSumFromBraSize(split[2]);
                int numberFromName = GetTheNumberFromGirlsName(split[3]);

                long result = (dayNumber + sumOfTelNumber + braSum) - numberFromName;

                if (result >= 6000)
                {
                    Console.WriteLine("{0} is perfect for you.", split[3]);
                    perfectCount++;
                }
                else
                {
                    Console.WriteLine("Keep searching, {0} is not for you.", split[3]);
                }
            }
        }

        Console.WriteLine(perfectCount);
    }

    static int GetTheNumberFromGirlsName(string p)
    {
        int firstLetter = p[0];
        int number = firstLetter * p.Length;

        return number;
    }

    static int GetTheSumFromBraSize(string p)
    {
        int letter = p[p.Length - 1];
        int sum = int.Parse(p.Substring(0, p.Length - 1)) * letter;
        return sum;
    }

    static long GetTelefonNumberSum(string p)
    {
        long temp = long.Parse(p);
        long sum = 0;

        while (temp > 0)
        {
            long digit = temp % 10;
            sum += digit;
            temp /= 10;
        }

        return sum;
    }

    static int GetDayNumberFromWord(string p)
    {
        int day = 0;

        switch (p)
        {
            case "Monday": day = 1; break;
            case "Tuesday": day = 2; break;
            case "Wednesday": day = 3; break;
            case "Thursday": day = 4; break;
            case "Friday": day = 5; break;
            case "Saturday": day = 6; break;
            case "Sunday": day = 7; break;
        }

        return day;
    }
}