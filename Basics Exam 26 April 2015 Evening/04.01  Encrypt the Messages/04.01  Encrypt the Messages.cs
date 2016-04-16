using System;
public class EncryptTheMessages
{
    public static void Main()
    {
        string command = Console.ReadLine();

        while (command != "start" && command != "START")
        {
            command = Console.ReadLine();
        }

        command = Console.ReadLine();

        int countOfMessages = 0;
        string encryptedMessage = string.Empty;

        while (command != "end" && command != "END")
        {
            if (string.IsNullOrWhiteSpace(command))
            {
                command = Console.ReadLine();
                continue;
            }

            for (int i = command.Length - 1; i >= 0; i--)
            {
                char currentSymbol = command[i];

                if (('a' <= currentSymbol && currentSymbol <= 'm') || ('A' <= currentSymbol && currentSymbol <= 'M'))
                {
                    encryptedMessage += (char)(currentSymbol + 13);
                }
                else if (('n' <= currentSymbol && currentSymbol <= 'z') || ('N' <= currentSymbol && currentSymbol <= 'Z'))
                {
                    encryptedMessage += (char)(currentSymbol - 13);
                }
                else if ('0' <= currentSymbol && currentSymbol <= '9')
                {
                    encryptedMessage += currentSymbol;
                }
                else
                {
                    switch (currentSymbol)
                    {
                        case ' ':
                            encryptedMessage += '+';
                            break;
                        case ',':
                            encryptedMessage += '%';
                            break;
                        case '.':
                            encryptedMessage += '&';
                            break;
                        case '?':
                            encryptedMessage += '#';
                            break;
                        case '!':
                            encryptedMessage += '$';
                            break;
                    }
                }
            }

            /* add a new line symbol independent of the system (Linux, Windows)
             * equivalent to "\n", but safer to use in different environments */
            encryptedMessage += Environment.NewLine;
            countOfMessages++;

            command = Console.ReadLine();
        }

        if (countOfMessages == 0)
        {
            Console.WriteLine("No messages sent.");
        }
        else
        {
            Console.WriteLine("Total number of messages: {0}", countOfMessages);

            Console.Write(encryptedMessage);
        }
    }
}