using System;
using System.Text;
class SaltAndPepper
{
    static void Main()
    {
        ulong dishes = ulong.Parse(Console.ReadLine());
        string dishesToBits = ConvertToBinary(dishes).PadLeft(64, '0');
        char[] bits = dishesToBits.ToCharArray();

        string line = Console.ReadLine();

        do
        {
            string[] getLine = line.Split();
            string command = getLine[0];
            if (command == "end")
            {
                break;
            }
            int step = int.Parse(getLine[1]);

            if (step > 0)
            {
                for (int i = bits.Length - 1; i >= 0; i -= step)
                {
                    if (command == "salt" && bits[i] == '1')
                    {
                        bits[i] = '0';
                    }
                    else if (command == "pepper" && bits[i] == '0')
                    {
                        bits[i] = '1';
                    }
                }
            }
            else
            {
                line = Console.ReadLine();
                continue;
            }

            line = Console.ReadLine();
        } while (line != "end");

        StringBuilder addBits = new StringBuilder();

        for (int i = 0; i < bits.Length; i++)
        {
            addBits.Append(bits[i]);
        }
        ulong res = Convert.ToUInt64(addBits.ToString(), 2);
        Console.WriteLine(res);
    }

    static string ConvertToBinary(ulong value)
    {
        if (value == 0) return "0";
        System.Text.StringBuilder b = new System.Text.StringBuilder();
        while (value != 0)
        {
            b.Insert(0, ((value & 1) == 1) ? '1' : '0');
            value >>= 1;
        }
        return b.ToString();
    }
}