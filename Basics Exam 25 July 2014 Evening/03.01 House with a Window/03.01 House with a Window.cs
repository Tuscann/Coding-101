using System;
public class HouseWithWindow
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int starsBefore = n - 1;
        int starsMiddle = 1;

        Console.WriteLine("{0}*{0}", new string('.', starsBefore));
        for (int i = 0; i < n - 1; i++)
        {
            starsBefore--;
            Console.WriteLine("{0}*{1}*{0}",
                new String('.', starsBefore), new String('.', starsMiddle));
            starsMiddle += 2;
        }
        Console.WriteLine(new string('*', 2 * n - 1));
        for (int i = 0; i < n / 4; i++)
        {
            Console.WriteLine("*{0}*", new string('.', n * 2 - 3));
        }
        int dotsBetweenWindows = n / 2;
        int windowsStars = n - 3;
        for (int i = 0; i < n / 2; i++)
        {
            Console.WriteLine("*{0}{1}{0}*",
                new string('.', dotsBetweenWindows), new string('*', windowsStars));
        }
        for (int i = 0; i < n / 4; i++)
        {
            Console.WriteLine("*{0}*", new string('.', n * 2 - 3));
        }
        Console.WriteLine(new string('*', 2 * n - 1));
    }
}