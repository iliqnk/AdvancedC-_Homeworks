using System;
using System.Linq;

class SortArrayOfNumbers
{
    static void Main()
    {
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
        Array.Sort(numbers);
        Console.WriteLine(String.Join(" ", numbers));
    }
}

