using System;

class Program
{
    static void Main()
    {
        double weight = int.Parse(Console.ReadLine()) / 2.2;
        double height = int.Parse(Console.ReadLine()) * 2.54;

        int age = int.Parse(Console.ReadLine());
        char gender = char.Parse(Console.ReadLine());
        int workoutsPerWeek = int.Parse(Console.ReadLine());

        double dci = 1;
        if (workoutsPerWeek <= 0) { dci = 1.2; }
        else if (workoutsPerWeek >= 1 && workoutsPerWeek <= 3) { dci = 1.375; }
        else if (workoutsPerWeek >= 4 && workoutsPerWeek <= 6) { dci = 1.55; }
        else if (workoutsPerWeek >= 7 && workoutsPerWeek <= 9) { dci = 1.725; }
        else if (workoutsPerWeek > 9) { dci = 1.9; }


        
        if (gender == 'm')
        {
            Console.WriteLine("{0:f0}", Math.Floor((66.5 + 13.75 * weight + 5.003 * height - 6.755 * age) * dci));
        }
        else if (gender == 'f')
        {
             Console.WriteLine("{0:f0}", Math.Floor((655 + 9.563 * weight + 1.850 * height - 4.676 * age) * dci));
        }
    }
}

