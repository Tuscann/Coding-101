using System;
class PhoneProcesses
    {
        static void Main()
        {
            string initialPower = Console.ReadLine();
            initialPower = initialPower.Replace('%', ' ');
            int power = int.Parse(initialPower);
            bool needRecharge = false;
            bool phoneIsDead = false;
            int programs = 0;
            if (power == 0)
            {
                phoneIsDead = true;
            }
            else if (power <= 15)
            {
                needRecharge = true;
            }
            string command = Console.ReadLine();
            while (!command.ToLower().Equals("end"))
            {
                if (phoneIsDead || needRecharge)
                {
                    programs++;
                    command = Console.ReadLine();
                    continue;
                }
                int perc = int.Parse(command.Substring(command.Length - 3, 2));
                int oldpower = power;
                power -= perc;
                if (power <= 0)
                {
                    phoneIsDead = true;
                    continue;
                }
                else if (power <= 15)
                {
                    needRecharge = true;
                    command = Console.ReadLine();
                    continue;
                }
                command = Console.ReadLine();
            }
            if (needRecharge)
            {
                Console.WriteLine("Connect charger -> " + power + "%");
                Console.WriteLine("Programs left -> {0}", programs);
            }
            else if (phoneIsDead)
            {
                Console.WriteLine("Phone Off");
            }
            else
            {
                Console.WriteLine("Successful complete -> " + power + "%");
            }
        }
    }