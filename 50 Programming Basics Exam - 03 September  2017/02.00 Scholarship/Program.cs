using System;
class Program
{
    static void Main() // 100/100
    {
        double leva = double.Parse(Console.ReadLine());
        double averageGrade = double.Parse(Console.ReadLine());
        double minumSalary = double.Parse(Console.ReadLine());

        if (averageGrade <= 4.50)
        {
            Console.WriteLine("You cannot get a scholarship!");
        }
        else if (averageGrade > 4.50 && averageGrade < 5.50)
        {
            if (leva > minumSalary)
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
            else
            {
                Console.WriteLine("You get a Social scholarship {0} BGN", Math.Floor(0.35 * minumSalary));
            }
        }
        else if (averageGrade >= 5.50)
        {
            if (leva < minumSalary)
            {
                double exselentScolarship1 = 0;
                double exselentScolarship2 = 0;

                exselentScolarship1 = Math.Floor(averageGrade * 25);
                exselentScolarship2 = Math.Floor(0.35 * minumSalary);

                double scolarship = Math.Max(exselentScolarship1, exselentScolarship2);

                if (exselentScolarship1 == scolarship)
                {
                    Console.WriteLine("You get a scholarship for excellent results {0} BGN", scolarship);
                }
                else if (exselentScolarship2 == scolarship)
                {
                    Console.WriteLine("You get a Social scholarship {0} BGN", scolarship);
                }
            }
            else
            {
                double scolarship = Math.Floor(averageGrade * 25);
                Console.WriteLine("You get a scholarship for excellent results {0} BGN", scolarship);
            }
        }
    }
}