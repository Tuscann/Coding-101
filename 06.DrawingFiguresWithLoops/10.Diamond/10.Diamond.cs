using System;

class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        if (number == 1) { Console.WriteLine("*"); }
        else if (number == 2) { Console.WriteLine("**"); }
        else
        {
            int numberOfRows = number;

            if (number % 2 == 0)
            {

                for (int i = 0; i < number / 2; i++)
                {
                    var numberOfDashes = i * 2;
                    var numberOfDashesOutside = number - 2 - numberOfDashes;
                    Console.Write(new string('-', numberOfDashesOutside / 2));
                    Console.Write("*");
                    Console.Write(new string('-', numberOfDashes));
                    Console.Write("*");
                    Console.WriteLine(new string('-', numberOfDashesOutside / 2));
                }
                for (int i = (number - 1) / 2 - 1; i >= 0; i--)
                {
                    var numberOfDashes = i * 2;
                    var numberOfDashesOutside = number - 2 - numberOfDashes;
                    Console.Write(new string('-', numberOfDashesOutside / 2));
                    Console.Write("*");
                    Console.Write(new string('-', numberOfDashes));
                    Console.Write("*");
                    Console.WriteLine(new string('-', numberOfDashesOutside / 2));
                }
            }
            else
            {
                Console.Write(new string('-', (number - 1) / 2));
                Console.Write('*');
                Console.WriteLine(new string('-', (number - 1) / 2));


                int rows = (number - 1) / 2;
                for (int curentRow = 0; curentRow < rows; curentRow++)
                {
                    var numberOfDashes = (curentRow * 2) + 1;
                    var numberOfDashesOutside = number - 2 - numberOfDashes;
                    Console.Write(new string('-', numberOfDashesOutside / 2));
                    Console.Write("*");
                    Console.Write(new string('-', numberOfDashes));
                    Console.Write("*");
                    Console.WriteLine(new string('-', numberOfDashesOutside / 2));

                }
                for (int curentRow = rows - 2; curentRow >= 0; curentRow--)
                {
                    var numberOfDashes = (curentRow * 2) + 1;
                    var numberOfDashesOutside = number - 2 - numberOfDashes;
                    Console.Write(new string('-', numberOfDashesOutside / 2));
                    Console.Write("*");
                    Console.Write(new string('-', numberOfDashes));
                    Console.Write("*");
                    Console.WriteLine(new string('-', numberOfDashesOutside / 2));
                }
                Console.Write(new string('-', (number - 1) / 2));
                Console.Write('*');
                Console.WriteLine(new string('-', (number - 1) / 2));
            }

        }
    }
}

