using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaidTowel
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char symbol1 = char.Parse(Console.ReadLine());
            char symbol2 = char.Parse(Console.ReadLine());
            char dot = '.';
            char sharp = '#';
            if (symbol1 == dot && symbol2 == sharp)
            {
                for (int repeat = 0; repeat < 2; repeat++)
                {
                    Console.WriteLine("{0}{2}{1}{2}{0}", new string(dot, n), new string(dot, 2 * n - 1), sharp);
                    for (int row = 0; row < n - 1; row++)
                    {
                        Console.Write(new string(dot, n - 1 - row));
                        Console.Write(sharp);
                        Console.Write(new string(dot, 2 * row + 1));
                        Console.Write(sharp);
                        Console.Write(new string(dot, 2 * n - 3 - 2 * row));
                        Console.Write(sharp);
                        Console.Write(new string(dot, 2 * row + 1));
                        Console.Write(sharp);
                        Console.WriteLine(new string(dot, n - 1 - row));
                    }
                    Console.WriteLine("{1}{0}{1}{0}{1}", new string(dot, 2 * n - 1), sharp);

                    var leftSymbols = 1;
                    for (int row = 0; row < n - 1; row++)
                    {
                        Console.Write(new string(dot, leftSymbols + row));
                        Console.Write(sharp);
                        Console.Write(new string(dot, 2 * n - 3 - 2 * row));
                        Console.Write(sharp);
                        Console.Write(new string(dot, 2 * row + 1));
                        Console.Write(sharp);
                        Console.Write(new string(dot, 2 * n - 3 - 2 * row));
                        Console.Write(sharp);
                        Console.WriteLine(new string(dot, leftSymbols + row));
                    }
                }
                Console.WriteLine("{0}{2}{1}{2}{0}", new string(dot, n), new string(dot, 2 * n - 1), sharp);
            }
            else
            {
                for (int repeat = 0; repeat < 2; repeat++)
                {
                    Console.WriteLine("{0}{2}{1}{2}{0}", new string(sharp, n), new string(sharp, 2 * n - 1), dot);
                    for (int row = 0; row < n - 1; row++)
                    {
                        Console.Write(new string(sharp, n - 1 - row));
                        Console.Write(dot);
                        Console.Write(new string(sharp, 2 * row + 1));
                        Console.Write(dot);
                        Console.Write(new string(sharp, 2 * n - 3 - 2 * row));
                        Console.Write(dot);
                        Console.Write(new string(sharp, 2 * row + 1));
                        Console.Write(dot);
                        Console.WriteLine(new string(sharp, n - 1 - row));
                    }
                    Console.WriteLine("{1}{0}{1}{0}{1}", new string(sharp, 2 * n - 1), dot);

                    var leftSymbols = 1;
                    for (int row = 0; row < n - 1; row++)
                    {
                        Console.Write(new string(sharp, leftSymbols + row));
                        Console.Write(dot);
                        Console.Write(new string(sharp, 2 * n - 3 - 2 * row));
                        Console.Write(dot);
                        Console.Write(new string(sharp, 2 * row + 1));
                        Console.Write(dot);
                        Console.Write(new string(sharp, 2 * n - 3 - 2 * row));
                        Console.Write(dot);
                        Console.WriteLine(new string(sharp, leftSymbols + row));
                    }
                }
                Console.WriteLine("{0}{2}{1}{2}{0}", new string(sharp, n), new string(sharp, 2 * n - 1), dot);
            }
        }
    }
}