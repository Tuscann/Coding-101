using System;
using System.Numerics;

namespace CrossingSequences
{
    internal class CrossingSequences
    {
        private const int size = 1000000;

        public static bool GetTribonacci(BigInteger firstTribNum, BigInteger secondTribNum,
            BigInteger thirdTribNum, BigInteger spiralStart)
        {
            var tribonacci = firstTribNum + secondTribNum + thirdTribNum;
            if (firstTribNum > spiralStart)
            {
                return false;
            }
            if ((firstTribNum == spiralStart) && (firstTribNum <= size))
            {
                return true;
            }
            var a = secondTribNum;
            var b = thirdTribNum;
            var c = tribonacci;

            return GetTribonacci(a, b, c, spiralStart);
        }

        public static void Main()
        {
            var firstTribNum = int.Parse(Console.ReadLine());
            var secondTribNum = int.Parse(Console.ReadLine());
            var thirdTribNum = int.Parse(Console.ReadLine());

            var spiralStart = int.Parse(Console.ReadLine());
            var spiralStep = int.Parse(Console.ReadLine());
            var checkForEquals = false;

            var counter = 0;
            var step = spiralStep;

            for (var i = spiralStart; i <= size; i++)
            {
                checkForEquals = GetTribonacci(firstTribNum, secondTribNum, thirdTribNum, spiralStart);
                if (checkForEquals)
                {
                    Console.WriteLine(spiralStart);
                    return;
                }
                if ((counter >= 2) && (counter%2 == 0))
                {
                    spiralStep += step;
                }

                spiralStart += spiralStep;

                counter++;
            }
            Console.WriteLine("No");
        }
    }
}