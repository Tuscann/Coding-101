using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static void Main()
    {
        var number = int.Parse(Console.ReadLine());

        PrintFooter(number);
        EasyWay (number);
        PrintFooter(number);

    }
    private static void EasyWay(int number)
    {
        for (var i = 1; i < number; i++)
        {
            Console.Write('-');
            for (var j = 0; j <= number - 2; j++)
            {
                Console.Write(@"\/");
            }
            Console.Write('-');
            Console.WriteLine();
        }
    }
    private static void PrintFooter(int number)
    {
        Console.WriteLine("{0}", new string('-', 2 * number));
    }

    static void dasdas(int number)
    {
    }

}

