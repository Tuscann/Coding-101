using System;
class PaintBall
{
    static void Main()
    {

        int[,] matrix = new int[10, 10];
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                matrix[i, j] = 1;
            }
        }

        string shot = Console.ReadLine();
        int numberOfShot = 1; // I need this to keep track of the white and black paints.

        while (shot != "End")
        {
            string[] shotString = shot.Split(' ');
            int[] shotImpact = new int[3];
            for (int i = 0; i < 3; i++)
            {
                shotImpact[i] = int.Parse(shotString[i]); // converting the numbers to int			 
            }

            int lowRow = GettingTheLowRow(shotImpact[0], shotImpact[2]); // getting the low row and check if it gets outside the array.
            int highRow = GettingTheHighRow(shotImpact[0], shotImpact[2]); // getting the high row and check if it gets outside the array.
            int lowColon = GettingTheLowColon(shotImpact[1], shotImpact[2]); // same but for colon
            int highColon = GettingTheHighColon(shotImpact[1], shotImpact[2]);

            if (numberOfShot % 2 == 1) // painting black zeros
            {
                for (int i = lowRow; i <= highRow; i++)
                {
                    for (int j = lowColon; j <= highColon; j++)
                    {
                        matrix[i, j] = 0;
                    }
                }
            }
            else if (numberOfShot % 2 == 0) // painting white ones
            {
                for (int i = lowRow; i <= highRow; i++)
                {
                    for (int j = lowColon; j <= highColon; j++)
                    {
                        matrix[i, j] = 1;
                    }
                }
            }

            numberOfShot++; // keeping track of shots
            shot = Console.ReadLine(); // next shot
        }

        long result = 0;
        string rowBinary = "";

        for (int row = 0; row < 10; row++)
        {
            for (int col = 9; col >= 0; col--)
            {
                rowBinary += matrix[row, col];
            }
            result += Convert.ToInt64(rowBinary, 2);
            rowBinary = "";
        }
        Console.WriteLine(result);
    }

    private static int GettingTheLowColon(int col, int radius)
    {
        if (col - radius < 0)
        {
            col = 0;
        }
        else
        {
            col -= radius;
        }
        return col;
    }
    private static int GettingTheHighColon(int col, int radius)
    {
        if (col + radius > 9)
        {
            col = 9;
        }
        else
        {
            col += radius;
        }
        return col;
    }
    private static int GettingTheHighRow(int row, int radius)
    {
        if (row + radius > 9)
        {
            row = 9;
        }
        else
        {
            row += radius;
        }
        return row;
    }

    private static int GettingTheLowRow(int row, int radius)
    {
        if (row - radius < 0)
        {
            row = 0;
        }
        else
        {
            row -= radius;
        }
        return row;
    }
}
