using System;
class MagicStrings
{
    static void Main()
    {
        byte diff = byte.Parse(Console.ReadLine());
        byte[] numbers = { 1, 4, 5, 3 };
        byte[] temp = new byte[8];
        string stringTemp = null;
        bool isValue = false;
        for (byte i0 = 0; i0 < 4; i0++)
        {
            temp[0] = numbers[i0];
            for (byte i1 = 0; i1 < 4; i1++)
            {
                temp[1] = numbers[i1];
                for (byte i2 = 0; i2 < 4; i2++)
                {
                    temp[2] = numbers[i2];
                    for (byte i3 = 0; i3 < 4; i3++)
                    {
                        temp[3] = numbers[i3];


                        for (byte i4 = 0; i4 < 4; i4++)
                        {

                            temp[4] = numbers[i4];
                            for (byte i5 = 0; i5 < 4; i5++)
                            {
                                temp[5] = numbers[i5];
                                for (byte i6 = 0; i6 < 4; i6++)
                                {
                                    temp[6] = numbers[i6];
                                    for (byte i7 = 0; i7 < 4; i7++)
                                    {
                                        temp[7] = numbers[i7];
                                        if (Math.Abs((temp[0] + temp[1] + temp[2] + temp[3]) - (temp[4] + temp[5] + temp[6] + temp[7])) == diff)
                                        {
                                            for (byte j = 0; j < 8; j++)
                                            {
                                                if (temp[j] == 3) stringTemp += "s";
                                                if (temp[j] == 4) stringTemp += "n";
                                                if (temp[j] == 1) stringTemp += "k";
                                                if (temp[j] == 5) stringTemp += "p";
                                            }
                                            Console.WriteLine(stringTemp);
                                            stringTemp = null;
                                            isValue = true;
                                        }

                                    }
                                }
                            }
                        }

                    }
                }
            }
        }

        if (!isValue) Console.WriteLine("No");
    }
}