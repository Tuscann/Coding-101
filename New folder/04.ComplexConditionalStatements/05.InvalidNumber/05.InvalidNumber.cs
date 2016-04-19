using System;
class Program
{
    static void Main()
    {
        var number = double.Parse(Console.ReadLine());
        if ((number >= 100 && number <= 200) || (number == 0)) { Console.WriteLine(""); }
        else { Console.WriteLine("invalid"); }
    }
}

