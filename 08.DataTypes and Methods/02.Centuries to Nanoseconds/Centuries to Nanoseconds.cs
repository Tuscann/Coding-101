using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Centuries_to_Nanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write Centuries:");

            ulong centuries = ulong.Parse(Console.ReadLine());
            ulong years = centuries * 100;
            ulong days = (ulong)(years * 365.2422);
            ulong hours = days * 24;
            ulong minutes = hours * 60;
            ulong seconds = minutes * 60;
            ulong milliseconds = seconds * 1000;
            ulong microseconds = milliseconds * 1000;
            decimal nanoseconds = (decimal)microseconds * 1000;

            Console.WriteLine("{0:f0} centuries {1:f0} years = {2:f0} days = {3:f0} hours = {4:f0} minutes = {5:f0} seconds = {6:f0} miliseconds = {7:f0} microseconds = {8:f0} nanoseconds", centuries, years, days, hours, minutes, seconds, milliseconds, microseconds, nanoseconds);


            //Console.WriteLine("{0:0}\n{1:f0}\n{2:f0}\n{3:f0}\n{4:f0}\n{5:f0}\n{6:f0}\n{7:f0}\n{8:f0}", centuries, years, days, hours, minutes, seconds, milliseconds, microseconds, nanoseconds);

        }
    }
}
