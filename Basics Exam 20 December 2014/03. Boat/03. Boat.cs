using System;

class Program
{
    static void Main()
    {

        int number = int.Parse(Console.ReadLine());

        //draw sail
        int sailCurrentW = 1;
        bool middlePointReached = false;

        for (int c = 0; c < number; c++)
        {
            Console.WriteLine("{0}{1}{2}", new string('.', number - sailCurrentW), new string('*', sailCurrentW), new string('.', number));
            if (sailCurrentW >= number)
            {
                middlePointReached = true;
            }
            if (middlePointReached)
            {
                sailCurrentW = sailCurrentW - 2;
            }
            else
            {
                sailCurrentW = sailCurrentW + 2;
            }


        }
        int dots = 0;   //draw boat
        int boatHight = number / 2;
        int boatWight = 2 * number;

        for (int row = 1; row <= boatHight; row++)
        {
            Console.WriteLine("{0}{1}{0}", new string('.', dots), new string('*', boatWight));
            boatWight = boatWight - 2;
            dots = dots + 1;

        }
    }
}

