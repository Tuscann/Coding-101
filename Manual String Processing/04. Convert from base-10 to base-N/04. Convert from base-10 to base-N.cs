using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Convert_from_base_10_to_base_N
{
    class Program
    {
        static void Main(string[] args)
        {

            string [] k = Console.ReadLine().Split().ToArray();

            int base1 = int.Parse(k[0]);
            int base2= int.Parse(k[1]);


            Console.WriteLine(Convert.ToInt32(base1,2));

        }
    }
}
