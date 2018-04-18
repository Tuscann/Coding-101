using System;
class Program
{
    static void Main()
    {
        int firstpair = int.Parse(Console.ReadLine());
        int secondpair = int.Parse(Console.ReadLine());
        int firstpairLimit = int.Parse(Console.ReadLine());
        int secodpairLimit = int.Parse(Console.ReadLine());

        for (int first = firstpair; first <= firstpair + firstpairLimit; first++)
        {
            for (int second = secondpair; second <= secondpair + secodpairLimit; second++)
            {
                double squareRoot1 = (int)Math.Floor(Math.Sqrt(first));
                double squareRoot2 = (int)Math.Floor(Math.Sqrt(second));

                bool isPrime1 = true;
                bool isPrime2 = true;
                if (first < 2)
                {
                    isPrime1 = false;
                }
                if (second < 2)
                {
                    isPrime2 = false;
                }

                for (int i = 2; i <= squareRoot1; i++)
                {
                    if (first % i == 0)
                    {
                        isPrime1 = false;
                        break;
                    }
                }

                for (int i = 2; i <= squareRoot2; i++)
                {
                    if (second % i == 0)
                    {
                        isPrime2 = false;
                        break;
                    }

                }

                if (isPrime1 && isPrime2)
                {
                    Console.Write(first);
                    Console.WriteLine(second);
                }
            }
        }
    }
}