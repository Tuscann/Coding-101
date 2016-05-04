using System;
class Program
{
    static void Main()
    {
        long centerX = long.Parse(Console.ReadLine());
        long centerY = long.Parse(Console.ReadLine());
        long distancetoBorder = long.Parse(Console.ReadLine());
        long detectedPlanes = long.Parse(Console.ReadLine());

        for (int plane = 0; plane < detectedPlanes; plane++)
        {
            long planeX = int.Parse(Console.ReadLine());
            long planeY = int.Parse(Console.ReadLine());

            double planeDistanceX = planeX - centerX;
            double planeDistanceY = planeY - centerY;

            double distanceToPlane = Math.Sqrt((planeDistanceX * planeDistanceX) + (planeDistanceY * planeDistanceY));

            if (distancetoBorder >= distanceToPlane)
            {
                Console.WriteLine("You destroyed a plane at [{0},{1}]", planeX, planeY);
            }
        }
    }
}