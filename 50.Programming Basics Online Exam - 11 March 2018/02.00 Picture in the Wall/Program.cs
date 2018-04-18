using System;
class Program
{
    static void Main()
    {
        int holeW = int.Parse(Console.ReadLine());
        int daljina = int.Parse(Console.ReadLine());
        int pictureSide = int.Parse(Console.ReadLine());
        int numberPictures = int.Parse(Console.ReadLine());
        
        int holeSize = holeW  * daljina;
        int allPicturesSize = pictureSide  * pictureSide  * numberPictures ;

        if (holeSize  > allPicturesSize )
        {
            Console.WriteLine("The pictures fit in the hole. Hole area is {0} bigger than pictures area.", holeSize  - allPicturesSize );
        }
        else
        {
            Console.WriteLine("The pictures don't fit in the hole. Picture area is {0} bigger than hole area.", allPicturesSize  - holeSize );
        }
    }
}