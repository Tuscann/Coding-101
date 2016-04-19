using System;
using System.Text;
class BitsUp
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());

        int number = 0;

        // StringBuilder binaries will be storing the binary representation of all n numbers
        StringBuilder binaries = new StringBuilder();

        // for all n numbers read from the console
        for (int i = 0; i < n; i++)
        {
            number = int.Parse(Console.ReadLine()); // read the number
            string bin = Convert.ToString(number, 2).PadLeft(8, '0'); // convert the number to a binary string
            binaries.Append(bin); // append the above binary string to StringBuilder binaries 
        }
        // Console.WriteLine(binaries);  // uncomment if you want to see the binary representations of all n numbers combined in one string

        // logic
        for (int j = 0; j < binaries.Length; j++)
        {
            // set to 1 the bits at positions: 1, 1 + step, 1 + 2*step, ... 
            // if step = 1, 1 % 1 = 0, so the first condition won't help, and we also need the second one
            if (j % step == 1 || (step == 1 && j > 0))
            {
                binaries[j] = '1';
            }
        }
        // Console.WriteLine(binaries); // uncomment if you want to see the upped bits at the required positions (the ammended StringBuilder binaries)

        // converting the above StringBuilder binary into an array of final int numbers
        int[] numbers = new int[n]; // here we will be storing the final int numbers
        int index = 0;
        string temp = binaries.ToString(); // converting StringBuilder binaries to string
        for (int k = 0; k < binaries.Length; k += 8)
        {
            string sub = temp.Substring(k, 8); // splitting the temp string into 8-chars substrings
            numbers[index] = Convert.ToInt32(sub, 2); // converting the substrings into int numbers
            index++;
        }

        // printing the final int numbers
        for (int l = 0; l < n; l++)
        {
            Console.WriteLine(numbers[l]);
        }
    }
}