using System;

class CurrencyConverter
{
    //    Напишете програма за конвертиране на парична сума от една валута в друга. Трябва да се поддържат следните валути: BGN, USD, EUR, GBP. Използвайте следните фиксирани валутни курсове:
    //Курс	  USD	  EUR	   GBP
    //1 BGN	1.79549	1.95583	2.53405

    static void Main()
    {
        var USD = 1.79549;
        var EUR = 1.95583;
        var GBP = 2.53405;
        var x = double.Parse(Console.ReadLine());
        var firstCurency = Console.ReadLine();
        var secondCerrency = Console.ReadLine();
        var moneyInleva = 0.00;

        if (firstCurency == "USD") { moneyInleva = x * USD; }
        else if (firstCurency == "EUR") { moneyInleva = x * EUR; }
        else if (firstCurency == "GBP") { moneyInleva = x * GBP; }
        else if (firstCurency == "BGN") { moneyInleva = x; }


        var MoneyInWanted = 0.00;
        if (secondCerrency == "USD") { MoneyInWanted = moneyInleva / USD; }
        else if (secondCerrency == "EUR") { MoneyInWanted = moneyInleva / EUR; }
        else if (secondCerrency == "GBP") { MoneyInWanted = moneyInleva / GBP; }
        else if (secondCerrency == "BGN") { MoneyInWanted = moneyInleva; }

        Console.WriteLine("{0:0.00} {1}", MoneyInWanted, secondCerrency);

        //if (firstCurency == "USD" && secondCerrency == "BGN") { Console.WriteLine("{0:0.00} BGN", x * USD); }
        //if (firstCurency == "USD" && secondCerrency == "EUR") { Console.WriteLine("{0:0.00} EUR", x * USD * EUR); }
        //if (firstCurency == "USD" && secondCerrency == "GBP") { Console.WriteLine("{0:0.00} GBP", x * USD * GBP); }

        //if (firstCurency == "BGN" && secondCerrency == "USD") { Console.WriteLine("{0:0.00} USD", x / USD); }
        //if (firstCurency == "BGN" && secondCerrency == "EUR") { Console.WriteLine("{0:0.00} EUR", x / EUR); }
        //if (firstCurency == "BGN" && secondCerrency == "GBP") { Console.WriteLine("{0:0.00} GBP", x / GBP); }

        //if (firstCurency == "EUR" && secondCerrency == "BGN") { Console.WriteLine("{0:0.00} BGN", x * EUR); }
        //if (firstCurency == "EUR" && secondCerrency == "USD") { Console.WriteLine("{0:0.00} USD", x * EUR * USD); }
        //if (firstCurency == "EUR" && secondCerrency == "GBP") { Console.WriteLine("{0:0.00} GBP", x * EUR * GBP); }

        //if (firstCurency == "GBP" && secondCerrency == "BGN") { Console.WriteLine("{0:0.00} BGN", x / GBP); }
        //if (firstCurency == "GBP" && secondCerrency == "EUR") { Console.WriteLine("{0:0.00} EUR", x / GBP / EUR); }
        //if (firstCurency == "GBP" && secondCerrency == "USD") { Console.WriteLine("{0:0.00} GBP", x / USD / GBP); }


    }
}

