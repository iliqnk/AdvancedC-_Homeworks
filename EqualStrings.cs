using System;

class EqualStrings
{
    static void Main()
    {
        string[] inputString = Console.ReadLine().Split();
        Console.Write(inputString[0]);
        for (int i = 1; i < inputString.Length; i++)
        {
            if (inputString[i] == inputString[i - 1])
            {
                Console.Write(" " + inputString[i]);
            }
            else
            {
                Console.Write("\n" + inputString[i]);
            }
        }
        Console.WriteLine();
    }
}