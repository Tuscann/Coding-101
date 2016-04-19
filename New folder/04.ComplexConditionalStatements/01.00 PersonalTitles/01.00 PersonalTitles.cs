using System;

class Program
{
    static void Main()
    {
        var number = double.Parse(Console.ReadLine());
        var gender = Console.ReadLine().ToLower();

        if (gender == "m")
        {
            if (number >= 16) { Console.WriteLine("Mr."); }
            else if (number < 16) { Console.WriteLine("Master"); }
        }
        else if (gender == "f")
        {
            if (number >= 16) { Console.WriteLine("Ms."); }
            else if (number < 16) { Console.WriteLine("Miss"); }
        }
    }
}

