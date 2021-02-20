using System;

namespace _04._00_Balls
{
    class Program
    {
        static void Main()
        {
            int countBalls = int.Parse(Console.ReadLine());

            int countRedBalls = 0;
            int countOrangeBalls = 0;
            int countYellowBalls = 0;
            int countWhiteBalls = 0;
            int countBlackBalls = 0;
            int countOtherColorBalls = 0;

            int sum = 0;

            for (int i = 0; i < countBalls; i++)
            {
                string currentColors = Console.ReadLine();
                if (currentColors == "red")
                {
                    countRedBalls++;
                    sum += 5;
                }
                else if (currentColors == "orange")
                {
                    countOrangeBalls++;
                    sum += 10;
                }
                else if (currentColors == "yellow")
                {
                    countYellowBalls++;
                    sum += 15;
                }
                else if (currentColors == "white")
                {
                    countWhiteBalls++;
                    sum += 20;
                }
                else if (currentColors == "black")
                {
                    countBlackBalls++;
                    sum /= 2;
                }
                else
                {
                    countOtherColorBalls++;
                }
            }
            Console.WriteLine("Total points: {0}",sum);
            Console.WriteLine("Points from red balls: {0}",countRedBalls);
            Console.WriteLine("Points from orange balls: {0}",countOrangeBalls);
            Console.WriteLine("Points from yellow balls: {0}",countYellowBalls);
            Console.WriteLine("Points from white balls: {0}",countWhiteBalls);
            Console.WriteLine("Other colors picked: {0}",countOtherColorBalls);
            Console.WriteLine("Divides from black balls: {0}",countBlackBalls);
        }
    }
}