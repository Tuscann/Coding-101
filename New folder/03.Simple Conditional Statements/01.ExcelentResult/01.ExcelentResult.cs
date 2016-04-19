using System;
class Program
{
    static void Main()
    {
        var grade = double.Parse(Console.ReadLine());

        if (grade >= 5.50 && grade <= 6.00)
        {
            Console.WriteLine("Excellent!");
        }
    }
}

