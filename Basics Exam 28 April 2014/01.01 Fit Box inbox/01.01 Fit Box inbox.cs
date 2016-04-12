using System;
class FitBoxInBox
{
    static void Main()
    {
        int w1 = int.Parse(Console.ReadLine());
        int h1 = int.Parse(Console.ReadLine());
        int d1 = int.Parse(Console.ReadLine());

        int w2 = int.Parse(Console.ReadLine());
        int h2 = int.Parse(Console.ReadLine());
        int d2 = int.Parse(Console.ReadLine());

        // Try to fit the first box inside the second box (6 possibilities)
        CheckBoxes(w1, h1, d1, w2, h2, d2);
        CheckBoxes(w1, h1, d1, w2, d2, h2);
        CheckBoxes(w1, h1, d1, h2, w2, d2);
        CheckBoxes(w1, h1, d1, h2, d2, w2);
        CheckBoxes(w1, h1, d1, d2, w2, h2);
        CheckBoxes(w1, h1, d1, d2, h2, w2);

        // Try to fit the second box inside the first box (6 possibilities)
        CheckBoxes(w2, h2, d2, w1, h1, d1);
        CheckBoxes(w2, h2, d2, w1, d1, h1);
        CheckBoxes(w2, h2, d2, h1, w1, d1);
        CheckBoxes(w2, h2, d2, h1, d1, w1);
        CheckBoxes(w2, h2, d2, d1, w1, h1);
        CheckBoxes(w2, h2, d2, d1, h1, w1);
    }

    private static void CheckBoxes(
        int firstWidth, int firstHeight, int firstDepth,
        int secondWidth, int secondHeight, int secondDepth)
    {
        if (firstWidth < secondWidth && firstHeight < secondHeight && firstDepth < secondDepth)
        {
            Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})",
                firstWidth, firstHeight, firstDepth, secondWidth, secondHeight, secondDepth);
        }
    }
}
