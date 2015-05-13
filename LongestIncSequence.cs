using System;
using System.Linq;

class LongestIncSequence
{
    private static void Main()
    {
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int count = 1;
        int maxLength = 1;
        int endIndex = 0;
        Console.Write(numbers[0]);
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > numbers[i - 1])
            {
                count++;
                Console.Write(" " + numbers[i]);
            }
            else
            {
                count = 1;
                Console.Write("\n" + numbers[i]);
            }
            if (count > maxLength)
            {
                maxLength = count;
                endIndex = i;
            }
        }
        Console.WriteLine();
        Console.Write("Longest:");
        for (int i = endIndex - maxLength + 1; i <= endIndex; i++)
        {
            Console.Write(" " + numbers[i]);
        }
        Console.WriteLine();
    }
}