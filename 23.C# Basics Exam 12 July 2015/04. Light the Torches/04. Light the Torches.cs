using System;
using System.Linq;

class LightTheTorches
{
    static void Main()
    {
        int numberOfRooms = int.Parse(Console.ReadLine());
        string lightOrDark = Console.ReadLine();
        char[] basement = new char[numberOfRooms];
        int count = 0;
        for (int i = 0; i < basement.Length; i++)
        {
            basement[i] = lightOrDark[count];
            count++;
            if (count == lightOrDark.Length)
            {
                count = 0;
            }
        }
        string[] command = Console.ReadLine().Split(' ').ToArray();
        int curentPosition = numberOfRooms / 2;
        while (command[0] != "END")
        {
            if (command[0] == "RIGHT")
            {
                if (curentPosition != basement.Length - 1)
                {
                    if ((int.Parse(command[1]) + 2) + curentPosition < basement.Length)
                    {
                        curentPosition += (int.Parse(command[1]) + 1);
                        if (basement[curentPosition] == 'L')
                        {
                            basement[curentPosition] = 'D';
                        }
                        else if (basement[curentPosition] == 'D')
                        {
                            basement[curentPosition] = 'L';
                        }
                    }
                    else
                    {
                        curentPosition = numberOfRooms - 1;
                        if (basement[curentPosition] == 'L')
                        {
                            basement[curentPosition] = 'D';
                        }
                        else if (basement[curentPosition] == 'D')
                        {
                            basement[curentPosition] = 'L';
                        }
                    }
                }
            }
            else
            {
                if (curentPosition != 0)
                {
                    if (curentPosition - (int.Parse(command[1]) + 2) >= 0)
                    {
                        curentPosition -= (int.Parse(command[1]) + 1);
                        if (basement[curentPosition] == 'L')
                        {
                            basement[curentPosition] = 'D';
                        }
                        else if (basement[curentPosition] == 'D')
                        {
                            basement[curentPosition] = 'L';
                        }
                    }
                    else
                    {
                        curentPosition = 0;
                        if (basement[curentPosition] == 'L')
                        {
                            basement[curentPosition] = 'D';
                        }
                        else if (basement[curentPosition] == 'D')
                        {
                            basement[curentPosition] = 'L';
                        }
                    }
                }
            }
            command = Console.ReadLine().Split(' ').ToArray();
        }
        int prays = 0;
        for (int i = 0; i < basement.Length; i++)
        {
            if (basement[i] == 'D')
            {
                prays++;
            }
        }
        long print = prays * 68;
        Console.WriteLine(print);
    }
}