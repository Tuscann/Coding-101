using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            double counter10 = 0;
            double counter20 = 0;
            double counter30 = 0;
            double counter40 = 0;
            double counter50 = 0;
            double invalidNumber = 0;

            double print = 0.0;

            int countNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < countNumber; i++)
            {

                int current = int.Parse(Console.ReadLine());

                if (current <= 9 && current >= 0)
                {
                    print += 0.2* current;
                    counter10++;
                }
                else if (current <= 19 && current >= 10)
                {
                    print += 0.3 * current;
                    counter20++;
                }
                else if (current <= 29 && current >= 20)
                {
                    print += 0.4 * current;
                    counter30++;
                }
                else if (current <= 39 && current >= 30)
                {
                    print += 50;
                    counter40++;
                }
                else if (current <= 50 && current >= 40)
                {
                    print += 100;
                    counter50++;
                }
                else
                {
                    print /= 2;
                    invalidNumber++;
                }

            }
            Console.WriteLine("{0:F2}",print);
            Console.WriteLine("From 0 to 9: {0:F2}%",(counter10 / countNumber) * 100) ;
            Console.WriteLine("From 10 to 19: {0:F2}%", (counter20 / countNumber) * 100);
            Console.WriteLine("From 20 to 29: {0:F2}%", (counter30 / countNumber) * 100);
            Console.WriteLine("From 30 to 39: {0:F2}%", (counter40 / countNumber) * 100);
            Console.WriteLine("From 40 to 50: {0:F2}%", (counter50 / countNumber) * 100);
            Console.WriteLine("Invalid numbers: {0:F2}%", (invalidNumber / countNumber) * 100);
        }
    }
}
