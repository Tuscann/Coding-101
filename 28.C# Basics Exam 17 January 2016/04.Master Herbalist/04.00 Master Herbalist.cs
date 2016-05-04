using System;
class Program
{
    static void Main()
    {
        int dailyExpenses = int.Parse(Console.ReadLine());
        string input = Console.ReadLine();
        int days = 0;
        int totalMoney = 0;

        while (input != "Season Over")
        {
            days++;
            string[] parameters = input.Split();
            int hours = int.Parse(parameters[0]);
            string path = parameters[1];
            int price = int.Parse(parameters[2]);

            int herbs = 0;
            for (int i = 0; i < hours; i++)
            {
                if (path[i % path.Length] == 'H')
                {
                    herbs++;
                }
            }
            totalMoney = totalMoney + herbs * price;
            input = Console.ReadLine();
        }
        //Console.WriteLine(totalMoney);
        decimal average = (decimal)totalMoney / days;

        if (average >= dailyExpenses)
        {
            Console.WriteLine("Times are good. Extra money per day: {0:F2}.", average - dailyExpenses);
        }
        else
        {
            int totalExpenses = dailyExpenses * days;
            Console.WriteLine("We are in the red. Money needed: {0}.", totalExpenses - totalMoney);
        }
    }
}