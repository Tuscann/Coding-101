using System;
internal class TheExplorer
{
    private static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        Top(size);
        Bottom(size);
    }

    private static void Top(int size)
    {
        for (int i = 0; i <= size / 2; i++)
        {
            char[] x = new char[size];
            x[(size / 2) + i] = '*';
            x[(size / 2) - i] = '*';
            Console.WriteLine(new string(x).Replace((char)0, '-'));
        }
    }

    private static void Bottom(int size)
    {
        for (int i = (size / 2) - 1; i >= 0; i--)
        {
            char[] x = new char[size];
            x[(size / 2) + i] = '*';
            x[(size / 2) - i] = '*';
            Console.WriteLine(new string(x).Replace((char)0, '-'));
        }
    }
}