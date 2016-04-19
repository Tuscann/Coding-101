using System;

class Program
{
    static void Main()
    {
        
        var number = int.Parse(Console.ReadLine());
        for (int i = 0; i < number; i++)
        {
            Console.WriteLine(new string('*', number));
        }
    }
}

