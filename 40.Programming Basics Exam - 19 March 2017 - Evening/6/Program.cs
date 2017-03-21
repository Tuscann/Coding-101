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

            double sum = 0;
            int counter = 0;

            for (int i = 1; i <= n; i++)
            {
                for (int y = m; y >= 1; y--)
                {
                    counter++;
                    sum += i * 2 + y * 3;

                    //Console.Write(i+""+y+"|");

                    if (sum >= controlNumber)
                    {
                        break;
                    }
                }
                if (sum >= controlNumber)
                {
                    break;
                }
            }
            Console.WriteLine("{0} moves", counter);
            if (sum >= controlNumber)
            {
                Console.WriteLine("Score: {0} >= {1}", sum, controlNumber);
            }
        }
    }
}
