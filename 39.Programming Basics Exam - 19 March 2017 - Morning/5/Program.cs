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

            int n = int.Parse(Console.ReadLine());

            int height = 2 * n + 1;

            Console.WriteLine("{0}", new string('*', height));
            Console.WriteLine(".*{0}*.", new string(' ', height - 4));

            int x = 2;
            int z = (2 * n + 1) - 6;
            for (int i = 0; i < (2 * n) / 2 - 2; i++)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('.', x), new string('@', z));
                x += 1;
                z -= 2;
            }
            Console.WriteLine("{0}*{0}", new string('.', (2 * n) / 2));


            x = (2 * n) / 2;
            z = 0;

            for (int i = 0; i < (2 * n) / 2 - 2; i++)
            {
                x--;
                Console.WriteLine("{0}*{1}@{1}*{0}", new string('.', x), new string(' ', z));
                z++;
            }

            Console.WriteLine(".*{0}*.", new string('@', 2 * n + 1 - 4));
            Console.WriteLine("{0}", new string('*', height));

        }
    }
}
