using System;
public class ConsoleGraphics
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        int lineLenght = 2 * size;

        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine(new string('*', lineLenght));
        }
        for (int i = 0; i < size - 1; i++)
        {
            Console.Write(new string('*', (size + 1) / 2));
            Console.Write(new string(' ', size - 1));
            Console.Write(new string('*', (size + 1) / 2));
            Console.WriteLine();
        }
        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine(new string('~', lineLenght));
        }
    }
}