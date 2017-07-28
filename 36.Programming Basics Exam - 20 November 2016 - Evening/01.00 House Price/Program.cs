using System;
class Program
{
    static void Main()
    {
        decimal smallRooms = decimal.Parse(Console.ReadLine());
        decimal kitchen = decimal.Parse(Console.ReadLine());
        decimal prize = decimal.Parse(Console.ReadLine());

        decimal total = (smallRooms + (smallRooms * (decimal)1.1) + (smallRooms * (decimal)1.1) * (decimal)1.1 + smallRooms / 2 + kitchen) * (decimal)1.05 * prize;

        Console.WriteLine("{0:f2}", total);
    }
}