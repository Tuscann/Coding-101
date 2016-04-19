using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        var carsAvailable = Console.ReadLine().ToLower().Split(' ').ToList();
        var input = Console.ReadLine().ToLower();
        var carsWanted = new List<string>();
        var count = 0;
        while (input != "end of customers!")
        {

            var typeOfVehicle = input[0];
            var command = input.Split(' ').ToArray();
            var seats = int.Parse(command[2]);
            string wantedVehicle = typeOfVehicle + command[2];
            if (carsAvailable.Contains(wantedVehicle))
            {
                var price = 0;
                price = typeOfVehicle * seats;
                carsWanted.Add($"Yes, sold for {price}$");
                carsAvailable.Remove(wantedVehicle);
                count++;
            }
            else
                carsWanted.Add("No");

            input = Console.ReadLine().ToLower();
        }

        foreach (var result in carsWanted)
            Console.WriteLine(result);
        Console.WriteLine("Vehicles left: " + string.Join(", ", carsAvailable));
        Console.WriteLine("Vehicles sold: {0}", count);
    }
}
