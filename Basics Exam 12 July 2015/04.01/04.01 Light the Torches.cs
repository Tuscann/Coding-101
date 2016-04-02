using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class LightTheTorches
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string ld = Console.ReadLine();
        char[] rooms = new char[n];
        for (int i = 0, j = 0; i < n; i++)
        {
            rooms[i] = ld[j];
            j++;
            if (j >= ld.Length)
            {
                j = 0;
            }
        }
        int startPos = n / 2;
        string command = Console.ReadLine();
        while (command != "END")
        {
            string[] currCommand = command.Split();
            int move = int.Parse(currCommand[1]);

            if (currCommand[0] == "LEFT")
            {
                move = startPos - move - 1;
                if (move < 0)
                {
                    move = 0;
                }
                if (move != startPos)
                {
                    if (rooms[move] == 'L')
                    {
                        rooms[move] = 'D';
                    }
                    else
                    {
                        rooms[move] = 'L';
                    }
                }
            }
            if (currCommand[0] == "RIGHT")
            {
                move = startPos + move + 1;
                if (move >= rooms.Length)
                {
                    move = rooms.Length - 1;
                }
                if (move != startPos)
                {
                    if (rooms[move] == 'L')
                    {
                        rooms[move] = 'D';
                    }
                    else
                    {
                        rooms[move] = 'L';
                    }
                }
            }
            startPos = move;
            command = Console.ReadLine();
        }
        int count = 0;
        for (int i = 0; i < rooms.Length; i++)
        {
            if (rooms[i] == 'D')
            {
                count++;
            }
        }
        int prays = 'D' * count;

        Console.WriteLine(prays);
    }
}