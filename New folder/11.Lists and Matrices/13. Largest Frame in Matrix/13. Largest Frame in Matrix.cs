using System;
using System.Collections.Generic;
using System.Linq;
public class Program
{
    public static void Main()
    {
        int[] matrixDimensions = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int rows = matrixDimensions[0];
        int cols = matrixDimensions[1];
        int[,] matrix = new int[rows, cols];
        FillInMatrix(matrix, rows, cols);

        // generate frames (top, left), (bottom, right): 0 <= left <= right <= cols && 0 <= top <= bottom <= rows
        List<string> equalSizedFrames = new List<string>(); // equal sized frames of max size
        int maxSizeFrame = rows * cols; // max size == size matrix
        bool foundFrame = false;
        while (!foundFrame)
        {
            for (int top = 0; top < rows; top++)
                for (int left = 0; left < cols; left++)
                    for (int bottom = rows - 1; bottom >= top; bottom--)
                        for (int right = cols - 1; right >= left; right--)
                        {
                            bool isMaxSize = IsRequiredSize(top, left, bottom, right, maxSizeFrame);
                            bool hasEqualCells = isEqualCellsFrame(top, left, bottom, right, matrix);
                            if (hasEqualCells && isMaxSize)
                            {
                                foundFrame = true;
                                AddCurrentFrameToList(top, left, bottom, right, equalSizedFrames);
                            }
                        }
            if (!foundFrame) maxSizeFrame--;
            else break;
        }
        PrintInAscendingOrder(equalSizedFrames);
    }
    static void FillInMatrix(int[,] matrix, int rows, int cols)
    {
        for (int row = 0; row < rows; row++)
        {
            int[] cells = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            for (int col = 0; col < cols; col++)
                matrix[row, col] = cells[col];
        }
    }
    static bool IsRequiredSize(int top, int left, int bottom, int right, int size)
    {
        int verticalLength = bottom - top + 1;
        int horizontalLength = right - left + 1;
        int areaFrame = horizontalLength * verticalLength;
        return areaFrame == size;
    }
    static void AddCurrentFrameToList(int top, int left, int bottom, int right, List<string> equalSizedFrames)
    {
        int verticalLength = bottom - top + 1;
        int horizontalLength = right - left + 1;
        equalSizedFrames.Add(string.Join("x", verticalLength, horizontalLength));
    }
    static bool isEqualCellsFrame(int top, int left, int bottom, int right, int[,] matrix)
    {
        int cell = matrix[top, left];
        for (int col = left; col <= right; col++)
            if (matrix[top, col] != cell || matrix[bottom, col] != cell)
                return false;
        for (int row = top; row <= bottom; row++)
            if (matrix[row, left] != cell || matrix[row, right] != cell)
                return false;
        return true;
    }
    static void PrintInAscendingOrder(List<string> list)
    {
        list.Sort();
        Console.Write(string.Join(", ", list));
    }
}