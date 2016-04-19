using System;
using System.Numerics;
class Program
{
    static void Main()
    {
        BigInteger a1 = new BigInteger(int.Parse(Console.ReadLine()));
        BigInteger a2 = new BigInteger(int.Parse(Console.ReadLine()));
        BigInteger a3 = new BigInteger(int.Parse(Console.ReadLine()));
        BigInteger n = new BigInteger(int.Parse(Console.ReadLine()));
        
        if (n==1){Console.WriteLine(a1);}
        else if(n == 2){Console.WriteLine(a2);}
        else if (n == 3){Console.WriteLine(a3);}
        else
        {
            BigInteger total = 0;
            for (int i = 4; i <= n; i++)
            {
                total = a1 + a2 + a3;
                a1 = a2;
                a2 = a3;
                a3 = total;
            }
            Console.WriteLine(total);
        }
    }
}

