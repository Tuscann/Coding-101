using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class KnightPath
{
    static void Main()
    {
        int n = 1;
        int[] arr = new int[8];
        arr[0] = 1;
        int pos = 0;
        int row = 0;
        for (int i = 0; i < 25; i++)
        {
            string command = Console.ReadLine();
            if (command == "stop")
            {
                break;
            }

            if (command == "left down")
            {
                pos += 2;
                row += 1;
                if (pos >= 0 && pos < 8 && row >= 0 && row < 8)
                {

                    n <<= 2;
                    arr[row] = arr[row] ^ n;
                }
                else
                {
                    pos -= 2;
                    row -= 1;
                }
            }
            if (command == "left up")
            {
                pos += 2;
                row -= 1;
                if (pos >= 0 && pos < 8 && row >= 0 && row < 8)
                {

                    n <<= 2;
                    arr[row] = arr[row] ^ n;
                }
                else
                {
                    pos -= 2;
                    row += 1;
                }
            }
            if (command == "right up")
            {
                pos -= 2;
                row -= 1;
                if (pos >= 0 && pos < 8 && row >= 0 && row < 8)
                {

                    n >>= 2;
                    arr[row] = arr[row] ^ n;
                }
                else
                {
                    pos += 2;
                    row += 1;
                }
            }
            if (command == "right down")
            {
                pos -= 2;
                row += 1;
                if (pos >= 0 && pos < 8 && row >= 0 && row < 8)
                {

                    n >>= 2;
                    arr[row] = arr[row] ^ n;
                }
                else
                {
                    pos += 2;
                    row -= 1;
                }
            }
            if (command == "up left")
            {
                pos += 1;
                row -= 2;
                if (pos >= 0 && pos < 8 && row >= 0 && row < 8)
                {

                    n <<= 1;
                    arr[row] = arr[row] ^ n;
                }
                else
                {
                    pos -= 1;
                    row += 2;
                }
            }
            if (command == "down left")
            {
                pos += 1;
                row += 2;
                if (pos >= 0 && pos < 8 && row >= 0 && row < 8)
                {

                    n <<= 1;
                    arr[row] = arr[row] ^ n;
                }
                else
                {
                    pos -= 1;
                    row -= 2;
                }
            }
            if (command == "up right")
            {
                pos -= 1;
                row -= 2;
                if (pos >= 0 && pos < 8 && row >= 0 && row < 8)
                {

                    n >>= 1;
                    arr[row] = arr[row] ^ n;
                }
                else
                {
                    pos += 1;
                    row += 2;
                }
            }
            if (command == "down right")
            {
                pos -= 1;
                row += 2;
                if (pos >= 0 && pos < 8 && row >= 0 && row < 8)
                {

                    n >>= 1;
                    arr[row] = arr[row] ^ n;
                }
                else
                {
                    pos += 1;
                    row -= 2;
                }
            }
        }
        if (Array.TrueForAll(arr, y => y == 0))
        {
            Console.WriteLine("[Board is empty]");
        }
        else
        {
            for (int i = 0; i < 8; i++)
            {
                if (arr[i] != 0)
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }
    }
}
