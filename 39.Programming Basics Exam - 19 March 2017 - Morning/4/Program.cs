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
            int counter = int.Parse(Console.ReadLine());
            double budjet = double.Parse(Console.ReadLine());


            int counterJelev = 0;
            int counterRoYal = 0;
            int counterRoli = 0;
            int counterSino = 0;
            int counterTrofon = 0;
            int others = 0;


            for (int i = 0; i < counter; i++)
            {
                string current = Console.ReadLine();

                if (current == "Jelev")
                {
                    counterJelev++;
                }
                else if (current == "RoYaL")
                {
                    counterRoYal++;
                }
                else if (current == "Roli")
                {
                    counterRoli++;
                }
                else if (current == "Trofon")
                {
                    counterTrofon++;
                }
                else if (current == "Sino")
                {
                    counterSino++;
                }
                else
                {
                    others++;
                }
            }


            int az = counter - counterJelev - counterRoYal - counterRoli - counterTrofon - counterSino;


            Console.WriteLine("Jelev salary: {0:f2} lv",budjet/ counter* counterJelev);
            Console.WriteLine("RoYaL salary: {0:f2} lv", budjet / counter * counterRoYal);
            Console.WriteLine("Roli salary: {0:f2} lv", budjet / counter * counterRoli);
            Console.WriteLine("Trofon salary: {0:f2} lv", budjet / counter * counterTrofon);
            Console.WriteLine("Sino salary: {0:f2} lv", budjet / counter * counterSino);
            Console.WriteLine("Others salary: {0:f2} lv", budjet / counter*az);




        }
    }
}
