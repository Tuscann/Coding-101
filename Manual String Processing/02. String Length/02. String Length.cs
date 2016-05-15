using System;
class Program
{
    static void Main()
    {
        string input = Console.ReadLine();

        if (input.Length >= 20)
        {
            Console.WriteLine(input.Substring(0, 20));
        }
        else
        {
            Console.WriteLine("{0}{1}", input, new string('*', 20 - input.Length));
        }
    }
}