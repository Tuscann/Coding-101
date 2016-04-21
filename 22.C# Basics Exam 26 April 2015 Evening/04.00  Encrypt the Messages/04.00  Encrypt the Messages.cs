using System;
using System.Collections.Generic;
public class EncryptTheMessages
{
    public static void Main()
    {
        Dictionary<char, char> specialSymbols = new Dictionary<char, char>
        {
            {' ', '+'},
            {',', '%'},
            {'.', '&'},
            {'?', '#'},
            {'!', '$'}
        };

        List<string> encryptedMessages = new List<string>();

        string command = Console.ReadLine();

        while (command != "start" && command != "START")
        {
            command = Console.ReadLine();
        }

        command = Console.ReadLine();

        while (command != "end" && command != "END")
        {
            if (string.IsNullOrWhiteSpace(command))
            {
                command = Console.ReadLine();
                continue;
            }

            char[] symbols = command.ToCharArray();

            for (int i = 0; i < symbols.Length; i++)
            {
                char currentSymbol = symbols[i];

                if (specialSymbols.ContainsKey(currentSymbol))
                {
                    symbols[i] = specialSymbols[currentSymbol];
                }
                else if (('a' <= currentSymbol && currentSymbol <= 'm') || ('A' <= currentSymbol && currentSymbol <= 'M'))
                {
                    symbols[i] = (char)(currentSymbol + 13);
                }
                else if (('n' <= currentSymbol && currentSymbol <= 'z') || ('N' <= currentSymbol && currentSymbol <= 'Z'))
                {
                    symbols[i] = (char)(currentSymbol - 13);
                }
            }

            Array.Reverse(symbols);

            encryptedMessages.Add(new string(symbols));

            command = Console.ReadLine();
        }

        if (encryptedMessages.Count == 0)
        {
            Console.WriteLine("No messages sent.");
        }
        else
        {
            Console.WriteLine("Total number of messages: {0}", encryptedMessages.Count);

            foreach (var decryptedMessage in encryptedMessages)
            {
                Console.WriteLine(decryptedMessage);
            }
        }
    }
}