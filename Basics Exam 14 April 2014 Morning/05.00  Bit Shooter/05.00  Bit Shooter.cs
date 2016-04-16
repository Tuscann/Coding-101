/* Problem 5 – Bit Shooter
We are given a bit field in the form of 64-bit integer number. We shoot it 3 times. Each shoot has a center and a size. 
 * The shoot damages size bits around the shoot center (makes these bits 0). Finally, the bit field is split into left side (bits 63 … 32) 
 * and right side (bits 31 … 0). Write a program that calculates how many bits survive (have value 1) 
 * after the shoots in the left side and in the right side of the bit field. The bits are numbered as traditionally in programming: 
 * from right to left from 0 to 63.
Input
The input data should be read from the console. It will consist of exactly 4 lines:
•	At the first line you will have a 64-bit integer, corresponding to the bit field.
•	At each of the next 3 lines we have 2 numbers: shoot center and shoot size – integers, split by a space.
The input data will always be valid and in the format described. There is no need to check it explicitly.
Output
The output should be printed on the console. It should consists of exactly 2 lines:
•	The first line print "left: …" and the number of alive bits in the left side.
•	The second line print "right: …" and the number of alive bits in the right side.
Constraints
•	The bit field will be a 64-bit integer in the range [0 … 18 446 744 073 709 551 615].
•	The values for the center will be integers will be integers in range [0 … 63].
•	The values for the size will be odd integers in range [1 … 99].
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class BitShooter
{
    static void Main()
    {
        // input
        ulong bitField = ulong.Parse(Console.ReadLine());

        string binary = Convert.ToString((long)bitField, 2).PadLeft(64, '0');

        List<int[]> targets = new List<int[]>();

        for (int i = 0; i < 3; i++)
        {
            targets.Add(Console.ReadLine().Split(' ').Select(int.Parse).ToArray());
        }

        // preparing the binary masks
        string number1B = new string('1', targets[0][1]);
        string number2B = new string('1', targets[1][1]);
        string number3B = new string('1', targets[2][1]);

        // in case you want to see the binary representations of the masks
        //Console.WriteLine(number1B);
        //Console.WriteLine(number2B);
        //Console.WriteLine(number3B);

        // converting them into decimal numbers
        ulong number1 = BinaryToDecimal(number1B);
        ulong number2 = BinaryToDecimal(number2B);
        ulong number3 = BinaryToDecimal(number3B);

        // in case you want to see the the mask calculation numbers
        //Console.WriteLine(number1);
        //Console.WriteLine(number2);
        //Console.WriteLine(number3);

        // calculating the shifting of the masks to their respective centers
        int shift1 = targets[0][0] - number1B.Length / 2;
        int shift2 = targets[1][0] - number2B.Length / 2;
        int shift3 = targets[2][0] - number3B.Length / 2;

        // shifting the masks 
        // taking care not to shift the masks in a wrong direction
        ulong mask1 = 0;
        ulong mask2 = 0;
        ulong mask3 = 0;
        if (shift1 > 0)
        {
            mask1 = number1 << shift1;
        }
        else
        {
            mask1 = number1 >> Math.Abs(shift1);
        }

        if (shift2 > 0)
        {
            mask2 = number2 << shift2;
        }
        else
        {
            mask2 = number2 >> Math.Abs(shift2);
        }
        if (shift3 > 0)
        {
            mask3 = number3 << shift3;
        }
        else
        {
            mask3 = number3 >> Math.Abs(shift3);
        }

        // in case you want to see the already shifted masks
        //Console.WriteLine(binary);
        //Console.WriteLine(Convert.ToString((long)mask1, 2).PadLeft(64, '0'));
        //Console.WriteLine(Convert.ToString((long)mask2, 2).PadLeft(64, '0'));
        //Console.WriteLine(Convert.ToString((long)mask3, 2).PadLeft(64, '0'));

        // applying the masks
        bitField = bitField | mask1;
        bitField = bitField ^ mask1;

        bitField = bitField | mask2;
        bitField = bitField ^ mask2;

        bitField = bitField | mask3;
        bitField = bitField ^ mask3;

        // converting the bitfield number into a already shooted at binary string
        binary = Convert.ToString((long)bitField, 2).PadLeft(64, '0');

        // in case you want to see the binary representation of the bitfield after all the 3 shootings
        //Console.WriteLine(binary);

        // dividing the binary bitfield string into a left and a right part
        string left = binary.Substring(0, 32);
        string right = binary.Substring(32);

        // in case you want to see the left and right parts of the bitfield
        //Console.WriteLine(left);
        //Console.WriteLine(right);

        // converting the left and right strings into decimal numbers
        // we use bigger data type in order to prevent negative decimal numbers
        long leftNum = Convert.ToInt64(left, 2);
        long rightNum = Convert.ToInt64(right, 2);

        // counting the bits of the decimal numbers
        int counterL = 0;
        int counterR = 0;
        long temp = 0;
        do
        {
            temp = leftNum & 1;
            if (temp == 1)
            {
                counterL++;
            }
            leftNum = leftNum >> 1;
        } while (leftNum != 0);

        do
        {
            temp = rightNum & 1;
            if (temp == 1)
            {
                counterR++;
            }
            rightNum = rightNum >> 1;
        } while (rightNum != 0);

        // printing the results
        Console.WriteLine("left: {0}", counterL);
        Console.WriteLine("right: {0}", counterR);
    }

    private static ulong BinaryToDecimal(string number)
    {
        ulong decNumber = 0;
        int index = 0;
        for (int i = number.Length - 1; i >= 0; i--)
        {
            decNumber += (ulong)(int.Parse(number[i].ToString()) * Math.Pow(2, index));
            index++;
        }

        return decNumber;
    }
}
