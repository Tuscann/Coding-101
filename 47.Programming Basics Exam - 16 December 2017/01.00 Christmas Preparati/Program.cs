using System;
class Program
{
    static void Main()   // 100/100
    {
        int countPaper = int.Parse(Console.ReadLine());
        int countCoton = int.Parse(Console.ReadLine());
        double litersGlue = double.Parse(Console.ReadLine());
        double discount = double.Parse(Console.ReadLine());

        double sum = countPaper * 5.80 + countCoton * 7.20 + litersGlue * 1.2;

        sum *= 1 - discount / 100;
        Console.WriteLine("{0:f3}", sum);
    }
}