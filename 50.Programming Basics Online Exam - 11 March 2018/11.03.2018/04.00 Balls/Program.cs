using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int after = 0;
        int white = 0;
        int orange = 0;
        int red = 0;
        int yellow = 0;
        int black = 0;
        int other = 0;

        for (int i = 0; i < n; i++)
        {
            string current = Console.ReadLine();

            if (current == "white")
            {
                after += 20;
                white++;
            }
            else if (current == "orange")
            {
                after += 10;
                orange++;
            }
            else if (current == "red")
            {
                after += 5;
                red++;
            }
            else if (current == "yellow")
            {
                after += 15;
                yellow++;
            }
            else if (current == "black")
            {
                after /= 2;
                black++;
            }
            else
            {
                other++;
            }
        }
        Console.WriteLine("Total points: " + after);
        Console.WriteLine("Points from red balls: " + red);
        Console.WriteLine("Points from orange balls: " + orange);
        Console.WriteLine("Points from yellow balls: " + yellow);
        Console.WriteLine("Points from white balls: " + white);
        Console.WriteLine("Other colors picked: " + other); 
        Console.WriteLine("Divides from black balls: " + black);
    }
}