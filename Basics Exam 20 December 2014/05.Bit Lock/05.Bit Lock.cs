using System;

class BitLock
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        int[] lockRows = Array.ConvertAll(input, int.Parse);

        string command = Console.ReadLine();

        while (command != "end")
        {
            string[] orders = command.Split();

            if (orders[0] == "check")
            {
                int col = int.Parse(orders[1]);
                int count = 0;

                foreach (var row in lockRows)
                {
                    count += (row >> col) & 1;
                }

                Console.WriteLine(count);
            }
            else
            {
                int row = int.Parse(orders[0]);
                string direction = orders[1];
                int rotations = int.Parse(orders[2]) % 12;

                if (direction == "left")
                {
                    for (int i = 0; i < rotations; i++)
                    {
                        int leftmostBit = (lockRows[row] >> 11) & 1;
                        lockRows[row] &= ~(1 << 11);
                        lockRows[row] <<= 1;
                        lockRows[row] |= leftmostBit;
                    }
                }
                else if (direction == "right")
                {
                    for (int i = 0; i < rotations; i++)
                    {
                        int rightmostBit = lockRows[row] & 1;
                        lockRows[row] >>= 1;
                        lockRows[row] |= rightmostBit << 11;
                    }
                }

            }

            command = Console.ReadLine();
        }

        foreach (var row in lockRows)
        {
            Console.Write(row + " ");
        }
    }
}
