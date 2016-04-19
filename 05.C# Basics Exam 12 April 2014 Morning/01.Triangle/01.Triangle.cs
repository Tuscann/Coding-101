using System;
class Program
{
    static void Main()
    {
        double ax = double.Parse(Console.ReadLine());
        int ay = int.Parse(Console.ReadLine());
        double bx = double.Parse(Console.ReadLine());
        int by = int.Parse(Console.ReadLine());
        int cx = int.Parse(Console.ReadLine());
        int cy = int.Parse(Console.ReadLine());
        
        double ab = Math.Sqrt(Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2));
        double bc = Math.Sqrt(Math.Pow(cx - ax, 2) + Math.Pow(cy - ay, 2));
        double ac = Math.Sqrt(Math.Pow(bx - cx, 2) + Math.Pow(by - cy, 2));

        double p = (ab + bc + ac) / 2;
        double area = Math.Sqrt(p * (p - ab) * (p - bc) * (p - ac));
        
        if (ab + bc > ac && bc + ac > ab && ab + ac > bc)
        {
            Console.WriteLine("Yes\n{0:f2}", area);
        }
        else
        {
            Console.WriteLine("No\n{0:f2}", ab);
        }


    }
}

