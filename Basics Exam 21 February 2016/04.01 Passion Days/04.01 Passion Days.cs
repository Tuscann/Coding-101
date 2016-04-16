using System;
class Program
    {
        static void Main()
        {
            decimal money = decimal.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            int purchases = 0;
            command = Console.ReadLine();
            while (command != "mall.Exit")
            {
                string actions = command;
                for (int i = 0; i < actions.Length; i++)
                {
                    decimal price = 0;
                    char chr = actions[i];
                    if (char.IsLetter(chr))
                    {
                        decimal discount = char.IsUpper(chr) ? 0.5m : 0.3m;
                        price = chr * discount;
                        if (money >= price)
                        {
                            money -= price;
                            purchases++;
                        }
                    }
                    else if (chr == '%')
                    {
                        if (money > 0)
                        {
                            money /= 2;
                            purchases++;
                        }
                    }
                    else if (chr == '*')
                    {
                        money += 10;
                    }
                    else
                    {
                        price = chr;
                        if (money >= price)
                        {
                            money -= price;
                            purchases++;
                        }
                    }
                }
                command = Console.ReadLine();
            }
            if (purchases == 0)
            {
                Console.WriteLine("No purchases. Money left: {0:f2} lv.", money);
            }
            else
            {
                Console.WriteLine("{0} purchases. Money left: {1:f2} lv.", purchases, money);
            }
        }
    }
