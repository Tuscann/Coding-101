using System;
class Program
{
    static void Main() // 100/100
    {
        int HourIzpit = int.Parse(Console.ReadLine());
        int MinIzpit = int.Parse(Console.ReadLine());
        int HourPrist = int.Parse(Console.ReadLine());
        int MinPrist = int.Parse(Console.ReadLine());
        int ObMinIzpit = HourIzpit * 60 + MinIzpit;
        int ObMinPrist = HourPrist * 60 + MinPrist;
        if (ObMinIzpit == ObMinPrist || (ObMinIzpit > ObMinPrist && ObMinIzpit - ObMinPrist <= 30))
        {
            Console.WriteLine("On time");
        }
        if (ObMinIzpit > ObMinPrist && ObMinIzpit - ObMinPrist > 30)
        {
            Console.WriteLine("Early");
        }
        if (ObMinPrist > ObMinIzpit)
        {
            Console.WriteLine("Late");
        }
        if (Math.Abs(ObMinPrist - ObMinIzpit) != 0)
        {
            int hours = Math.Abs(ObMinPrist - ObMinIzpit) / 60;
            int mins = Math.Abs(ObMinPrist - ObMinIzpit) % 60;
            if (hours >= 1)
            {
                if (mins < 10) Console.Write(hours + ":0" + mins + " hours");
                else Console.Write(hours + ":" + mins + " hours");
            }
            else Console.Write(mins + " minutes");
            if ((ObMinPrist - ObMinIzpit) < 0)
                Console.WriteLine(" before the start");
            else
                Console.WriteLine(" after the start");
        }
    }
}