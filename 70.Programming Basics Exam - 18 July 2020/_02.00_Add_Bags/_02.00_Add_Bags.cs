using System;

namespace _02._00_Add_Bags
{
    class Program
    {
        static void Main()
        {
            double cargoMore20kg = Convert.ToDouble(Console.ReadLine());
            double cargoWeits = Convert.ToDouble(Console.ReadLine());
            int traveldays = int.Parse(Console.ReadLine());
            int countCargo = int.Parse(Console.ReadLine());

            if (cargoWeits < 10)
            {
                cargoMore20kg *= 0.2;
            }
            else if (cargoWeits >= 10 && cargoWeits <= 20)
            {
                cargoMore20kg *= 0.5;
            }

            if (traveldays < 7)
            {
                cargoMore20kg *= 1.4;
            }
            else if (traveldays <= 30)
            {
                cargoMore20kg *= 1.15;
            }
            else
            {
                cargoMore20kg *= 1.1;
            }

            double sum = countCargo * cargoMore20kg;

            Console.WriteLine($"The total price of bags is: {sum:0.00} lv.");
        }
    }
}
