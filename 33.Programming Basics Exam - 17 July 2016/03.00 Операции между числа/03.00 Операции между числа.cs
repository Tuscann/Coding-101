using System;
class Program
{
    static void Main()
    {
        decimal first = decimal.Parse(Console.ReadLine());
        decimal second = decimal.Parse(Console.ReadLine());

        string input = Console.ReadLine();
        
        if (input == "+") /*  case 1 - Събиране(+) */
        {
            if ((first + second) % 2 == 0)
            {
                Console.WriteLine("{0:f0} + {1:f0} = {2:f0} - even", first, second, first + second);
            }
            else
            {
                Console.WriteLine("{0:f0} + {1:f0} = {2:f0} - odd", first, second, first + second);
            }
        }
        else if (input == "-") /*  case 2 - Изваждане(-) */  
        {
            if ((first - second) % 2 == 0)
            {
                Console.WriteLine("{0:f0} + {1:f0} = {2:f0} - even", first, second, first - second);
            }
            else
            {
                Console.WriteLine("{0:f0} - {1:f0} = {2:f0} - odd", first, second, first - second);
            }
        }
        else if (input == "/") /*  case 3 -  Деление(/) */
        {

            if (second != 0)
            {
                Console.WriteLine("{0:f0} / {1:f0} = {2:f2}", first, second, first / second);
            }
            else if (second == 0)
            {
                Console.WriteLine("Cannot divide {0} by zero", first);
            }
        }
        else if (input == "*")  /*  case 4 - Умножение(*) */
        {
            if ((first * second) % 2 == 0)
            {
                Console.WriteLine("{0:f0} * {1:f0} = {2:f0} - even", first, second, first * second);
            }
            else
            {
                Console.WriteLine("{0:f0} * {1:f0} = {2:f0} - odd", first, second, first * second);
            }
        }
        else if (input == "%") /*  case 5 - Модулно деление(%) */
        {
            if (second != 0)
            {
                Console.WriteLine("{0:f0} % {1:f0} = {2:f0}", first, second, first % second);
            }
            else if (second == 0)
            {
                Console.WriteLine("Cannot divide {0} by zero", first);
            }
        }
    }
}