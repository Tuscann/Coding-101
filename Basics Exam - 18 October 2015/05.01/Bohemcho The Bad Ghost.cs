using System;
using System.Linq;
class Problem5
    {
        static void Main()
        {
            string initialState = Console.ReadLine();
            int counter = 0;
            ulong score = 0;

            while (initialState != "Stop, God damn it")
            {
                 ulong currentFloor = ulong.Parse(initialState);
            
                int[] currentRooms = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            
                for (int i = 0; i < currentRooms.Length; i++)
                {

                currentFloor = currentFloor ^ (1ul << currentRooms[i]);

                }

                for (int i = 0; i < 32; i++)
                {
                    ulong mask = (currentFloor >> i) & 1;

                    if (mask == 1)
                    {
                        counter++;
                    }
                }

                score += currentFloor;

                initialState = Console.ReadLine();
            }
            
            Console.WriteLine("Bohemcho left {0} lights on and his score is {1}", counter, score);
        }
    }
