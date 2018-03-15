using System;
class Program
{
    static void Main()
    {
        string gender = Console.ReadLine();
        int age = int.Parse(Console.ReadLine());
        int yearsWork = int.Parse(Console.ReadLine());

        int femaleretirment = 61;
        int femalestaj = 35;
        int maleRetirment = 64;
        int maleStaj = 38;
        
        if (gender  == "male")
        {
            if (age >= maleRetirment && yearsWork  >= maleStaj)
            {
                Console.WriteLine("Ready to retire at {0} and {1} years of experience!", age, yearsWork );
            }
            else if (age < maleRetirment && yearsWork  >= maleStaj)
            {
                Console.WriteLine("Worked enough, but not old enough. Years left to retirement: {0}.", maleRetirment - age);
            }
            else if (age >= maleRetirment && yearsWork  < maleStaj)
            {
                Console.WriteLine("Old enough, but haven't worked enough. Work experience left to retirement: {0}.", maleStaj - yearsWork );
            }
            else if (age < maleRetirment && yearsWork  < maleStaj)
            {
                Console.WriteLine("Too early. Years left to retirement: {0}. Work experience left to retirement: {1}.", maleRetirment - age, maleStaj - yearsWork );
            }
        }
        else if (gender  == "female")
        {
            if (age >= femaleretirment && yearsWork  >= femalestaj)
            {
                Console.WriteLine("Ready to retire at {0} and {1} years of experience!", age, yearsWork );
            }
            else if (age < femaleretirment && yearsWork  >= femalestaj)
            {
                Console.WriteLine("Worked enough, but not old enough. Years left to retirement: {0}.", femaleretirment - age);
            }
            else if (age >= femaleretirment && yearsWork  < femalestaj)
            {
                Console.WriteLine("Old enough, but haven't worked enough. Work experience left to retirement: {0}.", femalestaj - yearsWork );
            }
            else if (age < femaleretirment && yearsWork  < femalestaj)
            {
                Console.WriteLine("Too early. Years left to retirement: {0}. Work experience left to retirement: {1}.", femaleretirment - age, femalestaj - yearsWork );
            }
        }
        else
        {
            Console.WriteLine("Invalid input.");
        }
    }
}