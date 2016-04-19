using System;

class dasd
{
    static void Main()
    {

      double numbers = double.Parse(Console.ReadLine());
        
      decimal sum = 0.0m;
      for (double i = 0; i < numbers; i++)
      {
        sum = sum + decimal.Parse(Console.ReadLine());
      }
       Console.WriteLine("{0}",sum);

    }
}


