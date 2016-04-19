using System;
using System.Linq;

class Program
{
    static void Main()
    {
        //Gryffindor (if reminder = 0),
        //Slytherin(if 1), 
        //Ravenclaw(if 2)
        //Hufflepuff (if 3).

        int n = int.Parse(Console.ReadLine());

        int counterG = 0;
        int counterS = 0;
        int counterR = 0;
        int counterH = 0;

        for (int i = 0; i < n; i++)
        {
            string inputs = Console.ReadLine();

            string first = inputs.Substring(0, 1);
            string[] dad = inputs.Split();

            string secound = dad[1].Substring(0, 1);
            
            var sum = inputs.Select(p => Convert.ToInt32(p)).Sum() - 32;

            var ostatak = sum % 4;
            if (ostatak == 0)
            {
                Console.WriteLine("Gryffindor {0}{1}{2}", sum, first, secound);
                counterG++;
            }
            if (ostatak == 1)
            {
                Console.WriteLine("Slytherin {0}{1}{2}", sum, first, secound);
                counterS++;
            }
            if (ostatak == 2)
            {
                Console.WriteLine("Ravenclaw {0}{1}{2}", sum, first, secound);
                counterR++;
            }
            if (ostatak == 3)
            {
                Console.WriteLine("Hufflepuff {0}{1}{2}", sum, first, secound);
                counterH++;
            }

        }
        Console.WriteLine("\nGryffindor: {0}\nSlytherin: {1}\nRavenclaw: {2}\nHufflepuff: {3}",
            counterG, counterS, counterR, counterH);
    }
}
