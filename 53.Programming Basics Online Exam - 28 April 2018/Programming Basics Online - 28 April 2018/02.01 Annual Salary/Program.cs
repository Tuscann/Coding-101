using System;
class Program
{
    static void Main()
    {
        int years = int.Parse(Console.ReadLine());
        string text = Console.ReadLine();

        double salary = 0;

        if (text == "C# Developer")
        {
            salary = 5400;
        }
        else if (text == "Java Developer")
        {
            salary = 5700;
        }
        else if (text == "Front-End Web Developer")
        {
            salary = 4100;
        }
        else if (text == "UX / UI Designer")
        {
            salary = 3100;
        }
        else if (text == "Game Designer")
        {
            salary = 3600;
        }

        if (years <= 5)
        {
            salary *= 1 - 0.658;
        }
        Console.WriteLine("Total earned money: {0:f2} BGN", salary * 12);
    }
}