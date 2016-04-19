using System;
class Program
{
    static void Main()
    {
        for (var i = 1; i <= 10; i++)
        {
            Console.WriteLine(new string('*', i));
        }
    }
}

