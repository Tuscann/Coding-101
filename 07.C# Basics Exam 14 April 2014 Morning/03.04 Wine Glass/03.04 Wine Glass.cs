using System;
class WineGlass
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        
        int starsCount = N - 2;
        int dotsCount = 0;

        int counter = 0;
        do
        {
            string dots = new string('.', dotsCount);

            if (counter < N / 2)
            {
                string stars = new string('*', starsCount);
                Console.WriteLine("{0}\\{1}/{0}", dots, stars);
                starsCount -= 2;
                dotsCount++;
                counter++;
            }
            else if ((N < 12 && counter > N / 2 - 1 && counter < N - 1) ||
                (N >= 12 && counter > N / 2 - 1 && counter < N - 2))
            {
                dotsCount = N / 2 - 1;
                dots = new string('.', dotsCount);
                Console.WriteLine("{0}||{0}", dots);
                counter++;
            }
            else if ((N < 12 && counter > N - 2) || (N >= 12 && counter > N - 3))
            {
                Console.WriteLine(new string('-', N));
                counter++;
            }
        } while (counter < N);
    }
}