using System;

namespace _06._00_Tournament_of_Christmas
{
    class Program
    {
        public static void Main()
        {
            double totalMoneyDay = 0;
            int countLost = 0;
            int countWin = 0;
            double total = 0;
            int counterWinsDays = 0;
            
            int days = int.Parse(Console.ReadLine());

            for (int day = 0; day < days; day++)
            {
                while (true)
                {
                    string currentSport = Console.ReadLine();
                    if (currentSport == "Finish")
                    {
                        if (countWin > countLost)
                        {
                            totalMoneyDay *= 1.1;
                            counterWinsDays += 1;
                        }
                        else
                        {
                            counterWinsDays -= 1;
                        }
                        total += totalMoneyDay;

                        totalMoneyDay = 0;
                        countWin = 0;
                        countLost = 0;

                        break;
                    }

                    string resultOfSport = Console.ReadLine();
                    if (resultOfSport == "win")
                    {
                        totalMoneyDay += 20;
                        countWin += 1;
                    }
                    else if(resultOfSport == "lose")
                    {
                        countLost += 1;
                    }
                }
            }

            if (counterWinsDays > 0)
            {
                Console.Write("You won the tournament! ");
                total *= 1.2;
            }
            else
            {
                Console.Write("You lost the tournament! ");
            }
            Console.WriteLine("Total raised money: {0:f2}",total);
        }
    }
}