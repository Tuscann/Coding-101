using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            //5-3  6-4  7-5
            int n = int.Parse(Console.ReadLine());

            int height = 4 * n + 4;
            int weight = 3 * n + 1;

            Console.WriteLine("+{0}+{1}", new string('~', n - 2), new string('.', weight - n));

            int x = 0;
            for (int i = 0; i < (height / 2) - 1; i++)
            {
                Console.WriteLine("|{0}\\{1}\\{2}", new string('.', x), new string('~', n - 2), new string('.', weight - 1 - x - n));
                x += 1;
            }

            x = 0;
            for (int i = 0; i < (height / 2) - 1; i++)
            {
                Console.WriteLine("{0}\\{1}|{2}|", new string('.', x), new string('.', weight - 1 - x - n),new string('~', n - 2));
                x += 1;
            }
            Console.WriteLine("{0}+{1}+", new string('.', weight - n), new string('~', n - 2));
        }
    }
}
