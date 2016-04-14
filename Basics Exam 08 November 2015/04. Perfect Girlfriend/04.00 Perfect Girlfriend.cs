using System;
class Problem04PerfectGirlfriend
{
    static void Main()
    {
        string inputLine = Console.ReadLine();
        int perfectGirls = 0;
        while (inputLine != "Enough dates!")
        {
            string[] elements = inputLine.Split('\\');
            string dayOfWeek = elements[0];
            string phone = elements[1];
            string bra = elements[2];
            string name = elements[3];

            int result = 0;
            //add the digit corresponding the day
            int number = 0;
            switch (dayOfWeek)
            {
                case "Monday": number = 1; break;
                case "Tuesday": number = 2; break;
                case "Wednesday": number = 3; break;
                case "Thursday": number = 4; break;
                case "Friday": number = 5; break;
                case "Saturday": number = 6; break;
                case "Sunday": number = 7; break;
            }
            result += number;

            //add the sum of the digits of the phone
            for (int i = 0; i < phone.Length; i++)
            {
                result += int.Parse(phone[i].ToString());
            }

            //exctract the bra size number and letter
            int braSize = 0;
            char braSizeLetter = bra[bra.Length - 1];

            if (bra.Length == 3)
            {
                braSize = int.Parse(bra.Substring(0, 2));
            }
            else
            {
                braSize = int.Parse(bra.Substring(0, 3));
            }

            //multiply the number by the ASCI code of the letter
            // and add it to the result
            result += (braSize * braSizeLetter);

            //take the first letter from the name and multiply its ASCI code by the name length
            char firstLetter = name[0];
            //substract it from the result
            result -= firstLetter * name.Length;

            if (result >= 6000)
            {
                Console.WriteLine("{0} is perfect for you.", name);
                perfectGirls++;
            }
            else
            {
                Console.WriteLine("Keep searching, {0} is not for you.", name);
            }
            inputLine = Console.ReadLine();
        }
        Console.WriteLine(perfectGirls);

    }
}