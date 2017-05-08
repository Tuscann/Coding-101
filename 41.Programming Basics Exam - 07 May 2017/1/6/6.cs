using System;
namespace Exam1
{
    class Program
    {
        static void Main(string[] args)
        {
            int M = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());
            int L = int.Parse(Console.ReadLine());
            int specialNumber = int.Parse(Console.ReadLine());
            int checkNumber = int.Parse(Console.ReadLine());

            int number = 0;
            for (int i = M; i >= 1; i--)
            {
                for (int j = N; j >= 1; j--)
                {
                    for (int k = L; k >= 1; k--)
                    {
                        number = 100 * i + 10 * j + k;
                        if (number % 3 == 0)
                        {
                            specialNumber += 5;
                        }
                        else if (number % 10 == 5)
                        {
                            specialNumber -= 2;
                        }
                        else if (number % 2 == 0)
                        {
                            specialNumber *= 2;
                        }
                        if (specialNumber >= checkNumber)
                        {
                            Console.WriteLine("Yes! Control number was reached! Current special number is {0}.", specialNumber);
                            return;
                        }
                    }
                }
            }
            Console.WriteLine("No! {0} is the last reached special number.", specialNumber);
        }
    }
}
