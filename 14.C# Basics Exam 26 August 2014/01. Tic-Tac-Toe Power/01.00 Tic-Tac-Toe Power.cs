using System;
class Program
{
    static void Main()
    {
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        int value = int.Parse(Console.ReadLine());

        int index = y * 3 + x + 1;
        int trueValue = value + y * 3 + x;
        
        Console.WriteLine((ulong)Math.Pow(trueValue, index));
    }
}

