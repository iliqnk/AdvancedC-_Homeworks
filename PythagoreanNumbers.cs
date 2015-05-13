using System;

class PythagoreanNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        bool found = false;
        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }
        for (int first = 0; first < n; first++)
        {
            for (int second = 0; second < n; second++)
            {
                for (int third = 0; third < n; third++)
                {
                    if (Math.Pow(numbers[first], 2) + Math.Pow(numbers[second], 2) ==
                        Math.Pow(numbers[third], 2) && numbers[first] <= numbers[second])
                    {
                        found = true;
                        Console.WriteLine("{0}*{0} + {1}*{1} = {2}*{2}", numbers[first],
                            numbers[second], numbers[third]);
                    }
                }
            }
        }
        if (!found)
        {
            Console.WriteLine("No");
        }
    }
}