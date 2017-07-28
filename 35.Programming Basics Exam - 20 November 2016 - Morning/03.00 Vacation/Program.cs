using System;
class Program
{
    static void Main()
    {
        double oldPeople = double.Parse(Console.ReadLine());
        double students = double.Parse(Console.ReadLine());
        double nights = double.Parse(Console.ReadLine());
        string typetransport = Console.ReadLine();
        double total = 0.00;

        if (typetransport == "train")
        {
            if (oldPeople + students >= 50)
            {
                total = (oldPeople * 24.99 / 2 + students * 14.99 / 2) * 2.00 + nights * 82.99 ;
            }
            else
            {
                total = (oldPeople * 24.99 + students * 14.99) * 2.00 + nights * 82.99;
            }
        }
        else if (typetransport == "bus")
        {
            total = (oldPeople * 32.50 + students * 28.50) * 2.00 + nights * 82.99 ;
        }
        else if (typetransport == "boat")
        {
            total = (oldPeople * 42.99 + students * 39.99) * 2.00 + nights * 82.99 ;
        }
        else if (typetransport == "airplane")
        {
            total = (oldPeople * 70.00 + students * 50.00) * 2.00 + nights * 82.99 ;
        }
        Console.WriteLine("{0:f2}", total * 1.10);
    }
}