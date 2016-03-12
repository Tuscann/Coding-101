using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter even number: ");
        int n = int.Parse(Console.ReadLine());

        //var n = 0;
        while (true)
        {
            Console.Write("Enter even number: ");
            n = int.Parse(Console.ReadLine());
            if (n % 2 == 0)
                break; // even number -> exit from the loop
            Console.WriteLine("The number is not even.");
        }
        Console.WriteLine("Even number entered: {0}", n);

        try
        {
            Console.Write("Enter even number: ");
            n = int.Parse(Console.ReadLine());
            if (n%2 == 0)
            
                
            Console.WriteLine("The number is not even.");

        }
        catch 
        {

            Console.WriteLine("Invalid number!");
        }





        //if (n % 2 == 0)
        //{
        //    Console.WriteLine("Even number entered: {0}", n);
        //}
        //else if (n % 2 == 1)
        //{
        //    Console.WriteLine("The number is not even.");
        //}
        //else
        //{
        //    Console.WriteLine("Invalid number!");
        //}
    }
}

