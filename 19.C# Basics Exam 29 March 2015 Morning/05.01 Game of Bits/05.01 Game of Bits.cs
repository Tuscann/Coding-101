using System;
using System.Text;
using System.Linq;
class GameOfBits
{
    static void Main()
    {
        uint number = uint.Parse(Console.ReadLine());
        string binary = Convert.ToString(number, 2);
        //Console.WriteLine(binary);
        binary = ReverseString(binary);

        StringBuilder temp = new StringBuilder();
        string command = "";
        while (command != "Game Over!")
        {
            command = Console.ReadLine();

            if (command == "Game Over!")
            {
                //Console.WriteLine(binary);
                binary = ReverseString(binary);
                int count = binary.Count(c => c == '1');
                ulong final = BinaryToDecimal(binary);

                Console.WriteLine("{0} -> {1}", final, count);
            }

            if (command == "Odd")
            {
                for (int i = 0; i < binary.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        temp.Append(binary[i]);
                    }
                }
            }
            else if (command == "Even")
            {
                for (int i = 0; i < binary.Length; i++)
                {
                    if (i % 2 != 0)
                    {
                        temp.Append(binary[i]);
                    }
                }
            }

            binary = temp.ToString();
            temp.Clear();
            //Console.WriteLine(binary);
        }
    }
    private static ulong BinaryToDecimal(string number)
    {
        ulong decNumber = 0;
        int index = 0;
        for (int i = number.Length - 1; i >= 0; i--)
        {
            decNumber += (ulong)(int.Parse(number[i].ToString()) * Math.Pow(2, index));
            index++;
        }
        return decNumber;
    }

    private static string ReverseString(string s)
    {
        char[] arr = s.ToCharArray();
        Array.Reverse(arr);
        return new string(arr);
    }
}