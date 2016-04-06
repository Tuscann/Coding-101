using System;
class NineDigitMagicNumber
{
    static void Main()
    {
        int sum = int.Parse(Console.ReadLine());
        int diff = int.Parse(Console.ReadLine());
        bool isNum = false;

        for (int i = 111; i <= 777; i++)
        {
            int abc = i;
            int def = abc + diff;
            int ghi = def + diff;

            if (ghi > 777)
            {
                break;
            }
            string wholeNumber = "" + abc + def + ghi;
            if (wholeNumber.Contains("8") || wholeNumber.Contains("9") || wholeNumber.Contains("0"))
            {
                continue;
            }
            int targetSum = 0;

            for (int k = 0; k < wholeNumber.Length; k++)
            {
                targetSum += Convert.ToInt32(Convert.ToString(wholeNumber[k]));
            }
            if (targetSum == sum)
            {
                Console.WriteLine(wholeNumber);
                isNum = true;
            }
        }
        if (!isNum)
        {
            Console.WriteLine("No");
        }
    }
}