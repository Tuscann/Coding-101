using System;
class Program
{
    static void Main()
    {
        int x1 = int.Parse(Console.ReadLine());
        int y1 = int.Parse(Console.ReadLine());
        int x2 = int.Parse(Console.ReadLine());
        int y2 = int.Parse(Console.ReadLine());
        int x3 = int.Parse(Console.ReadLine());
        int y3 = int.Parse(Console.ReadLine());
        
        int a = Math.Abs(x2 - x3);
        //Console.WriteLine(a);
        int h = Math.Abs(y1 - y3);
        //Console.WriteLine(h);

        Console.WriteLine("{0:0.0}",(a*h)/2.0);
    }
}

