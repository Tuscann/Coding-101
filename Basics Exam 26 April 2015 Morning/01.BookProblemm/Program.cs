using System;

class Program
{
    static void Main()
    {
        var bookPages = double.Parse(Console.ReadLine());
        var campaingDays = double.Parse(Console.ReadLine());
        var readPages = double.Parse(Console.ReadLine());

        var mounth = 30 - campaingDays;
        var totalMounthPages = mounth * readPages;
        var needTime = bookPages / totalMounthPages;
        var years = needTime / 12;
        var moreMounth = needTime % 12;


        if (mounth == 0 || readPages == 0)
        {
            Console.WriteLine("never");
        }
        else
        {
            Console.WriteLine("{0:0} years {1:0} months", years, Math.Ceiling(moreMounth));
        }
    }
}

