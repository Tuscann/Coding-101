using System;
class ProspectInHospitality
{
    static void Main()
    {
        uint buildersNeeded = uint.Parse(Console.ReadLine());
        uint receptNeeded = uint.Parse(Console.ReadLine());
        uint chambNeeded = uint.Parse(Console.ReadLine());
        uint techniciansNeeded = uint.Parse(Console.ReadLine());
        uint othersNeeded = uint.Parse(Console.ReadLine());
        decimal nikisSalary = decimal.Parse(Console.ReadLine());
        decimal currensyUSA = decimal.Parse(Console.ReadLine());
        decimal mySalary = decimal.Parse(Console.ReadLine());
        decimal budget = decimal.Parse(Console.ReadLine());

        decimal buildersSalary = buildersNeeded * (decimal)1500.04;
        decimal receptSalary = receptNeeded * (decimal)2102.10;
        decimal chambSalary = chambNeeded * (decimal)1465.46;
        decimal techniciansSalary = techniciansNeeded * (decimal)2053.33;
        decimal othersSalary = othersNeeded * (decimal)3010.98;
        decimal nikisLv = nikisSalary * currensyUSA;
        decimal amount = buildersSalary + receptSalary + chambSalary + techniciansSalary + othersSalary + nikisLv + mySalary;

        if (amount <= budget)
        {
            decimal left = budget - amount;
            Console.WriteLine("The amount is: {0:F2} lv.", amount);
            Console.WriteLine(@"YES \ Left: {0:F2} lv.", left);
        }
        else
        {
            decimal need = Math.Abs(budget - amount);
            Console.WriteLine("The amount is: {0:F2} lv.", amount);
            Console.WriteLine(@"NO \ Need more: {0:F2} lv.", need);
        }
    }
}