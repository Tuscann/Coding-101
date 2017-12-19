using System;
    class Program
    {
        static void Main() // 90/100
        {
            int readNumber1 = int.Parse(Console.ReadLine());
            int readNumber2 = int.Parse(Console.ReadLine());
            int readNumber3 = int.Parse(Console.ReadLine());
            int specialNumber = int.Parse(Console.ReadLine());
            int controlNumber = int.Parse(Console.ReadLine());
            int sum = 0;


            for (int i = readNumber1; i >= 1; i--)
            {
                for (int i2 = readNumber2; i2 >= 1; i2--)
                {
                    for (int i3 = readNumber3; i3 >= 1; i3--)
                    {
                        string number = string.Format(("{0}{1}{2}"), i, i2, i3);
                        int realNumber = int.Parse(number);
                        sum = i + i2 + i3;

                        if (sum % 3 == 0)
                        {
                            specialNumber += 5;

                            if (specialNumber >= controlNumber)
                            {
                                Console.WriteLine("Yes! Control number was reached! Current special number is {0}.", specialNumber);
                                return;
                            }

                        }

                        if (i3 == 5 && sum % 3 != 0)
                        {
                            specialNumber -= 2;
                            if (specialNumber >= controlNumber)
                            {
                                Console.WriteLine("Yes! Control number was reached! Current special number is {0}.", specialNumber);
                                return;
                            }

                        }

                        if (i3 % 2 == 0 && i3 != 5 && sum % 3 != 0)
                        {
                            specialNumber *= 2;
                            if (specialNumber >= controlNumber)
                            {
                                Console.WriteLine("Yes! Control number was reached! Current special number is {0}.", specialNumber);
                                return;
                            }

                        }

                        if (i == 1 && i2 == 1 && i3 == 1)
                        {
                            Console.WriteLine("No! {0} is the last reached special number.", specialNumber);
                        }

                    }
                }
            }

        }
    }