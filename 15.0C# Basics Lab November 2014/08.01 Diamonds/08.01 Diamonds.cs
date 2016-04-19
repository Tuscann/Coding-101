using System;
public class Diamonds
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());

        for (int row = 0; row < size; row++)
        {
            for (int col = 0; col < size; col++)
            {
                if (row + col == size / 2)
                {
                    Console.Write('*');
                }
                else if (row + col == (size - 1) + (size / 2))
                {
                    Console.Write('*');
                }
                else if (row - col == size / 2)
                {
                    Console.Write('*');
                }
                else if (row - col == -(size / 2))
                {
                    Console.Write('*');
                }
                else
                {
                    Console.Write('-');
                }
            }
            Console.WriteLine();
        }
    }
}