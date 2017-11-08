using System;
class Program
{
    static void Main()   // 100/100
    {
        decimal[] studioPrice =  { 50, 75.20m, 76 };
        decimal[] apartmentPrice = { 65, 68.70m, 77 };

        string month = Console.ReadLine();
        int nights = int.Parse(Console.ReadLine());
        int index = month == "June" || month == "September" ? 1 :
            (month == "July" || month == "August" ? 2 : 0);
        // Index 0 : May && October
        // Index 1 : June && September
        // Index 2 : July && August
        decimal studioDiscount = 1m;
        decimal apartmentDiscount = 1m;
        if (nights > 14)
        {
            apartmentDiscount = 0.90m;
            if (index == 0) studioDiscount = 0.70m;
            if (index == 1) studioDiscount = 0.80m;
        }
        else if (nights > 7 && index == 0)
        {
            studioDiscount = 0.95m;
        }
        apartmentPrice[index] = apartmentPrice[index] * apartmentDiscount;
        studioPrice[index] = studioPrice[index] * studioDiscount;
        Console.WriteLine("Apartment: {0:F2} lv.", nights * apartmentPrice[index]);
        Console.WriteLine("Studio: {0:F2} lv.", nights * studioPrice[index]);
    }
}