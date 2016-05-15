using System;
class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] words = Console.ReadLine().Split(' ');

        foreach (var win in words)
        {
            input =input.Replace(win, new string('*', win.Length));
        }
        Console.WriteLine("{0}", input);
    }
}