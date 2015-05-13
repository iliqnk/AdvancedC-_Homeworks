using System;
using System.Collections.Generic;
using System.Linq;

class FindMinMaxAverage
{
    static void Main()
    {
        double[] inputNumbers = Console.ReadLine().Split().Select(double.Parse).ToArray();
        List<double> doubles = new List<double>();
        List<int> ints = new List<int>();
        for (int i = 0; i < inputNumbers.Length; i++)
        {
            if (inputNumbers[i] % 1 == 0)
            {
                ints.Add((int)inputNumbers[i]);
            }
            else
            {
                doubles.Add(inputNumbers[i]);
            }
        }
        Console.WriteLine("[{0}] -> min: {1}, max: {2}, sum: {3}, avg: {4:F2}",
                string.Join(", ",doubles), doubles.Min(), doubles.Max(), doubles.Sum(), doubles.Average()
            );
        Console.WriteLine();
        Console.WriteLine("[{0}] -> min: {1}, max: {2}, sum: {3}, avg: {4:F2}",
                string.Join(", ", ints), ints.Min(), ints.Max(), ints.Sum(), ints.Average()
            );
    }
}
