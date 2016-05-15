using System;
using System.Text;
class Unicode_Characters
{
    static void Main()
    {
        string str = Console.ReadLine();
        byte[] unibyte = Encoding.Unicode.GetBytes(str);
        StringBuilder uniString = new StringBuilder();
        for (byte i = 0; i < unibyte.Length; i++)
        {
            if (unibyte[i] > 0)
            {
                uniString = uniString.AppendFormat("{0}{1}", @"\u", unibyte[i].ToString("X4").ToLower());
            }
        }
        Console.WriteLine(uniString);
    }
}