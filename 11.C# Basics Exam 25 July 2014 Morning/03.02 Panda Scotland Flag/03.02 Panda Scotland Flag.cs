using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char printChar = 'A';
        int diez = n - 2;
        int tilt = 0;

        for (int i = 0; i < n / 2; i++)
        {

            Console.Write(new string('~', tilt));
            Console.Write(printChar);

            if (printChar == 'Z')
            {
                printChar = 'A';
            }
            else
            {
                printChar++;
            }
            Console.Write(new string('#', diez));
            Console.Write(printChar);

            if (printChar == 'Z')
            {
                printChar = 'A';
            }
            else
            {
                printChar++;
            }

            Console.Write(new string('~', tilt));
            diez -= 2;
            tilt++;
            Console.WriteLine();
        }

        Console.WriteLine("{0}{1}{0}", new string('-', (n - 1) / 2), printChar);

        diez = 1;
        tilt = tilt - 1;
        printChar++;

        for (int i = 0; i < n / 2; i++)
        {
            Console.Write(new string('~', tilt));
            Console.Write(printChar);

            if (printChar == 'Z')
            {
                printChar = 'A';
            }
            else
            {
                printChar++;
            }
            Console.Write(new string('#', diez));
            Console.Write(printChar);

            if (printChar == 'Z')
            {
                printChar = 'A';
            }
            else
            {
                printChar++;
            }

            Console.Write(new string('~', tilt));

            diez += 2;
            tilt--;
            Console.WriteLine();
        }
    }
}