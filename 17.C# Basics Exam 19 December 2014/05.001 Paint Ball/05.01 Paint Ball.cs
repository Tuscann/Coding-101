/* Problem 10.	* Paint Ball
You are given a painting canvas of size 10 x 10, divided into 100 cells. Initially, the canvas is white 
 * (all cells have a value of 1). You shoot black and white paint balls with different sizes at the canvas. 
 * White is represented by 1s and black is represented by 0s. You alternate between black and white paint after each shot; 
 * the first shot is always with black paint (0s), the second is white (1s), the third is black again and so on. 
 * You will be given each shot's impact row and column coordinates as well as the ball's radius. 
 * The impact area is a square, its center is the impact cell; all cells in the impact area change values to either 0 or 1, 
 * depending on the color of the paint.
After you run out of ammo (when you receive the string "End" from the console) the canvas will be some combination of 1s and 0s. 
 * Each row of the canvas represents a binary integer number. Your task is to find the sum of the 10 numbers and print it to the console. 
 * An example where a single shot with parameters "4 5 2" was fired is shown below. The impact cell is shaded black, 
 * the splashed cells in the impact area are shaded grey.
Input
The input data is read from the console. 
•	It consists of a random number of lines. The input ends with the string "End".
•	Each line will hold three numbers – the row and column of the cell where the ball lands and the radius of the ball, 
 * all separated from each other by a single space.
The input data will always be valid and in the format described. There is no need to check it explicitly.
Output
The output data must be printed on the console.
•	On the only output line you must print the sum of the 10 rows of the canvas in decimal format.
Constraints
•	The number of shots will be in the range [1…25].
•	The rows and columns are integer numbers in the range [0…9].
•	The radius of the ball will be an integer between 0 (single cell) and 10 (large splash area damage).
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

class PaintBall
{
    static void Main()
    {
        int[,] canvas = new int[10, 10];

        for (int row = 0; row < 10; row++)
        {
            for (int col = 0; col < 10; col++)
            {
                canvas[row, col] = 1;
            }
        }

        // reading first command
        string input = Console.ReadLine();
        int counter = 1;
        // implementing the commands
        // and reading the next commands if any
        while (input != "End")
        {
            int[] commands = input.Split(' ').Select(int.Parse).ToArray();
            int R = commands[0];
            int C = commands[1];
            int radius = commands[2];
            int splashStartR = R - radius;
            int splashEndR = R + radius;
            int splashStartC = C - radius;
            int splashEndC = C + radius;
            if (splashEndR > 9) splashEndR = 9;
            if (splashStartR < 0) splashStartR = 0;
            if (splashEndC > 9) splashEndC = 9;
            if (splashStartC < 0) splashStartC = 0;

            for (int row = splashStartR; row <= splashEndR; row++)
            {
                for (int col = splashStartC; col <= splashEndC; col++)
                {
                    if (counter % 2 != 0)
                    {
                        canvas[row, col] |= 1;
                        canvas[row, col] ^= 1;
                    }
                    else
                    {
                        canvas[row, col] |= 1;
                        canvas[row, col] &= 1;
                    }
                }
            }
            counter++;

            input = Console.ReadLine();
        }
        List<string> binaries = new List<string>();
        StringBuilder X = new StringBuilder();
        for (int row = 0; row < 10; row++)
        {
            for (int col = 9; col >= 0; col--)
            {
                X.Append(canvas[row, col]);
            }
            binaries.Add(X.ToString());
            X.Clear();
        }

        int[] numbers = new int[10];
        for (int i = 0; i < 10; i++)
        {
            numbers[i] = BinaryToDecimal(binaries[i]);
        }

        Console.WriteLine(numbers.Sum());
    }

    private static int BinaryToDecimal(string number)
    {
        int decNumber = 0;
        int index = 0;
        for (int i = number.Length - 1; i >= 0; i--)
        {
            decNumber += (int)(int.Parse(number[i].ToString()) * Math.Pow(2, index));
            index++;
        }

        return decNumber;
    }
}