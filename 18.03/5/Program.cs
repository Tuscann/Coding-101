using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            //int h = 4 * n - 2;
            //int sh = 12 * n - 5;

            int x = 0;
            int z = (12 * n - 6) / 2;

            for (int i = 0; i < (4 * n - 2) / 2 + 1; i++)
            {
                Console.WriteLine("{0}{1}#{1}{0}", new string('.', z), new string('#', x));
                z -= 3;
                x += 3;
            }

            z = 2;
            x = ((12 * n - 5) - 6) / 2;
            for (int i = 0; i < (4 * n - 2) / 2 - n; i++)
            {
                Console.WriteLine("|{0}{1}#{1}{2}", new string('.', z), new string('#', x), new string('.', z + 1));
                z += 3;
                x -= 3;
            }
            for (int i = 0; i < n - 2; i++)
            {
                Console.WriteLine("|{0}{1}#{1}{2}", new string('.', z - 3), new string('#', x + 3), new string('.', z + 1 - 3));
            }
            Console.WriteLine("@{0}{1}#{1}{2}", new string('.', z - 3), new string('#', x + 3), new string('.', z + 1 - 3));






        }
    }
}
