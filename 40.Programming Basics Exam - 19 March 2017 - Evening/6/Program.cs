using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int controlNumber = int.Parse(Console.ReadLine());

            int sum = 0;
            int counter = 0;


            for (int i = 1; i <= m; i++)
            {
                for (int y = m; y >= 1; y--)
                {
                    counter++;
                    Console.WriteLine(i + " " + y);
                    sum += i * 2 + y * 3;
                    Console.WriteLine(sum);

                    if (sum < controlNumber)
                    {

                    }

                   
                }
            }

            Console.WriteLine(sum);
        }

    }
}
