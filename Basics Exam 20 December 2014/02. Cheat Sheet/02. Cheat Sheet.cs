using System;

class Program
{
    static void Main()
    {

        long rows = long.Parse(Console.ReadLine());
        long columns = long.Parse(Console.ReadLine());

        long rowNumber = long.Parse(Console.ReadLine());
        long colummNumber = long.Parse(Console.ReadLine());


        for (long row = rowNumber; row < rows + rowNumber; row++)
        {
            for (long col = colummNumber; col < columns + colummNumber; col++)
            {
                Console.Write(row * col);
                if (col < colummNumber + columns)
                {
                    Console.Write(' ');
                }
            }
            Console.WriteLine();
        }

    }
}

