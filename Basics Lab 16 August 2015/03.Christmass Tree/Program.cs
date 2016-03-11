using System;
class Program
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            //http://pastebin.com/JXbHv48N
        }
        for (int i = 0; i < n; i++)
        {

        }
        for (int i = 0; i < n; i++)
        {
            //char xdsa ="'";
            Console.WriteLine("{0}{1}{2}{0}", new string('\'', n - 1), new string('\'', n - 1), new string('\'', n - 1));
        }
        Console.WriteLine(new string('_', 2 * n + 1));


    }
    //a| |a
}

