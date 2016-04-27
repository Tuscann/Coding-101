using System;
class Program
{
    static void Main()
    {
        Random rnd = new Random();
        string[] words = Console.ReadLine().Split(' ');

        for (int word = 0; word < words.Length - 1; word++)
        {
            int swapIndex = rnd.Next(word + 1, words.Length);
            words = Swap(words, word, swapIndex);
        }
        //foreach (var word in words)
        //{
        //    Console.WriteLine(word);
        //}
        Console.WriteLine(string.Join("\r\n", words));
    }
    private static string[] Swap(string[] words, int index1, int index2)
    {
        string temp = words[index1];
        words[index1] = words[index2];
        words[index2] = temp;

        return words;
    }
}