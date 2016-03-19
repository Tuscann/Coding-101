using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string inputString = string.Empty;
        int msgCounter = 0;
        List<string> msges = new List<string>();

        do
        {
            inputString = Console.ReadLine();
        } while (inputString.ToUpper() != "START");

        inputString = Console.ReadLine();
        while (inputString.ToUpper() != "END")
        {
            if (inputString != "")
            {
                msgCounter++;
                string decrupTedMSg = "";
                for (int symbol = 0; symbol < inputString.Length; symbol++)
                {
                    if ((inputString[symbol] >= 'A' && inputString[symbol] <= 'Z') ||
                        (inputString[symbol] >= 'a' && inputString[symbol] <= 'z'))
                    {
                        if ((inputString[symbol] >= 'A' && inputString[symbol] <= 'M') || (inputString[symbol] >= 'a' && inputString[symbol] <= 'm'))
                        {
                            decrupTedMSg += (char)(inputString[symbol] + 13);

                        }
                        else
                        {
                            decrupTedMSg += (char)(inputString[symbol] - 13);
                        }
                    }
                    else if ((inputString[symbol] == '+') || (inputString[symbol] == '%') ||
                          (inputString[symbol] == '&') || (inputString[symbol] == '#') || (inputString[symbol] == '$'))
                    {
                        switch (inputString[symbol])
                        {
                            case '+': decrupTedMSg += ' '; break;
                            case '%': decrupTedMSg += ','; break;
                            case '&': decrupTedMSg += '.'; break;
                            case '#': decrupTedMSg += '?'; break;
                            case '$': decrupTedMSg += '!'; break;
                            default: decrupTedMSg += inputString[symbol]; break;
                        }
                    }
                }
                char[] reversedARRY = decrupTedMSg.ToCharArray();
                Array.Reverse(reversedARRY);
                decrupTedMSg = new string(reversedARRY);
                msges.Add(decrupTedMSg);
            }
            inputString = Console.ReadLine();
            
        }

        if (msges.Count!=0)
        {
            Console.WriteLine("Total number of messages: {0}",msges.Count);
            foreach (var msg in msges)
            {
                Console.WriteLine(msg);
            }
        }
        else
        {
            Console.WriteLine("No message received.");
        }
    }
}

