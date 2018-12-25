using System;

class Programs
{
    static void Main()
    {
        int computersCount = int.Parse(Console.ReadLine());
        double totalSales = 0;
        double totalRating = 0;

        for (int counter = 0; counter < computersCount; counter++)
        {
            int number = int.Parse(Console.ReadLine());
            int rating = number % 10;
            int sales = number / 10;
            totalRating += rating;

            if (rating == 3)
                totalSales += sales * 0.5;
            else if (rating == 4)
                totalSales += sales * 0.7;
            else if (rating == 5)
                totalSales += sales * 0.85;
            else if (rating == 6)
                totalSales += sales;
        }

        Console.WriteLine("{0:F2}", totalSales);
        Console.WriteLine("{0:F2}", totalRating / computersCount);
    }
}