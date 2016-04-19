using System;
class Program
{
    static void Main()
    {
        int startYear = int.Parse(Console.ReadLine());
        int endYear = int.Parse(Console.ReadLine());
        int magicWeight = int.Parse(Console.ReadLine());

        DateTime startDate = new DateTime(startYear, 1, 1);
        DateTime endDate = new DateTime(endYear, 12, 31);

        int count = 0;
        for (DateTime d = startDate; d <= endDate; d = d.AddDays(1))
        {
            int d1 = d.Day / 10;
            int d2 = d.Day % 10;
            int d3 = d.Month / 10;
            int d4 = d.Month % 10;
            int d5 = (d.Year / 1000) % 10;
            int d6 = (d.Year / 100) % 10;
            int d7 = (d.Year / 10) % 10;
            int d8 = (d.Year / 1) % 10;
            int[] digits = { d1, d2, d3, d4, d5, d6, d7, d8 };
            int weight = 0;
            for (int first = 0; first < digits.Length; first++)
            {
                for (int second = first + 1; second < digits.Length; second++)
                {
                    weight = weight + (digits[first] * digits[second]);
                }
            }
            //Console.WriteLine("{0:d2}-{1:d2}-{2:d2} weight={3}", d.Day, d.Month, d.Year, weight);
            if (weight == magicWeight)
            {
                Console.WriteLine("{0:d2}-{1:d2}-{2:d2}", d.Day, d.Month, d.Year);
                count++;
            }
        }
        if (count == 0)
        {
            Console.WriteLine("No");
        }
    }
}

