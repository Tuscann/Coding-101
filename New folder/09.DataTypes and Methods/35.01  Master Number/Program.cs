using System;
class Program
{
    static void Main()
    {

        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
             int sumOfDigits = 0;
            int digits = n;
            while (digits > 0)
            {
                sumOfDigits += digits % 10;
                digits = digits / 10;
            }


            if (i > 0 && i <= 9)
            {
                Console.WriteLine(i);
            }
            if (i / n != 0 &&)
            {

            }



        }

    }
}

