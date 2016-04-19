using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        double radius = double.Parse(Console.ReadLine());

        Console.WriteLine("{0:f12}",Math.PI*radius*radius);
    }
}

