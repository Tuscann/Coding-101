using System;
class SaltAndPepper
{
    static void Main()
    {
        ulong number = ulong.Parse(Console.ReadLine());
        string command = Console.ReadLine();

        while (command != "end")
        {
            string[] commandElements = command.Split(' ');
            string action = commandElements[0];
            int step = int.Parse(commandElements[1]);

            if (action == "salt")
            {
                for (int i = 0; i <= 63; i += step)
                {
                    if (((number >> i) & 1) == 1)
                    {
                        ulong mask = ~((ulong)1 << i);
                        number = number & mask;
                    }
                }
            }
            else
            {
                for (var i = 0; i <= 63; i += step)
                {
                    if (((number >> i) & 1) == 0)
                    {
                        ulong mask = (ulong)1 << i;
                        number = number | mask;
                    }
                }
            }
            command = Console.ReadLine();
        }
        Console.WriteLine(number);
    }
}

