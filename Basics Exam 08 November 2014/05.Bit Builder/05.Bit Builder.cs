using System;
class BitBuilder
{
    static void Main()
    {
        long number = Convert.ToInt64(Console.ReadLine());

        string action = "";
        int position = 0;

        while (true)
        {
            long mask = 0;

            string positionString = Console.ReadLine();

            if (positionString == "quit")
            {
                Console.WriteLine(number);
                return;
            }

            position = Convert.ToInt32(positionString);
            action = Console.ReadLine();

            string maskAsString = new string('1', position);

            if (position != 0)
            {
                mask = Convert.ToInt64(maskAsString, 2);
            }

            if (action == "flip")
            {
                number = number ^ (1 << position);
            }

            long rightBits = number & mask;

            if (action == "insert")
            {
                number = number >> position;
                number = number << (position + 1);
                number = number | ((long)1 << position);
                number = number | rightBits;
            }

            if (action == "remove")
            {
                number = number >> (position + 1);
                number = number << position;
                number = (long)number | rightBits;
            }
        }
    }
}