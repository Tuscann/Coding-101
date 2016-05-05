using System;
class Torches
{
    static int position1;
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string input = Console.ReadLine();
        string[] command = Console.ReadLine().Split();
        char[] rooms = new char[n];
        FillRooms(input, rooms);
        position1 = n / 2;

        while (command[0] != "END")
        {
            if (command[0] == "RIGHT")
            {
                if (position1 + int.Parse(command[1].ToString()) + 1 > rooms.Length - 1)
                {
                    int position2 = rooms.Length - 1;
                    if (position1 != position2)
                    {
                        position1 = rooms.Length - 1;
                        SwitchLights(rooms, position1);
                    }
                }
                else
                {
                    position1 = position1 + int.Parse(command[1].ToString()) + 1;
                    SwitchLights(rooms, position1);
                }
            }
            else if (command[0] == "LEFT")
            {
                if (position1 - int.Parse(command[1].ToString()) - 1 < 0)
                {
                    int position2 = 0;
                    if (position1 != position2)
                    {
                        position1 = 0;
                        SwitchLights(rooms, position1);
                    }
                }
                else
                {
                    position1 = position1 - int.Parse(command[1].ToString()) - 1;
                    SwitchLights(rooms, position1);
                }
            }
            command = Console.ReadLine().Split();
        }
        int darkCounter = 0;
        for (int i = 0; i < rooms.Length; i++)
        {
            if (rooms[i] == 'D')
            {
                darkCounter++;
            }
        }
        Console.WriteLine(darkCounter * (int)'D');
    }

    private static void FillRooms(string input, char[] rooms)
    {
        int counter = 0;
        for (int i = 0; i < rooms.Length; i++)
        {
            rooms[i] = input[counter % input.Length];
            counter++;
        }
    }

    private static void SwitchLights(char[] rooms, int position1)
    {
        if (rooms[position1] == 'L')
        {
            rooms[position1] = 'D';
        }
        else
        {
            rooms[position1] = 'L';
        }
    }
}