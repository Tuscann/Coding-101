using System;
using System.Collections.Generic;
class FitBoxInBox
{
    static void Main(){
        
        List<int> box1 = new List<int>();
        for (int i = 0; i < 3; i++)
        {
            box1.Add(int.Parse(Console.ReadLine()));
        }
        List<int> box2 = new List<int>();
        for (int i = 0; i < 3; i++)
        {
            box2.Add(int.Parse(Console.ReadLine()));
        }
        
        CompareBoxes(box1, box2);

        box2.Reverse(1, 2); CompareBoxes(box1, box2);
       
        box2.Reverse(); CompareBoxes(box1, box2);
        
        box2.Reverse(1, 2); CompareBoxes(box1, box2);

        box2.Reverse(); CompareBoxes(box1, box2);
        
        box2.Reverse(1, 2); CompareBoxes(box1, box2);
       
        box2.Reverse(); CompareBoxes(box2, box1);

        box1.Reverse(1, 2);CompareBoxes(box2, box1);
        
        box1.Reverse();CompareBoxes(box2, box1);
        
        box1.Reverse(1, 2);CompareBoxes(box2, box1);

        box1.Reverse();CompareBoxes(box2, box1);

        box1.Reverse(1, 2); CompareBoxes(box2, box1);
    }
    
    private static void CompareBoxes(List<int> first, List<int> second)
    {
        if (first[0] < second[0] && first[1] < second[1] && first[2] < second[2])
        {
            Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})",
                first[0], first[1], first[2], second[0], second[1], second[2]);
        }
    }
}