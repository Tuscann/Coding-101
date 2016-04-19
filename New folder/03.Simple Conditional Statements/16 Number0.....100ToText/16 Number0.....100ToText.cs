using System;
class Program
{
    static void Main()
    {
        var number = int.Parse(Console.ReadLine());

        if (number >= 0 && number <= 19)
        {
            if (number == 0000000) { Console.WriteLine("zero"); }
            else if (number == 01) { Console.WriteLine("one"); }
            else if (number == 02) { Console.WriteLine("two"); }
            else if (number == 03) { Console.WriteLine("three"); }
            else if (number == 04) { Console.WriteLine("four"); }
            else if (number == 05) { Console.WriteLine("five"); }
            else if (number == 06) { Console.WriteLine("six"); }
            else if (number == 07) { Console.WriteLine("seven"); }
            else if (number == 08) { Console.WriteLine("eight"); }
            else if (number == 09) { Console.WriteLine("nine"); }
            else if (number == 10) { Console.WriteLine("ten"); }
            else if (number == 11) { Console.WriteLine("eleven"); }
            else if (number == 12) { Console.WriteLine("twelve"); }
            else if (number == 13) { Console.WriteLine("thirteen"); }
            else if (number == 14) { Console.WriteLine("fourteen"); }
            else if (number == 15) { Console.WriteLine("fifteen"); }
            else if (number == 16) { Console.WriteLine("sixteen"); }
            else if (number == 17) { Console.WriteLine("seventeen"); }
            else if (number == 18) { Console.WriteLine("eightteen"); }
            else if (number == 19) { Console.WriteLine("nineteen"); }
        }
        else if (number >= 20 && number <= 99)
        {
            string[] zeroNine = new string[10] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            string[] lastZero = new string[10] { "zero", "ten", "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety" };

            if (number % 10 == 0) { Console.WriteLine(lastZero[number / 10]); }
            else { Console.WriteLine(lastZero[number / 10] + " " + zeroNine[number % 10]); }

        }
        else if (number == 100) { Console.WriteLine("one hundred"); }
        else { Console.WriteLine("invalid number"); }
    }
}

