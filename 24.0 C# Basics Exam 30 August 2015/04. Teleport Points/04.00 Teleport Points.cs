using System;
class Program
{
    static void Main()
    {
        string[] A = Console.ReadLine().Split();
        string[] B = Console.ReadLine().Split();
        string[] C = Console.ReadLine().Split();
        string[] D = Console.ReadLine().Split();

        double radius = double.Parse(Console.ReadLine());
        double step = double.Parse(Console.ReadLine());

        double Dx = double.Parse(D[0]); double Bx = double.Parse(B[0]);
        double Dy = double.Parse(D[1]); double By = double.Parse(B[1]);
        double Ax = double.Parse(A[0]); double Cx = double.Parse(C[0]);
        double Ay = double.Parse(A[1]); double Cy = double.Parse(C[1]);

        //Console.WriteLine("{0} {1} {2} {3}", Ax, Ay, Bx, By);
        //Console.WriteLine("{0} {1} {2} {3}", Dx, Dy, Cx, Cy);

        double count = 0;

        for (double x = -radius; x <= radius; x += step)
        {
            for (double y = -radius; y <= radius; y += step)
            {
                bool isPodoubleInCircle = x * x + y * y <= radius * radius;
                bool isInsideTheRectangle = (Ax < x && x < Bx) && (By < y && y < Cy);

                if (isPodoubleInCircle && isInsideTheRectangle)
                {
                    count++;
                }
            }
        }
        Console.WriteLine(count);
    }
}
