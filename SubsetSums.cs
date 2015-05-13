using System;
using System.Collections.Generic;
using System.Linq;

internal class SubsetSums
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).Distinct().ToArray();
        List<int> subset = new List<int>();
        bool found = false;
        int combinations = (int)Math.Pow(2, numbers.Length);
        for (int i = 0; i < combinations; i++)
        {
            for (int j = 0; j < numbers.Length; j++)
            {
                if ((i & (1 << j)) != 0)
                {
                    subset.Add(numbers[j]);
                }
            }
            if (subset.Sum() == n && subset.Count != 0)
            {
                found = true;
                Console.WriteLine("{0} = {1}",string.Join(" + ",subset), n);
            }
            subset.Clear();
        }
        if (!found)
        {
            Console.WriteLine("No matching subsets.");
        }
    }
}

