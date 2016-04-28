using System;
class Program
{
    static void Main()
    {
        int Number = int.Parse(Console.ReadLine());
        int Reverse = 0;
        while (Number > 0)
        {
            int remainder = Number % 10;
            Reverse = (Reverse * 10) + remainder;
            Number = Number / 10;
        }
        Console.WriteLine(Reverse);
    }
}

