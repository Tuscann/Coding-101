using System;
using System.Globalization;
using System.Threading;

class Program
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        decimal banana = 1.80m;
        decimal cucumber = 2.75m;
        decimal tomato = 3.20m;
        decimal orange = 1.60m;
        decimal apple = 0.86m;
        string dayOfTheWeek = Console.ReadLine();
        decimal result = 0;
        for (int i = 0; i < 3; i++)
        {
            decimal quantity = decimal.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            if (dayOfTheWeek == "Tuesday") // 20% discount for fruits
            {
                switch (input)
                {
                    case "banana":
                        result += ((banana - banana * 0.2m) * quantity);
                        break;
                    case "orange":
                        result += ((orange - orange * 0.2m) * quantity);
                        break;
                    case "apple":
                        result += ((apple - apple * 0.2m) * quantity);
                        break;
                    case "cucumber":
                        result += cucumber * quantity;
                        break;
                    case "tomato":
                        result += tomato * quantity;
                        break;
                }
            }

            else if (dayOfTheWeek == "Wednesday") // 10% discount for vegetables
            {
                switch (input)
                {
                    case "cucumber":
                        result += ((cucumber - cucumber * 0.1m) * quantity);
                        break;
                    case "tomato":
                        result += ((tomato - tomato * 0.1m) * quantity);
                        break;
                    case "orange":
                        result += orange * quantity;
                        break;
                    case "apple":
                        result += apple * quantity;
                        break;
                    case "banana":
                        result += banana * quantity;
                        break;
                }
            }

            else if (dayOfTheWeek == "Thursday") // 30% discount for bananas
            {
                switch (input)
                {
                    case "banana":
                        result += ((banana - banana * 0.3m) * quantity);
                        break;
                    case "cucumber":
                        result += cucumber * quantity;
                        break;
                    case "tomato":
                        result += tomato * quantity;
                        break;
                    case "orange":
                        result += orange * quantity;
                        break;
                    case "apple":
                        result += apple * quantity;
                        break;
                }
            }

            else // no discounts
            {
                switch (input)
                {
                    case "banana":
                        result += banana * quantity;
                        break;
                    case "cucumber":
                        result += cucumber * quantity;
                        break;
                    case "tomato":
                        result += tomato * quantity;
                        break;
                    case "orange":
                        result += orange * quantity;
                        break;
                    case "apple":
                        result += apple * quantity;
                        break;
                }
            }
        }

        if (dayOfTheWeek == "Friday") // 10% discount
        {
            result -= result * 0.1m;
        }
        else if (dayOfTheWeek == "Sunday") // 10% discount
        {
            result -= result * 0.05m;
        }
        Console.WriteLine("{0:f2}",result);
    }
}