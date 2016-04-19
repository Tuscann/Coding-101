using System;
class Program
{
    static void Main()
    {

        string year = Console.ReadLine();
        int outOfHome = int.Parse(Console.ReadLine());
        int home = int.Parse(Console.ReadLine());

        int travels = outOfHome * 12;
        int family = home * 4;
        double normal = (12 - outOfHome - home) * 12 * 3.0/5;
        double total = travels + family + normal;

        if (year == "leap")
        {
            total = total * 1.05;
        }
        Console.WriteLine("{0}", Math.Floor(total));
    }
}

