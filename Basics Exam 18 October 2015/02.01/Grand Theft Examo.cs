using System;
class Problem2
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            ulong counterSlapped = 0;    ulong totalSlapped = 0;
            ulong sumBeers = 0;          ulong counterEscaped = 0;
        
        for (int i = 0; i < n; i++)
            {
                ulong thieves = ulong.Parse(Console.ReadLine());
                ulong beers = ulong.Parse(Console.ReadLine());
            
                while (counterSlapped < 5 && thieves > 0)
                {counterSlapped++;
                thieves--;}
                
                counterEscaped += thieves;
                sumBeers += beers;
                totalSlapped += counterSlapped;

                counterSlapped = 0;
            }
            Console.WriteLine("{0} thieves slapped.", totalSlapped);
            Console.WriteLine("{0} thieves escaped.", counterEscaped);
            Console.WriteLine("{0} packs, {1} bottles.", sumBeers / 6, sumBeers % 6);

        }
    }
