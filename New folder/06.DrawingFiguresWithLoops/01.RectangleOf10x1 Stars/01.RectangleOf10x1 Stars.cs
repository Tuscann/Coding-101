using System;

class Program
{
    static void Main()
    {
        //var number = int.Parse(Console.ReadLine());
        var number = 10;


        for (int i = 0; i < number; i++)
        {
            Console.WriteLine(new string('*',number));
        }
    }
}

