using System;
using System.Linq;
class Program
{
    static void Main()
    {
        var blurAmount = int.Parse(Console.ReadLine());

        // MATRIX INFO
        var infoMatrix = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        var MatrixRows = infoMatrix[0];
        var MatrixCols = infoMatrix[1];
        var mainMatrix = new decimal[MatrixRows, MatrixCols];

        // FILL IN MATRIX
        for (int rows = 0; rows < MatrixRows; rows++)
        {
            var readLine = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            for (int cols = 0; cols < MatrixCols; cols++)
            {
                mainMatrix[rows, cols] = readLine[cols];
            }
        }
        // BLUR INFO
        var infoBlur = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        var blurRow = infoBlur[0];
        var blurCol = infoBlur[1];

        var blurStartRows = blurRow - 1;
        var blurEndRows = blurStartRows + 3;
        if (blurStartRows < 0) blurStartRows = 0;
        if (blurEndRows > MatrixRows) blurEndRows = MatrixRows;

        var blurStartCols = blurCol - 1;
        var blurEndCols = blurStartCols + 3;
        if (blurStartCols < 0) blurStartCols = 0;
        if (blurEndCols > MatrixCols) blurEndCols = MatrixCols;

        //ADDING BLUR

        for (int rows = blurStartRows; rows < blurEndRows; rows++)
        {
            for (int cols = blurStartCols; cols < blurEndCols; cols++)
            {
                mainMatrix[rows, cols] = mainMatrix[rows, cols] + blurAmount;
            }
        }
        
        //PRINT
        for (int rows = 0; rows < MatrixRows; rows++)
        {
            for (int cols = 0; cols < MatrixCols; cols++)
            {
                Console.Write(mainMatrix[rows, cols] + " ");
            }
            Console.WriteLine();
        }
    }
}
