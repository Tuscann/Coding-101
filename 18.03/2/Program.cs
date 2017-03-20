using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main()
        {
            int needHours = int.Parse(Console.ReadLine());
            int countWorkers = int.Parse(Console.ReadLine());
            int workingDays = int.Parse(Console.ReadLine());

            int total = countWorkers * workingDays * 8;

            if (total >= needHours)
            {
                Console.WriteLine("{0} hours left", total - needHours);

            }
            else
            {
                Console.WriteLine("{0} overtime", needHours - total);
                Console.WriteLine("Penalties: {0}", (needHours - total) * workingDays);
            }

        }
    }
}
