using System;
class Program
{
    static void Main()
    {
        double prosseroDolari = double.Parse(Console.ReadLine());
        double videoPrice = double.Parse(Console.ReadLine());
        double ramPrice = double.Parse(Console.ReadLine());
        int countRam = int.Parse(Console.ReadLine());
        double prosent = double.Parse(Console.ReadLine());

        if (prosseroDolari >= 200.00 && prosseroDolari <= 3000.00)
        {
            double sum1 = prosseroDolari * 1.57 * (1 - prosent);
            double sum2 = videoPrice * 1.57 * (1 - prosent);
            double sum3 = ramPrice * 1.57 * countRam;

            Console.WriteLine("Money needed - {0:f2} leva.", sum1 + sum2 + sum3);
        }
    }
}