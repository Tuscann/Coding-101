using System;
class DetectiveBoev
{
    static void Main()
    {
        //Въвеждаме думата
        string word = Console.ReadLine();
        //Въвеждаме съобщението
        string message = Console.ReadLine();
        //Създаваме си променлива за сумата от ASCII кодовете на символите от думата
        int wordSum = 0;
        //Добавяме всяка стойност към сумата
        for (int i = 0; i < word.Length; i++)
        {
            wordSum += (char)word[i];
        }
        //Създаваме променлива, в която запазваме маската.
        int mask = 0;
        //Създавам друга променлива, която е равна на wordSum
        int otherWordSum = wordSum;
        //Въртим цикъл, с условие докато тази сума е по-голяма от 9
        while (otherWordSum > 9)
        {
            //Въртим цикъл, с условие докато тази сума е различна от 0, взимайки всяка цифра от сумата
            while (otherWordSum != 0)
            {
                mask += otherWordSum % 10;
                otherWordSum /= 10;
            }
            //Правим тази сума да е равна на маската
            otherWordSum = mask;
            //Ако маската е по-голяма от 9, маската става равна на 0
            if (mask > 9)
            {
                mask = 0;
            }
        }
        //Създаваме символен празен символен низ, в който пазим крайния резултат
        string final = string.Empty;
        //Създаваме променлива, в която ще пазим стойността на текущия символ
        int currentSymbol = 0;
        for (int i = 0; i < message.Length; i++)
        {
            //Ако остатъкът при деление на ASCII кодът на символ от съобщението с маската е равен на 0, добавяме маската към ASCII кода на символа
            if ((char)message[i] % mask == 0)
            {
                currentSymbol = (char)message[i] + mask;
                char symbol = (char)currentSymbol;
                final += symbol;
            }
            //Иначе изваждаме ASCII кода на маската 
            else
            {
                currentSymbol = (char)message[i] - mask;
                char symbol = (char)currentSymbol;
                final += symbol;
            }
        }
        //Превръщаме символният низ с крайния резултат към масив от char-ове
        char[] array = final.ToCharArray();
        //Обръщаме масива в обратен ред
        Array.Reverse(array);
        //Отпечатваме масива
        Console.WriteLine(array);
    }
}