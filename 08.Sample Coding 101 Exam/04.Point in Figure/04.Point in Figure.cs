using System;
class Program
{
    static void Main()
    {
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        
        if (((x >= 4 && x <= 10) && (y >= -5 && y <= 3)) ||
                (x >= 2 && x <= 12) && (y >= -3 && y <= 1))
        {
            Console.WriteLine("in");
        }
        else{Console.WriteLine("out");}
    }
}


