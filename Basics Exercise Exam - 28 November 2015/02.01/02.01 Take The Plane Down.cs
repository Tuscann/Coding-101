using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    You will be given coordinates (x,y) of your headquarters and the distance to the borders.
    On the next line you will receive the number of the fighters that are approaching your country.
    After that for the next N * 2 lanes you will be given all the planes coordinates.

    You need to calculate the distance to every one of them and if they are inside your country shoot them.
    For every plane you destroy you need to print a message for it on the console:
    You destroyed a plane at [x,y]. Where x and y are the coordinates of the plane.
 */
class TakeThePlaneDown
{
    static void Main()
    {
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        int border = int.Parse(Console.ReadLine());
        int planeNumber = int.Parse(Console.ReadLine());

        for (int i = 0; i < planeNumber; i++)
        {
            int xPlaneCoord = int.Parse(Console.ReadLine());
            int yPlaneCoord = int.Parse(Console.ReadLine());

            bool inMyAreaX = (xPlaneCoord <= (border - x)) || (xPlaneCoord <= (border + x));
            bool inMyAreaY = (yPlaneCoord <= (border - y)) || (yPlaneCoord <= (border + y));

            int greaterX = Math.Max(x, xPlaneCoord);
            int smallerX = Math.Min(x, xPlaneCoord);
            int greaterY = Math.Max(y, yPlaneCoord);
            int smallerY = Math.Min(y, yPlaneCoord);

            if (greaterX - smallerX > border || greaterY - smallerY > border)
            {
                continue;
            }

            if (inMyAreaX && inMyAreaY)
            {
                Console.WriteLine("You destroyed a plane at [{0},{1}]", xPlaneCoord, yPlaneCoord);
            }
        }
    }
}