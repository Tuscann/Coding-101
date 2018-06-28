using System;
class Program
{
    static void Main()
    {
        int wight = int.Parse(Console.ReadLine());
        int longs = int.Parse(Console.ReadLine());
        int height = int.Parse(Console.ReadLine());

        int freespace = wight * longs * height;
        int total = 0;

        while (true)
        {
            string curent = Console.ReadLine();
            if (curent == "Done")
            {
                break;
            }
            total += int.Parse(curent);
            if (total > freespace)
            {
                Console.WriteLine("No more free space! You need {0} Cubic meters more.", total - freespace);
                return;
            }
        }
        Console.WriteLine("{0} Cubic meters left.", freespace - total);
    }
}