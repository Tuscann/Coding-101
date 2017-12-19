using System;
class Program
{
    static void Main() // 100/100
    {
        double capacity = double.Parse(Console.ReadLine());
        double totalsFans = double.Parse(Console.ReadLine());

        double a = 0;
        double b = 0;
        double v = 0;
        double g = 0;

        for (int i = 0; i < totalsFans; i++)
        {
            string letter = Console.ReadLine();

            if (letter == "A")
            {
                a++;
            }
            else if (letter == "B")
            {
                b++;
            }
            else if (letter == "V")
            {
                v++;
            }
            else if (letter == "G")
            {
                g++;
            }
        }
        Console.WriteLine("{0:f2}%", a / totalsFans * 100);
        Console.WriteLine("{0:f2}%", b / totalsFans * 100);
        Console.WriteLine("{0:f2}%", v / totalsFans * 100);
        Console.WriteLine("{0:f2}%", g / totalsFans * 100);
        Console.WriteLine("{0:f2}%", totalsFans / capacity* 100);
    }
}