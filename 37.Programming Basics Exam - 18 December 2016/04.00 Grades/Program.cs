using System;
class MainClass
{
    public static void Main()
    {
        int numberOfStudents = int.Parse(Console.ReadLine());
        decimal grades = 0;
        double topStudents = 0.0;
        double five = 0.0;
        double four = 0.0;
        double failed = 0.0;
        decimal currentGrade = 0;

        for (int i = 0; i < numberOfStudents; i++)
        {
            currentGrade = decimal.Parse(Console.ReadLine());
            grades += currentGrade;
            if (currentGrade >= 5)
            {
                topStudents++;
            }
            if (currentGrade <= 4.99M && currentGrade >= 4.00M)
            {
                five++;
            }
            if (currentGrade <= 3.99M && currentGrade >= 3.00M)
            {
                four++;
            }
            if (currentGrade < 3.00M)
            {
                failed++;
            }

        }
        decimal averageGrade = grades / numberOfStudents;
        double topStudentPrc = topStudents * 100 / numberOfStudents;
        double fivePrc = (five / numberOfStudents) * 100;
        double fourPrc = four * 100 / numberOfStudents;
        double failedPrc = failed * 100 / numberOfStudents;
        
        Console.WriteLine("Top students: {0:f2}%", topStudentPrc);
        Console.WriteLine("Between 4.00 and 4.99: {0:f2}%", fivePrc);
        Console.WriteLine("Between 3.00 and 3.99: {0:f2}%", fourPrc);
        Console.WriteLine("Fail: {0:f2}%", failedPrc);
        Console.WriteLine("Average: {0:f2}", averageGrade);
    }
}