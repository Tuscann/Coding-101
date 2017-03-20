using System;
class Program
{
    static void Main()
    {
        int counter = int.Parse(Console.ReadLine());

        double counterElectricity = 0;
        double priceInternet = 15;
        double priceWater = 20;
        double DDS = 1.2;

        for (int i = 0; i < counter; i++)
        {
            double current = double.Parse(Console.ReadLine());
            counterElectricity += current;
        }
        double totalBill = counterElectricity + counter * priceWater + counter * priceInternet;

        double az = DDS * totalBill;
        double average = (totalBill + DDS * totalBill) / counter;

        Console.WriteLine("Electricity: {0:f2} lv", counterElectricity);
        Console.WriteLine("Water: {0:f2} lv", counter * priceWater);
        Console.WriteLine("Internet: {0:f2} lv", counter * priceInternet);
        Console.WriteLine("Other: {0:f2} lv", az);
        Console.WriteLine("Average: {0:f2} lv", average);
    }
}