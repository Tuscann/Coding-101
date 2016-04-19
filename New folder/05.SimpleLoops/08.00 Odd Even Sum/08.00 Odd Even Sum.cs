using System;
class Program
{
    static void Main()
    {

        int n = int.Parse(Console.ReadLine());

        int sumChetno = 0; int sumnechetno = 0;

        for (int i = 0; i < n; i++)
        {
            int k = int.Parse(Console.ReadLine());


            if (i%2==0)
            {
                sumChetno += k;
            }
            else
            {
                sumnechetno += k;
            }
        }
        if (sumChetno == sumnechetno)
        {
            Console.WriteLine("Yes\nsum = {0}", sumChetno);
        }
        else
        {
            Console.WriteLine("No\nDiff = {0}", Math.Abs(sumChetno - sumnechetno));
        }
    }
}

