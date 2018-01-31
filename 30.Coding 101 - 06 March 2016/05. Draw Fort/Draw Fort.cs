using System;
class DrawJeans
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int colSize = n / 2;
        int midSize = 2*n-2*(n/2)-4;

        // Draw the first row
        Console.WriteLine("/{0}\\{1}/{0}\\",new string('^', colSize),new string('_', midSize));
        // Middle rows
        for (int row = 1; row <= n - 3; row++)
            Console.WriteLine("|{0}|", new string(' ', 2 * n - 2));
        // Draw the row before the last
        Console.WriteLine("|{0}{1}{0}|",new string(' ', colSize + 1),new string('_', midSize));
        // Draw the last row
        Console.WriteLine("\\{0}/{1}\\{0}/",new string('_', colSize),new string(' ', midSize));
    }
}
