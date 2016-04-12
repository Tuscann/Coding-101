using System;
using System.Collections.Generic;
using System.Linq;
class SequenceOfKNumbers
    {
        public static List<int> printCollection = new List<int>();
        private static void GetList(List<int> inputCollection, int elementK, int startPos)
        {

            int checkForSequence = 1;
            for (int i = 0; i < elementK - 1; i++)
            {
                if (startPos + i >= inputCollection.Count)
                {
                    printCollection.AddRange(inputCollection);
                    return;
                }
                if ((i + startPos + 1) < inputCollection.Count)
                {
                    if (inputCollection[i + startPos] == inputCollection[i + startPos + 1])
                    {
                        checkForSequence++;
                    }
                }
            }
            if (checkForSequence == elementK)
            {
                inputCollection.RemoveRange(0 + startPos, elementK);
                GetList(inputCollection, elementK, startPos);
            }
            else
            {
                GetList(inputCollection, elementK, startPos + 1);
            }

        }

        static void Main()
        {
            List<int> inputCollection = Console.ReadLine().Split(' ').Select(Int32.Parse).ToList();
            int elementK = int.Parse(Console.ReadLine());
            if (elementK != 1)
            {
                GetList(inputCollection, elementK, 0);
            }
            foreach (int item in printCollection)
            {
                Console.Write("{0} ", item);
            }
        }
    }
