using System;
class Disk
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        int radius = int.Parse(Console.ReadLine());

        for (int row = 0; row < size; row++)
        {
            for (int col = 0; col < size; col++)
            {
                Console.Write("{0}", GetPoint(row, col, radius, size) ? '*' : '.');
            }
            Console.WriteLine();
        }
    }

    private static bool GetPoint(int row, int col, int radius, int size)
    {
        int pythagorean = (int)(Math.Pow(row - size / 2, 2) + Math.Pow(col - size / 2, 2));

        return pythagorean <= (int)Math.Pow(radius, 2) ? true : false;
    }
}
