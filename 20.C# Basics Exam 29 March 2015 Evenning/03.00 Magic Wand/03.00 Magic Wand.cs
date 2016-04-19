using System;

class MagicWand
{
    static void Main()
    {
        int size = Int32.Parse(Console.ReadLine());
        int width = size * 3 + 1;

        string line = new String('.', (width / 2)) + "*" + new String('.', (width / 2));
        Console.WriteLine(line);

        for (int i = 1; i <= size / 2 + 1; i++)
        {
            line = new String('.', (width / 2) - i) + "*" + new String('.', (i * 2) - 1) + "*" + new String('.', (width / 2) - i);
            Console.WriteLine(line);
        }

        line = new String('*', size) + new String('.', (width - (size * 2)) + 1) + new String('*', size);
        Console.WriteLine(line);

        for (int i = 1; i <= size / 2; i++)
        {
            line = new String('.', i) + "*" + new String('.', width - (i * 2 + 1)) + "*" + new String('.', i);
            Console.WriteLine(line);
        }

        for (int i = 1; i <= size / 2; i++)
        {
            line = new String('.', size / 2 - i) + "*" + new String('.', (size / 2)) + "*" + new String('.', i - 1) + "*" + new String('.', size) + "*" + new String('.', i - 1) + "*" + new String('.', (size / 2)) + "*" + new String('.', size / 2 - i);
            Console.WriteLine(line);
        }

        line = new String('*', size / 2 + 1) + new String('.', size / 2) + "*" + new String('.', size) + "*" + new String('.', size / 2) + new String('*', size / 2 + 1);
        Console.WriteLine(line);

        for (int i = 0; i < size; i++)
        {
            line = new String('.', size) + "*" + new String('.', size) + "*" + new String('.', size);
            Console.WriteLine(line);
        }

        line = new String('.', size) + new String('*', size + 2) + new String('.', size);
        Console.WriteLine(line);
    }
}
