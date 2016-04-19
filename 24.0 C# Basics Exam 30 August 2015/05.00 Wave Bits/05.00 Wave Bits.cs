using System;
public class WaveBits
{
    public static void Main()
    {
        ulong number = ulong.Parse(Console.ReadLine());

        int bestSequenceLength = 0;
        int bestSequenceStartIndex = 0;
        int currentSequenceLength = 1;

        // ends at 61, because the following boolean expressions will eventually check bits @62 and @63
        for (int i = 0; i <= 61; i++)
        {
            bool isFirstBitUp = ((number >> i) & 1) == 1;
            bool isSecondBitDown = ((number >> i + 1) & 1) == 0;
            bool isThirdBitUp = ((number >> i + 2) & 1) == 1;

            bool isWaveTriple = isFirstBitUp && isSecondBitDown && isThirdBitUp;

            if (isWaveTriple)
            {
                // our sequence always starts from 1, so we only need to increment by 2
                // for example 1 + 2 + 2 is the length of 10101
                currentSequenceLength += 2;

                if (currentSequenceLength > bestSequenceLength)
                {
                    bestSequenceStartIndex = i + 2;
                    bestSequenceLength = currentSequenceLength;
                }

                // skip the zero in the middle of the triple and test the next three bits
                i++;
            }
            else
            {
                // the current sequence has ended, so start over
                currentSequenceLength = 1;
            }
        }

        int bestSequenceEndIndex = bestSequenceStartIndex - bestSequenceLength + 1;
        ulong outputNumber = 0UL;

        for (int i = 63; i >= 0; i--)
        {
            bool inShouldBeDeletedRange = i <= bestSequenceStartIndex && i >= bestSequenceEndIndex;
            if (inShouldBeDeletedRange)
            {
                outputNumber >>= 1;
            }
            else
            {
                ulong currentBit = number & (1UL << i);
                outputNumber |= currentBit;
            }
        }

        if (bestSequenceLength == 0)
        {
            Console.WriteLine("No waves found!");
        }
        else
        {
            Console.WriteLine(outputNumber);
        }
    }
}

