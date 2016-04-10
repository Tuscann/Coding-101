using System;
internal class OddEvenElements
{
    private static void Main()
    {
        string n = Console.ReadLine();
        double sumOdd = 0; double sumEven = 0;
        double maxEven = 0; double maxOdd = 0;
        double minOdd = 0; double minEven = 0;
        
        int index = 1;
        string[] numbers = n.Split(' ');

        if (numbers[0] != "")
        {
            foreach (string item in numbers)
            {
                double num = double.Parse(item);
                if (index % 2 == 1)
                {
                    sumOdd += num;
                    if (minOdd == 0) { minOdd = num; }
                    else { minOdd = Math.Min(minOdd, num); }
                    if (maxOdd == 0) { maxOdd = num; }
                    else { maxOdd = Math.Max(maxOdd, num); }
                    index++;
                }
                else if (index % 2 == 0)
                {
                    sumEven += num;
                    if (minEven == 0) { minEven = num; }
                    else { minEven = Math.Min(minEven, num); }
                    if (maxEven == 0) { maxEven = num; }
                    else { maxEven = Math.Max(maxEven, num); }
                    index++;
                }
            }
        }

        if (numbers[0] == "")
        {
            Console.WriteLine("OddSum=No, OddMin=No, OddMax=No, EvenSum=No, EvenMin=No, EvenMax=No");
        }
        else if (numbers.Length < 2)
        {
            Console.WriteLine("OddSum={0:0.##}, OddMin={1:0.##}, OddMax={2:0.##}, EvenSum=No, EvenMin=No, EvenMax=No", sumOdd, minOdd, maxOdd);
        }
        else
        {
            Console.WriteLine("OddSum={0:0.##}, OddMin={1:0.##}, OddMax={2:0.##}, EvenSum={3:0.##}, EvenMin={4:0.##}, EvenMax={5:0.##}", sumOdd, minOdd, maxOdd, sumEven, minEven, maxEven);
        }
    }
}