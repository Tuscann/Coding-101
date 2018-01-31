using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int times = (4 * n - 8) / 2;

        for (int i = 1; i <= n - 2; i++)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write("*\\");
            }
            Console.Write("{0}    {0}", new string(' ', times - i * 2));
            for (int j = 0; j < i; j++)
            {
                Console.Write("/*");
            }
            Console.WriteLine();
        }
        for (int i = 0; i < n-2; i++)
        {
            

            Console.WriteLine("{0}{1}{2}    {2}{3}{4}", new string('*', times / 2 - i), new string('/', times / 2 - i), new string(' ',  i*2), new string('\\', times / 2 - i), new string('*', times / 2 - i));

        }
        times = (4 * n - 10) / 2;

       

        
        for (int i = 0; i < n / 2; i++)
        {
            Console.WriteLine("{0}*|**|*{1}", new string('<', times), new string('>', times));
        }
        Console.WriteLine("{0}{1}", new string('/', (4 * n - 4) / 2), new string('\\', (4 * n - 4) / 2));

        times = (4 * n - 8) / 2;
        for (int i = 0; i < n - 2; i++)
        {
            Console.WriteLine("{0}{1}{2}    {2}{3}", new string('*', times / 2 - i), new string('/', times / 2 - i), new string(' ', i * 2), new string(' ', times / 2 - i));
        }




        //public static void main(String[] args) throws IOException {
        //    BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
        //    int n = Integer.valueOf(reader.readLine());

        //    upperPart(n);
        //    middlePart(n);
        //    bottomPart(n);

        //}

        //private static void bottomPart(int n)
        //{
        //    int times = ((4 * n) - 8) / 2;
        //    for (int i = 0; i < n - 2; i++)
        //    {
        //        System.out.print(generateFrom("*/", times / 2 - i));
        //        System.out.print(generateFrom(" ", i * 2));
        //        System.out.print(generateFrom(" ", 4));
        //        System.out.print(generateFrom(" ", i * 2));
        //        System.out.println(generateFrom("\\*", times / 2 - i));
        //    }
        //}

        //private static void upperPart(int n)
        //{
        //    int times = ((4 * n) - 8) / 2;
        //    for (int i = 1; i <= n - 2; i++)
        //    {
        //        System.out.print(generateFrom("*\\", i));
        //        System.out.print(generateFrom(" ", times - i * 2));
        //        System.out.print(generateFrom(" ", 4));
        //        System.out.print(generateFrom(" ", times - i * 2));
        //        System.out.println(generateFrom("/*", i));
        //    }
        //}

        //private static void middlePart(int n)
        //{
        //    int times = ((4 * n) - 10) / 2;
        //    System.out.println(generateFrom("\\/", ((4 * n) - 4) / 2));
        //    for (int i = 0; i < n / 2; i++)
        //    {
        //        System.out.print(generateFrom("<", times));
        //        System.out.print("*|**|*");
        //        System.out.println(generateFrom(">", times));
        //    }
        //    System.out.println(generateFrom("/\\", ((4 * n) - 4) / 2));


        //}

        //private static String generateFrom(String input, int times)
        //{
        //    StringBuilder builder = new StringBuilder();
        //    for (int i = 0; i < times; i++)
        //    {
        //        builder.append(input);
        //    }
        //    return builder.toString();
        //}
    }
}