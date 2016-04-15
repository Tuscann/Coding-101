using System;
using System.Linq;
class Program
    {
        static void Main()
        {
            var arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var tmp1 = new int[arr.Length / 4];
            var tmp2 = new int[arr.Length / 4];

            for (int i = 0; i < tmp1.Length; i++)     tmp1[i] = arr[i];
            Array.Reverse(arr);

            for (int i = 0; i < tmp2.Length; i++)     tmp2[i] = arr[i];
            Array.Reverse(tmp1);
            Array.Reverse(arr);

            var tmp3 = new int[arr.Length / 2];
            for (int i = 0; i < arr.Length / 2; i++)
                tmp3[i] = arr[i + arr.Length / 4];

            var tmp4 = new int[arr.Length / 2];
            for (int i = 0; i < tmp4.Length / 2; i++)
                tmp4[i] = tmp1[i] + tmp3[i];
            for (int i = 0; i < tmp4.Length / 2; i++)
                tmp4[i + arr.Length / 4] = tmp2[i] + tmp3[i + arr.Length / 4];
            Console.WriteLine(string.Join(" ", tmp4));
        }
    }
