using System;
public class Star
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int height = (n * 2 - (n / 2 - 1));
        int width = (2 * n + 1);

        for (int row = 0; row < height; row++)
        {
            for (int col = 0; col < width; col++)
            {
                if ((row >= 0 && row < n / 2) &&
                    (row + col == n || row - col == -n))
                {
                    Console.Write('*');
                }
                else if (row == n / 2)
                {
                    Console.Write("{0}{1}{0}", new string('*', n / 2 + 1), new string('.', n - 1));
                    break;
                }
                else if ((row >= n / 2 + 1 && row < n) &&
                    (row - col == n / 2 || row + col == (n * 3) - (n / 2)))
                {
                    Console.Write('*');
                }
                else if ((row >= n && row < height - 1) &&
                    (row + col == (n * 2) - (n / 2) ||
                    row - col == -n / 2 ||
                    row + col == n * 2 ||
                    row - col == 0))
                {
                    Console.Write('*');
                }
                else if (row == height - 1)
                {
                    Console.Write("{0}{1}{0}", new string('*', n / 2 + 1), new string('.', n - 1));
                    break;
                }
                else
                {
                    Console.Write('.');
                }
            }
            Console.WriteLine();
        }
    }
}