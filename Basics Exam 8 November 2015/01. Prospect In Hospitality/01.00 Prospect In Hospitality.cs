using System;

internal class Problem01ProspectInHospitality
{
    private static void Main()
    {
        decimal buildersSalary = 1500.04m;
        decimal receptionistsSalary = 2102.10m;
        decimal chambermaidsSalary = 1465.46m;
        decimal techniciansSalary = 2053.33m;
        decimal othersSalary = 3010.98m;


        uint b = uint.Parse(Console.ReadLine());
        buildersSalary *= b;

        uint r = uint.Parse(Console.ReadLine());
        receptionistsSalary *= r;

        uint c = uint.Parse(Console.ReadLine());
        chambermaidsSalary *= c;

        uint t = uint.Parse(Console.ReadLine());
        techniciansSalary *= t;

        uint o = uint.Parse(Console.ReadLine());
        othersSalary *= o;

        decimal n = decimal.Parse(Console.ReadLine());
        decimal nSalary = decimal.Parse(Console.ReadLine());
        nSalary *= n;

        decimal s = decimal.Parse(Console.ReadLine());
        decimal m = decimal.Parse(Console.ReadLine());

        decimal totalExpences =
            buildersSalary + receptionistsSalary +
            chambermaidsSalary + techniciansSalary +
            othersSalary + nSalary + s;

        Console.WriteLine("The amount is: {0:f2} lv.", totalExpences);
        Console.WriteLine("{0} \\ {1}: {2:f2} lv.", totalExpences <= m ? "YES" : "NO", totalExpences <= m ? "Left" : "Need more",
            Math.Abs(m - totalExpences));

    }
}