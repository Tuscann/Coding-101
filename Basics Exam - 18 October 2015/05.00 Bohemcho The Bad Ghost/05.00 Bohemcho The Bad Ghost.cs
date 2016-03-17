using System;
using System.Linq;

class BohemchoTheBadGhost
{
    static void Main()
    {
        string initialState = Console.ReadLine();

        long score = 0;
        int lightsOn = 0;

        while (initialState != "Stop, God damn it")
        {
            uint currentFloor = uint.Parse(initialState);

            int[] currentRooms = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < currentRooms.Length; i++)
            {
                currentFloor = currentFloor ^ (1U << currentRooms[i]);
            }

            for (int i = 0; i < 32; i++)
            {
                if (((currentFloor >> i) & 1) == 1)
                {
                    lightsOn++;
                }
            }
            score += currentFloor;

            initialState = Console.ReadLine();
        }

        Console.WriteLine("Bohemcho left {0} lights on and his score is {1}", lightsOn, score);
    }
}