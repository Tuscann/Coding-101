using System;
class Program
{
    static void Main()
    {
        double sum = 0;
        double points = 0;
        int count = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < count; i++)
        {
            int current = int.Parse(Console.ReadLine());
            int grade = current % 10;
            int curentPoints = current / 10;

            if (grade == 2) sum += 2;
            
            else if (grade == 3)
            {
                sum += 3;
                points += 0.5 * curentPoints;
            }
            else if (grade == 4)
            {
                sum += 4;
                points += 0.70 * curentPoints;
            }
            else if (grade == 5)
            {
                sum += 5;
                points += 0.85 * curentPoints;
            }
            else if (grade == 6)
            {
                sum += 6;
                points += curentPoints;
            }
        }
        Console.WriteLine("{0:f2}", points);
        Console.WriteLine("{0:f2}", sum / count);
    }
}