using System;
class Disks
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int r = int.Parse(Console.ReadLine());
        int center = n / 2;

        for (int x = 0; x < n; x++)
        {
            for (int y = 0; y < n; y++)
            {
                if (Math.Sqrt((x - center) * (x - center) + (y - center) * (y - center)) <= r)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(".");
                }

            }
            Console.WriteLine();
        }
    }
}