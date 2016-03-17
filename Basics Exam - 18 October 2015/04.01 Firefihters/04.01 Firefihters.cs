using System;
 class Problem4
    {
        static void Main()
        {
            int firefighters = int.Parse(Console.ReadLine());
            int counterKids = 0;
            int counterAdults = 0;
            int counterSenior = 0;
            int counterFireFighters = firefighters;

            string command = Console.ReadLine();

            while (command != "rain")
            {
                for (int i = 0; i < command.Length; i++)
                {
                    if (command[i] == 'K' && counterFireFighters > 0)
                    {
                        if (counterFireFighters < 0){break;}

                        counterKids++;
                        counterFireFighters--;
                        command = command.Remove(i, 1);
                        i--;
                    }
                }
                for (int i = 0; i < command.Length; i++)
                {
                    if (command[i] == 'A' && counterFireFighters > 0)
                    {
                        if (counterFireFighters < 0){break;}

                        counterAdults++;
                        counterFireFighters--;
                        command = command.Remove(i, 1);
                        i--;
                    }
                }
                for (int i = 0; i < command.Length; i++)
                {
                    if (command[i] == 'S' && counterFireFighters > 0)
                    {
                        if (counterFireFighters < 0){break;}
                        counterSenior++;
                        counterFireFighters--;
                        command = command.Remove(i, 1);
                        i--;
                    }
                }
                counterFireFighters = firefighters;
                command = Console.ReadLine();
            }
            Console.WriteLine("Kids: {0}\nAdults: {1}\nSeniors: {2}", counterKids,counterAdults,counterSenior);
        }
    }
