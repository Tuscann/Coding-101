using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            int startInterval = int.Parse(Console.ReadLine());
            int endInterval = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());

            int counter = 0;

            for (int i = startInterval; i <= endInterval; i++)
            {
                for (int j = startInterval; j <= endInterval; j++)
                {
                    counter++;
                    if (i + j == magicNumber)
                    {
                        Console.Write("Combination N:{0} ", counter);
                        Console.WriteLine("({0} + {1} = {2})", i, j, magicNumber);
                        return;
                    }
                    if (i == endInterval && j == endInterval)
                    {
                        Console.WriteLine("{0} combinations - neither equals {1}", counter, magicNumber);
                    }



                }
            }
        }
    }
}
