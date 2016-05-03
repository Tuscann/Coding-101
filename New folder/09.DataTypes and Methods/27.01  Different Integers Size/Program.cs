using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27._01__Different_Integers_Size
{
    class Program
    {
        static void Main()
        {


            
            try
            {
                int n = Int32.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("{0} is not an integer");
                
            }

        }
    }
}
