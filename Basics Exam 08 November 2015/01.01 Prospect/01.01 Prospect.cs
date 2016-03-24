using System;


class ProspectInHospitality
{
    static void Main()
    {
        // input
        uint builders = uint.Parse(Console.ReadLine()); // 0; // 20; // 
        uint receptionists = uint.Parse(Console.ReadLine()); //20; // 10; // 
        uint chambermaids = uint.Parse(Console.ReadLine()); // 50; // 8; //
        uint technicians = uint.Parse(Console.ReadLine()); // 0; // 2; // 
        uint other = uint.Parse(Console.ReadLine()); // 100; // 4; // 
        decimal niki = decimal.Parse(Console.ReadLine()); // 1000.5M; // 3000.06M; // 
        decimal exchangeRate = decimal.Parse(Console.ReadLine()); // 1.89M; // 1.08; // 0.87M; // 
        decimal salary = decimal.Parse(Console.ReadLine()); // 100000.698M; // 30000.0001M; //
        decimal mBudget = decimal.Parse(Console.ReadLine()); // 100000.691M; // 2000000.003M; //

        decimal result = builders * 1500.04M +
            receptionists * 2102.10M +
            chambermaids * 1465.46M +
            technicians * 2053.33M +
            other * 3010.98M +
            niki * exchangeRate +
            salary;

        // output
        Console.WriteLine("The amount is: {0:F2} lv.", result);
        if (result <= mBudget)
        {
            Console.WriteLine("YES \\ Left: {0:F2} lv.", mBudget - result);
        }
        else
        {
            Console.WriteLine("NO \\ Need more: {0:F2} lv.", result - mBudget);
        }
    }
}