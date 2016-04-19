using System;
class LocalElections
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int v = int.Parse(Console.ReadLine());
            char symbol = char.Parse(Console.ReadLine());

            for (int k = 1; k <= n; k++)
            {
                Console.WriteLine(new string('.', 13));

                if (k != v)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        if (i == 0 || i == 4)
                        {
                            Console.Write(new string('.', 3));
                            Console.Write("+");
                            Console.Write(new string('-', 5));
                            Console.Write("+");
                            Console.WriteLine(new string('.', 3));
                        }
                        else
                        {
                            if (i == 2)
                            {
                                if (k < 10)
                                {
                                    Console.Write("0{0}.", k);
                                }
                                else if (k >= 10 && k <= 99)
                                {
                                    Console.Write("{0}.", k);
                                }
                                else
                                {
                                    Console.Write("{0}", k);
                                }

                                Console.Write("|");
                                Console.Write(new string('.', 5));
                                Console.Write("|");
                                Console.WriteLine(new string('.', 3));
                            }
                            else
                            {
                                Console.Write(new string('.', 3));
                                Console.Write("|");
                                Console.Write(new string('.', 5));
                                Console.Write("|");
                                Console.WriteLine(new string('.', 3));
                            }
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < 5; i++)
                    {
                        if (symbol.ToString().ToLower() == "x")
                        {
                            if (i == 0 || i == 4)
                            {
                                Console.Write(new string('.', 3));
                                Console.Write("+");
                                Console.Write(new string('-', 5));
                                Console.Write("+");
                                Console.WriteLine(new string('.', 3));
                            }
                            else if (i == 1)
                            {
                                Console.Write(new string('.', 3));
                                Console.Write("|");
                                Console.Write(".");
                                Console.Write("\\");
                                Console.Write(".");
                                Console.Write("/");
                                Console.Write(".");
                                Console.Write("|");
                                Console.WriteLine(new string('.', 3));
                            }
                            else if (i == 3)
                            {
                                Console.Write(new string('.', 3));
                                Console.Write("|");
                                Console.Write(".");
                                Console.Write("/");
                                Console.Write(".");
                                Console.Write("\\");
                                Console.Write(".");
                                Console.Write("|");
                                Console.WriteLine(new string('.', 3));
                            }
                            else
                            {
                                if (k < 10)
                                {
                                    Console.Write("0{0}.", k);
                                }
                                else if (k >= 10 && k <= 99)
                                {
                                    Console.Write("{0}.", k);
                                }
                                else
                                {
                                    Console.Write("{0}", k);
                                }

                                Console.Write("|");
                                Console.Write(new string('.', 2));
                                Console.Write(symbol.ToString().ToUpper());
                                Console.Write(new string('.', 2));
                                Console.Write("|");
                                Console.WriteLine(new string('.', 3));
                            }
                        }
                        else
                        {
                            if (i == 0 || i == 4)
                            {
                                Console.Write(new string('.', 3));
                                Console.Write("+");
                                Console.Write(new string('-', 5));
                                Console.Write("+");
                                Console.WriteLine(new string('.', 3));
                            }
                            else if (i == 1)
                            {
                                Console.Write(new string('.', 3));
                                Console.Write("|");
                                Console.Write("\\");
                                Console.Write(new string('.', 3));
                                Console.Write("/");
                                Console.Write("|");
                                Console.WriteLine(new string('.', 3));
                            }
                            else if (i == 3)
                            {
                                Console.Write(new string('.', 3));
                                Console.Write("|");
                                Console.Write(new string('.', 2));
                                Console.Write(symbol.ToString().ToUpper());
                                Console.Write(new string('.', 2));
                                Console.Write("|");
                                Console.WriteLine(new string('.', 3));
                            }
                            else
                            {
                                if (k < 10)
                                {
                                    Console.Write("0{0}.", k);
                                }
                                else
                                {
                                    Console.Write("{0}.", k);
                                }

                                Console.Write("|");
                                Console.Write(".");
                                Console.Write("\\");
                                Console.Write(".");
                                Console.Write("/");
                                Console.Write(".");
                                Console.Write("|");
                                Console.WriteLine(new string('.', 3));
                            }
                        }
                    }
                }
            }
            Console.WriteLine(new string('.', 13));
        }
    }
