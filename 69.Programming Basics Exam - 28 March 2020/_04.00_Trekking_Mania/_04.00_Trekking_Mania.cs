using System;

namespace _04._00_Trekking_Mania
{
    class Program
    {
        static void Main()
        {
            int countPeople = Int32.Parse(Console.ReadLine());

            int counter5 = 0;
            int counter12 = 0;
            int counter25 = 0;
            int counter40 = 0;
            int counter41 = 0;

            double total = 0;

            for (int i = 0; i < countPeople; i++)
            {
                int currentPeople = Int32.Parse(Console.ReadLine());
                total += currentPeople;

                if (currentPeople >= 41)
                {
                    counter41 += currentPeople;
                }
                else if (currentPeople >= 26)
                {
                    counter40 += currentPeople;
                }
                else if (currentPeople >= 13)
                {
                    counter25 += currentPeople;
                }
                else if (currentPeople >= 6)
                {
                    counter12 += currentPeople;
                }
                else
                {
                    counter5 += currentPeople;
                }
            }
            Console.WriteLine("{0:f2}%", counter5 / total * 100.0);
            Console.WriteLine("{0:f2}%", counter12 / total * 100.0);
            Console.WriteLine("{0:f2}%", counter25 / total * 100.0);
            Console.WriteLine("{0:f2}%", counter40 / total * 100.0);
            Console.WriteLine("{0:f2}%", counter41 / total * 100.0);
        }
    }
}
