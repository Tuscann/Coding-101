using System;
class Program
{
    static void Main()
    {
        string breed = Console.ReadLine();
        char gender = char.Parse(Console.ReadLine());
        double catYears = 0;
        bool check = false;

        switch (breed)
        {
            case "British Shorthair":
                if (gender == 'm')
                {
                    catYears = 13;
                }
                else if (gender == 'f')
                {
                    catYears = 14;
                }
                break;
            case "Siamese":
                if (gender == 'm')
                {
                    catYears = 15;
                }
                else if (gender == 'f')
                {
                    catYears = 16;
                }
                break;
            case "Persian":
                if (gender == 'm')
                {
                    catYears = 14;
                }
                else if (gender == 'f')
                {
                    catYears = 15;
                }
                break;
            case "Ragdoll":
                if (gender == 'm')
                {
                    catYears = 16;
                }
                else if (gender == 'f')
                {
                    catYears = 17;
                }
                break;
            case "American Shorthair":
                if (gender == 'm')
                {
                    catYears = 12;
                }
                else if (gender == 'f')
                {
                    catYears = 13;
                }
                break;
            case "Siberian":
                if (gender == 'm')
                {
                    catYears = 11;
                }
                else if (gender == 'f')
                {
                    catYears = 12;
                }
                break;
            default:
                Console.WriteLine($"{breed} is invalid cat!");
                check = true;
                break;
        }

        if (check == false)
        {
            double catMonths = catYears * 12/ 6;
            Console.WriteLine(catMonths + " cat months");
        }
    }
}