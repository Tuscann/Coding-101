using System;

class InsideOrOutside
{
    static void Main()
    {
        int height = int.Parse(Console.ReadLine());


        for (int i = 0; i < 5; i++)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            if (x < 0 || y < 0) { Console.WriteLine("outside"); }
            else if (y <= height && x <= height * 3) { Console.WriteLine("inside"); }
            else if (y <= height * 4 && y > height && x >= height && x <= height * 2) { Console.WriteLine("inside"); }
            else { Console.WriteLine("outside"); }
        }
    }
}
