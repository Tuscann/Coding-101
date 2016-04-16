using System;
public class TicTacToePower
{
    public static void Main()
    {
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        int startNumber = int.Parse(Console.ReadLine());

        int[,] matrix = new int[3, 3];
        int power = 1;
        long result = 0;

        for (int row = 0; row < 3; row++)
        {
            for (int col = 0; col < 3; col++, startNumber++, power++)
            {
                if (x == col && y == row)
                {
                    result = Convert.ToInt64(Math.Pow(startNumber, power));
                    Console.WriteLine(result);
                    return;
                }
            }
        }
    }
}