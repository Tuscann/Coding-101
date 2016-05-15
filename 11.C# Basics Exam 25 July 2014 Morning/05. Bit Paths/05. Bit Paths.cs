using System;
public class BitPaths
{
    public static void Main()
    {
        int[,] grid = new int[8, 4];
        int num = int.Parse(Console.ReadLine());
        for (int i = 0; i < num; i++)
        {
            ProcessPath(grid, Console.ReadLine());
        }
        int sum = 0;
        for (int i = 0; i < grid.GetLength(0); i++)
        {
            var bits = new int[] { grid[i, 0], grid[i, 1], grid[i, 2], grid[i, 3] };
            string str = string.Concat(bits);
            sum = sum + Convert.ToInt32(str, 2);
        }
        Console.WriteLine(Convert.ToString(sum, 2));
        Console.WriteLine(sum.ToString("X"));
    }
    private static void ProcessPath(int[,] grid, string path)
    {
        string[] pathElements = path.Split(new char[] { ',' });
        int num = int.Parse(pathElements[0]);
        grid[0, num] = grid[0, num] ^ 1;
        for (int i = 1; i < grid.GetLength(0); i++)
        {
            num = num + int.Parse(pathElements[i]);
            grid[i, num] = grid[i, num] ^ 1;
        }
    }
}